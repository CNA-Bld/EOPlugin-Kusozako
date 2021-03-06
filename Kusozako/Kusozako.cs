﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Codeplex.Data;
using ElectronicObserver.Window;
using ElectronicObserver.Window.Plugins;
using Fiddler;
using Logger = ElectronicObserver.Utility.Logger;

namespace Kusozako
{
    public class Kusozako : ServerPlugin
    {
	    public override string MenuTitle => "クソ雑魚回線やめてください";
	    public override string Version => "<BUILD_VERSION>";

	    private const string PLUGIN_SETTINGS = @"Settings\Kusozako.json";
	    public Settings settings;
	    private HttpClient httpClient;

		public override bool RunService(FormMain main)
		{
			if (File.Exists(PLUGIN_SETTINGS))
				settings = DynamicJson.Parse(File.ReadAllText(PLUGIN_SETTINGS)).Deserialize<Settings>();
			else
				settings = new Settings();

			createHttpClient();

			FiddlerApplication.BeforeRequest += FiddlerApplication_BeforeRequest;
			return true;
		}

		private void createHttpClient()
		{
			httpClient?.Dispose();

			if (settings.Proxy.Length > 0)
			{
				httpClient = new HttpClient(new HttpClientHandler
				{
					Proxy = new WebProxy(settings.Proxy, false),
					UseProxy = true
				});
			}
			else
			{
				httpClient = new HttpClient();
			}
			httpClient.Timeout = TimeSpan.FromSeconds(10);
		}

		private void FiddlerApplication_BeforeRequest(Session oSession)
		{
			if (!settings.Enabled) return;
			if (oSession.PathAndQuery.Contains("/kcsapi/"))
			{
				waitForProber(oSession.host, 0);
			} 
		}

		// Blocks and returns only when Prober says OK.
		private void waitForProber(string host, int depth)
		{
			if (depth > settings.MaxDepth)
			{
				// Let it go, let it go. Can't hold it back anymore.
				return;
			}

			var url = $"http://{host}{settings.ProberUri}";
			var responsive = false;
			try
			{
				var response = httpClient.GetAsync(url).Result;
				responsive = response.IsSuccessStatusCode || (settings.AllowClientErrors && isClientError(response.StatusCode));
			}
			catch
			{ 
			}

			if (!responsive) {
				var sleepSeconds = depth > 4 ? 32 : Math.Pow(2, depth);
				Logger.Add(2, $"クソ雑魚回線やめてくださいちょっと ({depth}, will wait for {sleepSeconds} secs)");
				Thread.Sleep(TimeSpan.FromSeconds(sleepSeconds));
				waitForProber(host, depth + 1);
			}
		}

		private static bool isClientError(HttpStatusCode statusCode)
		{
			return (int) statusCode >= 400 && (int) statusCode <= 499;
		}

		public void SaveSettings()
		{
			if (settings == null)
			{
				settings = new Settings();
			}
			if (!Directory.Exists("Settings"))
			{
				Directory.CreateDirectory("Settings");
			}
			File.WriteAllText(PLUGIN_SETTINGS, DynamicJson.Serialize(settings));

			createHttpClient();
		}

		public override PluginSettingControl GetSettings()
		{
			return new KusozakoSettingsControl(this);
		}

	}
}
