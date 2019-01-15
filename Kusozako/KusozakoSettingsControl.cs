using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectronicObserver.Window.Plugins;

namespace Kusozako
{
	public partial class KusozakoSettingsControl : PluginSettingControl
	{
		private Kusozako plugin;

		public KusozakoSettingsControl(Kusozako plugin)
		{
			this.plugin = plugin;
			InitializeComponent();
		}

		private void KusozakoSettingsControl_Load(object sender, EventArgs e)
		{
			checkBoxEnabled.Checked = plugin.settings.Enabled;
			textBoxProxy.Text = plugin.settings.Proxy;
			textBoxProberUri.Text = plugin.settings.ProberUri;
			checkBoxAllowClientErrors.Checked = plugin.settings.AllowClientErrors;
			numericUpDownMaxRetries.Value = plugin.settings.MaxDepth;
		}

		public override bool Save()
		{
			plugin.settings.Enabled = checkBoxEnabled.Checked;
			plugin.settings.Proxy = textBoxProxy.Text;
			plugin.settings.ProberUri = textBoxProberUri.Text;
			plugin.settings.AllowClientErrors = checkBoxAllowClientErrors.Checked;
			plugin.settings.MaxDepth = (int) numericUpDownMaxRetries.Value;
			plugin.SaveSettings();
			return true;
		}

	}
}
