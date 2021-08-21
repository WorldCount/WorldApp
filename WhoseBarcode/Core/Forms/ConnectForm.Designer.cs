﻿namespace WhoseBarcode.Core.Forms
{
    partial class ConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnGetHost = new Wc32Api.Widgets.WcButton();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTestConnect = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.tbPort = new Wc32Api.Widgets.WcTextBox();
            this.tbPass = new Wc32Api.Widgets.WcTextBox();
            this.tbStatus = new Wc32Api.Widgets.WcTextBox();
            this.tbUser = new Wc32Api.Widgets.WcTextBox();
            this.tbPath = new Wc32Api.Widgets.WcTextBox();
            this.tbHost = new Wc32Api.Widgets.WcTextBox();
            this.btnCheck = new Wc32Api.Widgets.WcButton();
            this.btnCancel = new Wc32Api.Widgets.WcButton();
            this.btnSave = new Wc32Api.Widgets.WcButton();
            this.btnChoose = new Wc32Api.Widgets.WcButton();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbType.ForeColor = System.Drawing.Color.DimGray;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(16, 241);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(255, 27);
            this.cbType.TabIndex = 5;
            // 
            // btnGetHost
            // 
            this.btnGetHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
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
            this.btnGetHost.Location = new System.Drawing.Point(473, 34);
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
            this.lblPass.Location = new System.Drawing.Point(277, 143);
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
            this.lblPort.Location = new System.Drawing.Point(277, 210);
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
            this.lblType.Location = new System.Drawing.Point(12, 209);
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
            this.lblTestConnect.Location = new System.Drawing.Point(12, 278);
            this.lblTestConnect.Name = "lblTestConnect";
            this.lblTestConnect.Size = new System.Drawing.Size(180, 20);
            this.lblTestConnect.TabIndex = 0;
            this.lblTestConnect.Text = "Проверка подключения:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblUser.Location = new System.Drawing.Point(12, 143);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(110, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Пользователь:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPath.ForeColor = System.Drawing.Color.DimGray;
            this.lblPath.Location = new System.Drawing.Point(12, 75);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(78, 20);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Путь к БД:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHost.ForeColor = System.Drawing.Color.DimGray;
            this.lblHost.Location = new System.Drawing.Point(12, 8);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(43, 20);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Хост:";
            // 
            // tbPort
            // 
            this.tbPort.BackColor = System.Drawing.Color.White;
            this.tbPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.tbPort.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.tbPort.BorderSize = 1;
            this.tbPort.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPort.DisableBackColor = System.Drawing.Color.DarkGray;
            this.tbPort.DisableBorderColor = System.Drawing.Color.DimGray;
            this.tbPort.DisableForeColor = System.Drawing.Color.DimGray;
            this.tbPort.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPort.ForeColor = System.Drawing.Color.DimGray;
            this.tbPort.Location = new System.Drawing.Point(281, 236);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbPort.MaxLength = 32767;
            this.tbPort.Multiline = false;
            this.tbPort.Name = "tbPort";
            this.tbPort.Padding = new System.Windows.Forms.Padding(7);
            this.tbPort.PasswordChar = '\0';
            this.tbPort.Size = new System.Drawing.Size(76, 35);
            this.tbPort.TabIndex = 6;
            this.tbPort.Text = "";
            this.tbPort.UnderlinedStyle = false;
            this.tbPort.UsePasswordChar = false;
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPort_KeyPress);
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.White;
            this.tbPass.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbPass.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.tbPass.BorderSize = 1;
            this.tbPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPass.DisableBackColor = System.Drawing.Color.DarkGray;
            this.tbPass.DisableBorderColor = System.Drawing.Color.DimGray;
            this.tbPass.DisableForeColor = System.Drawing.Color.DimGray;
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.ForeColor = System.Drawing.Color.DimGray;
            this.tbPass.Location = new System.Drawing.Point(281, 169);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbPass.MaxLength = 32767;
            this.tbPass.Multiline = false;
            this.tbPass.Name = "tbPass";
            this.tbPass.Padding = new System.Windows.Forms.Padding(7);
            this.tbPass.PasswordChar = '●';
            this.tbPass.ReadOnly = true;
            this.tbPass.Size = new System.Drawing.Size(255, 38);
            this.tbPass.TabIndex = 4;
            this.tbPass.Text = "";
            this.tbPass.UnderlinedStyle = false;
            this.tbPass.UsePasswordChar = false;
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.White;
            this.tbStatus.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbStatus.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.tbStatus.BorderSize = 1;
            this.tbStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbStatus.DisableBackColor = System.Drawing.Color.DarkGray;
            this.tbStatus.DisableBorderColor = System.Drawing.Color.DimGray;
            this.tbStatus.DisableForeColor = System.Drawing.Color.DimGray;
            this.tbStatus.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.tbStatus.Location = new System.Drawing.Point(16, 304);
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
            this.tbStatus.Text = "";
            this.tbStatus.UnderlinedStyle = false;
            this.tbStatus.UsePasswordChar = false;
            this.tbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStatus_KeyPress);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.White;
            this.tbUser.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbUser.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.tbUser.BorderSize = 1;
            this.tbUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUser.DisableBackColor = System.Drawing.Color.DarkGray;
            this.tbUser.DisableBorderColor = System.Drawing.Color.DimGray;
            this.tbUser.DisableForeColor = System.Drawing.Color.DimGray;
            this.tbUser.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser.ForeColor = System.Drawing.Color.DimGray;
            this.tbUser.Location = new System.Drawing.Point(16, 169);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4);
            this.tbUser.MaxLength = 32767;
            this.tbUser.Multiline = false;
            this.tbUser.Name = "tbUser";
            this.tbUser.Padding = new System.Windows.Forms.Padding(7);
            this.tbUser.PasswordChar = '\0';
            this.tbUser.ReadOnly = true;
            this.tbUser.Size = new System.Drawing.Size(255, 38);
            this.tbUser.TabIndex = 3;
            this.tbUser.Text = "";
            this.tbUser.UnderlinedStyle = false;
            this.tbUser.UsePasswordChar = false;
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.BackColor = System.Drawing.Color.White;
            this.tbPath.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbPath.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.tbPath.BorderSize = 1;
            this.tbPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPath.DisableBackColor = System.Drawing.Color.DarkGray;
            this.tbPath.DisableBorderColor = System.Drawing.Color.DimGray;
            this.tbPath.DisableForeColor = System.Drawing.Color.DimGray;
            this.tbPath.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.ForeColor = System.Drawing.Color.DimGray;
            this.tbPath.Location = new System.Drawing.Point(16, 101);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbPath.MaxLength = 32767;
            this.tbPath.Multiline = false;
            this.tbPath.Name = "tbPath";
            this.tbPath.Padding = new System.Windows.Forms.Padding(7);
            this.tbPath.PasswordChar = '\0';
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(451, 38);
            this.tbPath.TabIndex = 2;
            this.tbPath.Text = "";
            this.tbPath.UnderlinedStyle = false;
            this.tbPath.UsePasswordChar = false;
            // 
            // tbHost
            // 
            this.tbHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHost.BackColor = System.Drawing.Color.White;
            this.tbHost.BorderColor = System.Drawing.Color.SeaGreen;
            this.tbHost.BorderFocusColor = System.Drawing.Color.Firebrick;
            this.tbHost.BorderSize = 1;
            this.tbHost.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbHost.DisableBackColor = System.Drawing.Color.DarkGray;
            this.tbHost.DisableBorderColor = System.Drawing.Color.DimGray;
            this.tbHost.DisableForeColor = System.Drawing.Color.DimGray;
            this.tbHost.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHost.ForeColor = System.Drawing.Color.DimGray;
            this.tbHost.Location = new System.Drawing.Point(16, 34);
            this.tbHost.Margin = new System.Windows.Forms.Padding(4);
            this.tbHost.MaxLength = 32767;
            this.tbHost.Multiline = false;
            this.tbHost.Name = "tbHost";
            this.tbHost.Padding = new System.Windows.Forms.Padding(7);
            this.tbHost.PasswordChar = '\0';
            this.tbHost.ReadOnly = false;
            this.tbHost.Size = new System.Drawing.Size(451, 38);
            this.tbHost.TabIndex = 1;
            this.tbHost.Text = "";
            this.tbHost.UnderlinedStyle = false;
            this.tbHost.UsePasswordChar = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.SteelBlue;
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
            this.btnCheck.Image = global::WhoseBarcode.Properties.Resources.sinchronize_24;
            this.btnCheck.Location = new System.Drawing.Point(278, 304);
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
            this.btnCancel.Image = global::WhoseBarcode.Properties.Resources.close_window_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(16, 374);
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
            this.btnSave.Image = global::WhoseBarcode.Properties.Resources.save_24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(412, 374);
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
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
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
            this.btnChoose.Image = global::WhoseBarcode.Properties.Resources.white_folder_24;
            this.btnChoose.Location = new System.Drawing.Point(474, 101);
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
            // ConnectForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(544, 432);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnGetHost);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTestConnect);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbHost);
            this.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditConnectForm";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbType;
        private Wc32Api.Widgets.WcButton btnCheck;
        private Wc32Api.Widgets.WcButton btnCancel;
        private Wc32Api.Widgets.WcButton btnSave;
        private Wc32Api.Widgets.WcButton btnChoose;
        private Wc32Api.Widgets.WcButton btnGetHost;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTestConnect;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblHost;
        private Wc32Api.Widgets.WcTextBox tbPort;
        private Wc32Api.Widgets.WcTextBox tbPass;
        private Wc32Api.Widgets.WcTextBox tbStatus;
        private Wc32Api.Widgets.WcTextBox tbUser;
        private Wc32Api.Widgets.WcTextBox tbPath;
        private Wc32Api.Widgets.WcTextBox tbHost;
    }
}