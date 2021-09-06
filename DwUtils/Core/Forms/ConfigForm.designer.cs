using Wc32Api.Widgets.Buttons;
using Wc32Api.Widgets.Texts;

namespace DwUtils.Core.Forms
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelButtonTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.panelWork = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLk = new System.Windows.Forms.TabPage();
            this.lkTbApiUrl = new Wc32Api.Widgets.Texts.WcTextBox();
            this.labelInfoLkApi = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnCancel = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnSave = new Wc32Api.Widgets.Buttons.WcButton();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.btnClose = new Wc32Api.Widgets.Buttons.WcButton();
            this.panelTitleBar.SuspendLayout();
            this.panelButtonTitle.SuspendLayout();
            this.panelWork.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabLk.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelTitleBar.Controls.Add(this.iconPicture);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.panelButtonTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(570, 34);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(43, 7);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(141, 18);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "DwUtils: Configs";
            // 
            // panelButtonTitle
            // 
            this.panelButtonTitle.Controls.Add(this.btnClose);
            this.panelButtonTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtonTitle.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtonTitle.Location = new System.Drawing.Point(477, 0);
            this.panelButtonTitle.Name = "panelButtonTitle";
            this.panelButtonTitle.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panelButtonTitle.Size = new System.Drawing.Size(93, 34);
            this.panelButtonTitle.TabIndex = 0;
            // 
            // panelWork
            // 
            this.panelWork.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelWork.Controls.Add(this.tabControl);
            this.panelWork.Controls.Add(this.panelButton);
            this.panelWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWork.Location = new System.Drawing.Point(0, 34);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(570, 447);
            this.panelWork.TabIndex = 3;
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
            this.tabControl.Size = new System.Drawing.Size(570, 381);
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
            this.tabLk.Size = new System.Drawing.Size(562, 341);
            this.tabLk.TabIndex = 0;
            this.tabLk.Text = "Личный кабинет";
            this.tabLk.UseVisualStyleBackColor = true;
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
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnCancel);
            this.panelButton.Controls.Add(this.btnSave);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 381);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(570, 66);
            this.panelButton.TabIndex = 2;
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
            this.btnCancel.Image = global::DwUtils.Properties.Resources.close_window_24;
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
            this.btnSave.Image = global::DwUtils.Properties.Resources.save_24;
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
            // iconPicture
            // 
            this.iconPicture.Image = global::DwUtils.Properties.Resources.web_hi_res_512;
            this.iconPicture.Location = new System.Drawing.Point(6, 2);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(28, 28);
            this.iconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPicture.TabIndex = 3;
            this.iconPicture.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.BorderRadius = 3F;
            this.btnClose.BorderSize = 0;
            this.btnClose.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnClose.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::DwUtils.Properties.Resources.x_mark_16;
            this.btnClose.Location = new System.Drawing.Point(62, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.btnClose.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnClose.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(570, 481);
            this.Controls.Add(this.panelWork);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(440, 520);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfigForm";
            this.Load += new System.EventHandler(this.form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.Resize += new System.EventHandler(this.form_Resize);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelButtonTitle.ResumeLayout(false);
            this.panelWork.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabLk.ResumeLayout(false);
            this.tabLk.PerformLayout();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox iconPicture;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel panelButtonTitle;
        private WcButton btnClose;
        private System.Windows.Forms.Panel panelWork;
        private System.Windows.Forms.Panel panelButton;
        private WcButton btnCancel;
        private WcButton btnSave;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLk;
        private WcTextBox lkTbApiUrl;
        private System.Windows.Forms.Label labelInfoLkApi;
    }
}