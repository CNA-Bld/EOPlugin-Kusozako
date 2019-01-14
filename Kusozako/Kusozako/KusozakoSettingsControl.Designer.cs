namespace Kusozako
{
	partial class KusozakoSettingsControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
			this.labelProxy = new System.Windows.Forms.Label();
			this.labelProberUri = new System.Windows.Forms.Label();
			this.labelMaxRetries = new System.Windows.Forms.Label();
			this.textBoxProxy = new System.Windows.Forms.TextBox();
			this.textBoxProberUri = new System.Windows.Forms.TextBox();
			this.numericUpDownMaxRetries = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRetries)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.checkBoxEnabled, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelProxy, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.labelProberUri, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.labelMaxRetries, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.textBoxProxy, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.textBoxProberUri, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.numericUpDownMaxRetries, 1, 3);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 4;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.Size = new System.Drawing.Size(150, 150);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// checkBoxEnabled
			// 
			this.checkBoxEnabled.AutoSize = true;
			this.tableLayoutPanel.SetColumnSpan(this.checkBoxEnabled, 2);
			this.checkBoxEnabled.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBoxEnabled.Location = new System.Drawing.Point(3, 3);
			this.checkBoxEnabled.Name = "checkBoxEnabled";
			this.checkBoxEnabled.Size = new System.Drawing.Size(144, 17);
			this.checkBoxEnabled.TabIndex = 0;
			this.checkBoxEnabled.Text = "Enabled";
			this.checkBoxEnabled.UseVisualStyleBackColor = true;
			// 
			// labelProxy
			// 
			this.labelProxy.AutoSize = true;
			this.labelProxy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelProxy.Location = new System.Drawing.Point(3, 23);
			this.labelProxy.Name = "labelProxy";
			this.labelProxy.Size = new System.Drawing.Size(63, 26);
			this.labelProxy.TabIndex = 1;
			this.labelProxy.Text = "Proxy";
			// 
			// labelProberUri
			// 
			this.labelProberUri.AutoSize = true;
			this.labelProberUri.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelProberUri.Location = new System.Drawing.Point(3, 49);
			this.labelProberUri.Name = "labelProberUri";
			this.labelProberUri.Size = new System.Drawing.Size(63, 26);
			this.labelProberUri.TabIndex = 2;
			this.labelProberUri.Text = "Prober URI";
			// 
			// labelMaxRetries
			// 
			this.labelMaxRetries.AutoSize = true;
			this.labelMaxRetries.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMaxRetries.Location = new System.Drawing.Point(3, 75);
			this.labelMaxRetries.Name = "labelMaxRetries";
			this.labelMaxRetries.Size = new System.Drawing.Size(63, 75);
			this.labelMaxRetries.TabIndex = 3;
			this.labelMaxRetries.Text = "Max Retries";
			// 
			// textBoxProxy
			// 
			this.textBoxProxy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxProxy.Location = new System.Drawing.Point(72, 26);
			this.textBoxProxy.Name = "textBoxProxy";
			this.textBoxProxy.Size = new System.Drawing.Size(75, 20);
			this.textBoxProxy.TabIndex = 4;
			// 
			// textBoxProberUri
			// 
			this.textBoxProberUri.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxProberUri.Location = new System.Drawing.Point(72, 52);
			this.textBoxProberUri.Name = "textBoxProberUri";
			this.textBoxProberUri.Size = new System.Drawing.Size(75, 20);
			this.textBoxProberUri.TabIndex = 5;
			// 
			// numericUpDownMaxRetries
			// 
			this.numericUpDownMaxRetries.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numericUpDownMaxRetries.Location = new System.Drawing.Point(72, 78);
			this.numericUpDownMaxRetries.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDownMaxRetries.Name = "numericUpDownMaxRetries";
			this.numericUpDownMaxRetries.Size = new System.Drawing.Size(75, 20);
			this.numericUpDownMaxRetries.TabIndex = 6;
			// 
			// KusozakoSettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel);
			this.Name = "KusozakoSettingsControl";
			this.Load += new System.EventHandler(this.KusozakoSettingsControl_Load);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRetries)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.CheckBox checkBoxEnabled;
		private System.Windows.Forms.Label labelProxy;
		private System.Windows.Forms.Label labelProberUri;
		private System.Windows.Forms.Label labelMaxRetries;
		private System.Windows.Forms.TextBox textBoxProxy;
		private System.Windows.Forms.TextBox textBoxProberUri;
		private System.Windows.Forms.NumericUpDown numericUpDownMaxRetries;
	}
}
