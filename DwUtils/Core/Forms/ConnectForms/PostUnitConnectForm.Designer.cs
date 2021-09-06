using Wc32Api.Widgets.Buttons;
using Wc32Api.Widgets.Texts;

namespace DwUtils.Core.Forms.ConnectForms
{
    partial class PostUnitConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostUnitConnectForm));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelButtonTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new Wc32Api.Widgets.Buttons.WcButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnCheck = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnCancel = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnSave = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnChoose = new Wc32Api.Widgets.Buttons.WcButton();
            this.btnGetHost = new Wc32Api.Widgets.Buttons.WcButton();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTestConnect = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.tbPort = new Wc32Api.Widgets.Texts.WcTextBox();
            this.tbPass = new Wc32Api.Widgets.Texts.WcTextBox();
            this.tbStatus = new Wc32Api.Widgets.Texts.WcTextBox();
            this.tbUser = new Wc32Api.Widgets.Texts.WcTextBox();
            this.tbPath = new Wc32Api.Widgets.Texts.WcTextBox();
            this.tbHost = new Wc32Api.Widgets.Texts.WcTextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.panelWork = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            this.panelButtonTitle.SuspendLayout();
            this.panelWork.SuspendLayout();
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
            this.panelTitleBar.Size = new System.Drawing.Size(544, 34);
            this.panelTitleBar.TabIndex = 3;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(43, 7);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(222, 18);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "DwUtils: PostUnit Connect";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            // 
            // panelButtonTitle
            // 
            this.panelButtonTitle.Controls.Add(this.btnClose);
            this.panelButtonTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtonTitle.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtonTitle.Location = new System.Drawing.Point(451, 0);
            this.panelButtonTitle.Name = "panelButtonTitle";
            this.panelButtonTitle.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panelButtonTitle.Size = new System.Drawing.Size(93, 34);
            this.panelButtonTitle.TabIndex = 0;
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
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.lblInfo.Location = new System.Drawing.Point(15, 27);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(242, 25);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Подключение к PostUnit";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbType.ForeColor = System.Drawing.Color.DimGray;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(16, 299);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(270, 27);
            this.cbType.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnCheck.BorderColor = System.Drawing.Color.Silver;
            this.btnCheck.BorderRadius = 6F;
            this.btnCheck.BorderSize = 0;
            this.btnCheck.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnCheck.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Image = global::DwUtils.Properties.Resources.synchronize_24;
            this.btnCheck.Location = new System.Drawing.Point(278, 364);
            this.btnCheck.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnCheck.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCheck.Size = new System.Drawing.Size(35, 35);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.TabStop = false;
            this.btnCheck.TextColor = System.Drawing.Color.White;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(16, 409);
            this.btnCancel.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnCancel.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancel.Size = new System.Drawing.Size(120, 46);
            this.btnCancel.TabIndex = 8;
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
            this.btnSave.Location = new System.Drawing.Point(411, 409);
            this.btnSave.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnSave.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSave.Size = new System.Drawing.Size(120, 46);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Принять";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnChoose.BorderColor = System.Drawing.Color.Silver;
            this.btnChoose.BorderRadius = 6F;
            this.btnChoose.BorderSize = 0;
            this.btnChoose.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnChoose.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnChoose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnChoose.FlatAppearance.BorderSize = 0;
            this.btnChoose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Image = global::DwUtils.Properties.Resources.folder_7_24;
            this.btnChoose.Location = new System.Drawing.Point(469, 161);
            this.btnChoose.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnChoose.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnChoose.Size = new System.Drawing.Size(62, 38);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.TabStop = false;
            this.btnChoose.TextColor = System.Drawing.Color.White;
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnGetHost
            // 
            this.btnGetHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.btnGetHost.BorderColor = System.Drawing.Color.Silver;
            this.btnGetHost.BorderRadius = 6F;
            this.btnGetHost.BorderSize = 0;
            this.btnGetHost.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnGetHost.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnGetHost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGetHost.FlatAppearance.BorderSize = 0;
            this.btnGetHost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnGetHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetHost.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetHost.ForeColor = System.Drawing.Color.White;
            this.btnGetHost.Location = new System.Drawing.Point(469, 94);
            this.btnGetHost.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnGetHost.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnGetHost.Name = "btnGetHost";
            this.btnGetHost.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnGetHost.Size = new System.Drawing.Size(63, 38);
            this.btnGetHost.TabIndex = 0;
            this.btnGetHost.TabStop = false;
            this.btnGetHost.Text = "Авто";
            this.btnGetHost.TextColor = System.Drawing.Color.White;
            this.btnGetHost.UseVisualStyleBackColor = false;
            this.btnGetHost.Click += new System.EventHandler(this.btnGetHost_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblPass.Location = new System.Drawing.Point(290, 205);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(65, 20);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Пароль:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPort.ForeColor = System.Drawing.Color.DimGray;
            this.lblPort.Location = new System.Drawing.Point(290, 270);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(47, 20);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Порт:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.ForeColor = System.Drawing.Color.DimGray;
            this.lblType.Location = new System.Drawing.Point(12, 270);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(99, 20);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Тип сервера:";
            // 
            // lblTestConnect
            // 
            this.lblTestConnect.AutoSize = true;
            this.lblTestConnect.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestConnect.ForeColor = System.Drawing.Color.DimGray;
            this.lblTestConnect.Location = new System.Drawing.Point(12, 340);
            this.lblTestConnect.Name = "lblTestConnect";
            this.lblTestConnect.Size = new System.Drawing.Size(180, 20);
            this.lblTestConnect.TabIndex = 39;
            this.lblTestConnect.Text = "Проверка подключения:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblUser.Location = new System.Drawing.Point(12, 205);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(110, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Пользователь:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHost.ForeColor = System.Drawing.Color.DimGray;
            this.lblHost.Location = new System.Drawing.Point(12, 70);
            this.lblHost.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(43, 20);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Хост:";
            // 
            // tbPort
            // 
            this.tbPort.BackColor = System.Drawing.Color.White;
            this.tbPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.tbPort.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.tbPort.BorderSize = 1;
            this.tbPort.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPort.DisableBackColor = System.Drawing.Color.DarkGray;
            this.tbPort.DisableBorderColor = System.Drawing.Color.DimGray;
            this.tbPort.DisableForeColor = System.Drawing.Color.DimGray;
            this.tbPort.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPort.ForeColor = System.Drawing.Color.DimGray;
            this.tbPort.Location = new System.Drawing.Point(294, 294);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbPort.MaxLength = 32767;
            this.tbPort.Multiline = false;
            this.tbPort.Name = "tbPort";
            this.tbPort.Padding = new System.Windows.Forms.Padding(7);
            this.tbPort.PasswordChar = '\0';
            this.tbPort.ReadOnly = false;
            this.tbPort.Size = new System.Drawing.Size(76, 35);
            this.tbPort.TabIndex = 6;
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPort.UnderlinedStyle = false;
            this.tbPort.UsePasswordChar = false;
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPort_KeyPress);
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.White;
            this.tbPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.tbPass.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.tbPass.BorderSize = 1;
            this.tbPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPass.DisableBackColor = System.Drawing.Color.DarkGray;
            this.tbPass.DisableBorderColor = System.Drawing.Color.DimGray;
            this.tbPass.DisableForeColor = System.Drawing.Color.DimGray;
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.ForeColor = System.Drawing.Color.DimGray;
            this.tbPass.Location = new System.Drawing.Point(294, 228);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbPass.MaxLength = 32767;
            this.tbPass.Multiline = false;
            this.tbPass.Name = "tbPass";
            this.tbPass.Padding = new System.Windows.Forms.Padding(7);
            this.tbPass.PasswordChar = '●';
            this.tbPass.ReadOnly = false;
            this.tbPass.Size = new System.Drawing.Size(237, 38);
            this.tbPass.TabIndex = 4;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPass.UnderlinedStyle = false;
            this.tbPass.UsePasswordChar = false;
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.Gainsboro;
            this.tbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.tbStatus.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.tbStatus.BorderSize = 1;
            this.tbStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbStatus.DisableBackColor = System.Drawing.Color.DarkGray;
            this.tbStatus.DisableBorderColor = System.Drawing.Color.DimGray;
            this.tbStatus.DisableForeColor = System.Drawing.Color.DimGray;
            this.tbStatus.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.tbStatus.Location = new System.Drawing.Point(16, 364);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.tbStatus.MaxLength = 32767;
            this.tbStatus.Multiline = false;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Padding = new System.Windows.Forms.Padding(7);
            this.tbStatus.PasswordChar = '\0';
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(255, 35);
            this.tbStatus.TabIndex = 0;
            this.tbStatus.TabStop = false;
            this.tbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStatus.UnderlinedStyle = false;
            this.tbStatus.UsePasswordChar = false;
            this.tbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStatus_KeyPress);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.White;
            this.tbUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.tbUser.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.tbUser.BorderSize = 1;
            this.tbUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUser.DisableBackColor = System.Drawing.Color.DarkGray;
            this.tbUser.DisableBorderColor = System.Drawing.Color.DimGray;
            this.tbUser.DisableForeColor = System.Drawing.Color.DimGray;
            this.tbUser.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser.ForeColor = System.Drawing.Color.DimGray;
            this.tbUser.Location = new System.Drawing.Point(16, 229);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4);
            this.tbUser.MaxLength = 32767;
            this.tbUser.Multiline = false;
            this.tbUser.Name = "tbUser";
            this.tbUser.Padding = new System.Windows.Forms.Padding(7);
            this.tbUser.PasswordChar = '\0';
            this.tbUser.ReadOnly = false;
            this.tbUser.Size = new System.Drawing.Size(270, 38);
            this.tbUser.TabIndex = 3;
            this.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUser.UnderlinedStyle = false;
            this.tbUser.UsePasswordChar = false;
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.BackColor = System.Drawing.Color.White;
            this.tbPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.tbPath.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.tbPath.BorderSize = 1;
            this.tbPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPath.DisableBackColor = System.Drawing.Color.DarkGray;
            this.tbPath.DisableBorderColor = System.Drawing.Color.DimGray;
            this.tbPath.DisableForeColor = System.Drawing.Color.DimGray;
            this.tbPath.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.ForeColor = System.Drawing.Color.DimGray;
            this.tbPath.Location = new System.Drawing.Point(16, 161);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbPath.MaxLength = 32767;
            this.tbPath.Multiline = false;
            this.tbPath.Name = "tbPath";
            this.tbPath.Padding = new System.Windows.Forms.Padding(7);
            this.tbPath.PasswordChar = '\0';
            this.tbPath.ReadOnly = false;
            this.tbPath.Size = new System.Drawing.Size(446, 38);
            this.tbPath.TabIndex = 2;
            this.tbPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPath.UnderlinedStyle = false;
            this.tbPath.UsePasswordChar = false;
            // 
            // tbHost
            // 
            this.tbHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHost.BackColor = System.Drawing.Color.White;
            this.tbHost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
            this.tbHost.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.tbHost.BorderSize = 1;
            this.tbHost.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbHost.DisableBackColor = System.Drawing.Color.DarkGray;
            this.tbHost.DisableBorderColor = System.Drawing.Color.DimGray;
            this.tbHost.DisableForeColor = System.Drawing.Color.DimGray;
            this.tbHost.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHost.ForeColor = System.Drawing.Color.DimGray;
            this.tbHost.Location = new System.Drawing.Point(16, 94);
            this.tbHost.Margin = new System.Windows.Forms.Padding(4);
            this.tbHost.MaxLength = 32767;
            this.tbHost.Multiline = false;
            this.tbHost.Name = "tbHost";
            this.tbHost.Padding = new System.Windows.Forms.Padding(7);
            this.tbHost.PasswordChar = '\0';
            this.tbHost.ReadOnly = false;
            this.tbHost.Size = new System.Drawing.Size(446, 38);
            this.tbHost.TabIndex = 1;
            this.tbHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbHost.UnderlinedStyle = false;
            this.tbHost.UsePasswordChar = false;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPath.ForeColor = System.Drawing.Color.DimGray;
            this.lblPath.Location = new System.Drawing.Point(12, 137);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(78, 20);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Путь к БД:";
            // 
            // panelWork
            // 
            this.panelWork.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelWork.Controls.Add(this.lblInfo);
            this.panelWork.Controls.Add(this.btnCancel);
            this.panelWork.Controls.Add(this.lblPath);
            this.panelWork.Controls.Add(this.btnSave);
            this.panelWork.Controls.Add(this.tbHost);
            this.panelWork.Controls.Add(this.btnChoose);
            this.panelWork.Controls.Add(this.tbPath);
            this.panelWork.Controls.Add(this.btnGetHost);
            this.panelWork.Controls.Add(this.cbType);
            this.panelWork.Controls.Add(this.tbUser);
            this.panelWork.Controls.Add(this.btnCheck);
            this.panelWork.Controls.Add(this.tbStatus);
            this.panelWork.Controls.Add(this.tbPass);
            this.panelWork.Controls.Add(this.tbPort);
            this.panelWork.Controls.Add(this.lblHost);
            this.panelWork.Controls.Add(this.lblUser);
            this.panelWork.Controls.Add(this.lblPass);
            this.panelWork.Controls.Add(this.lblTestConnect);
            this.panelWork.Controls.Add(this.lblPort);
            this.panelWork.Controls.Add(this.lblType);
            this.panelWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWork.Location = new System.Drawing.Point(0, 34);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(544, 467);
            this.panelWork.TabIndex = 40;
            // 
            // PostUnitConnectForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(544, 501);
            this.Controls.Add(this.panelWork);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(560, 540);
            this.Name = "PostUnitConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PostItemConnectForm";
            this.Load += new System.EventHandler(this.form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.Resize += new System.EventHandler(this.form_Resize);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            this.panelButtonTitle.ResumeLayout(false);
            this.panelWork.ResumeLayout(false);
            this.panelWork.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox iconPicture;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel panelButtonTitle;
        private WcButton btnClose;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cbType;
        private WcButton btnCheck;
        private WcButton btnCancel;
        private WcButton btnSave;
        private WcButton btnChoose;
        private WcButton btnGetHost;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTestConnect;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblHost;
        private WcTextBox tbPort;
        private WcTextBox tbPass;
        private WcTextBox tbStatus;
        private WcTextBox tbUser;
        private WcTextBox tbPath;
        private WcTextBox tbHost;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Panel panelWork;
    }
}