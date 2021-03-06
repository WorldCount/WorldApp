using Wc32Api.Widgets.Buttons;
using Wc32Api.Widgets.Texts;

namespace WcDesingApp.Core.Forms
{
    partial class ConfigForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.panelButton = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLk = new System.Windows.Forms.TabPage();
            this.btnCancel = new WcButton();
            this.btnSave = new WcButton();
            this.labelInfoLkApi = new System.Windows.Forms.Label();
            this.lkTbApiUrl = new WcTextBox();
            this.panelButton.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabLk.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnCancel);
            this.panelButton.Controls.Add(this.btnSave);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 415);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(570, 66);
            this.panelButton.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLk);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(60, 6);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(570, 415);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            // 
            // tabLk
            // 
            this.tabLk.Controls.Add(this.lkTbApiUrl);
            this.tabLk.Controls.Add(this.labelInfoLkApi);
            this.tabLk.Location = new System.Drawing.Point(4, 36);
            this.tabLk.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.tabLk.Name = "tabLk";
            this.tabLk.Padding = new System.Windows.Forms.Padding(3);
            this.tabLk.Size = new System.Drawing.Size(562, 375);
            this.tabLk.TabIndex = 0;
            this.tabLk.Text = "Личный кабинет";
            this.tabLk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderRadius = 6F;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnCancel.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(12, 10);
            this.btnCancel.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnCancel.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancel.Size = new System.Drawing.Size(120, 46);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.BorderRadius = 6F;
            this.btnSave.BorderSize = 0;
            this.btnSave.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnSave.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(438, 10);
            this.btnSave.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnSave.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSave.Size = new System.Drawing.Size(120, 46);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Принять";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelInfoLkApi
            // 
            this.labelInfoLkApi.AutoSize = true;
            this.labelInfoLkApi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoLkApi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.labelInfoLkApi.Location = new System.Drawing.Point(11, 20);
            this.labelInfoLkApi.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.labelInfoLkApi.Name = "labelInfoLkApi";
            this.labelInfoLkApi.Size = new System.Drawing.Size(61, 20);
            this.labelInfoLkApi.TabIndex = 0;
            this.labelInfoLkApi.Text = "Api Url:";
            // 
            // lkTbApiUrl
            // 
            this.lkTbApiUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkTbApiUrl.BackColor = System.Drawing.Color.White;
            this.lkTbApiUrl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lkTbApiUrl.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.lkTbApiUrl.BorderSize = 1;
            this.lkTbApiUrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lkTbApiUrl.DisableBackColor = System.Drawing.Color.DarkGray;
            this.lkTbApiUrl.DisableBorderColor = System.Drawing.Color.DimGray;
            this.lkTbApiUrl.DisableForeColor = System.Drawing.Color.DimGray;
            this.lkTbApiUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lkTbApiUrl.ForeColor = System.Drawing.Color.DimGray;
            this.lkTbApiUrl.Location = new System.Drawing.Point(9, 44);
            this.lkTbApiUrl.Margin = new System.Windows.Forms.Padding(4);
            this.lkTbApiUrl.MaxLength = 32767;
            this.lkTbApiUrl.Multiline = false;
            this.lkTbApiUrl.Name = "lkTbApiUrl";
            this.lkTbApiUrl.Padding = new System.Windows.Forms.Padding(7);
            this.lkTbApiUrl.PasswordChar = '\0';
            this.lkTbApiUrl.ReadOnly = false;
            this.lkTbApiUrl.Size = new System.Drawing.Size(544, 36);
            this.lkTbApiUrl.TabIndex = 1;
            this.lkTbApiUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lkTbApiUrl.UnderlinedStyle = false;
            this.lkTbApiUrl.UsePasswordChar = false;
            // 
            // ConfigForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(570, 481);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelButton);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(440, 520);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfigForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfigForm_KeyDown);
            this.panelButton.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabLk.ResumeLayout(false);
            this.tabLk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLk;
        private WcButton btnCancel;
        private WcButton btnSave;
        private System.Windows.Forms.Label labelInfoLkApi;
        private WcTextBox lkTbApiUrl;
    }
}