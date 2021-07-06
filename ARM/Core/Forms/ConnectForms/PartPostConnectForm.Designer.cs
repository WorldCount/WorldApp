
namespace ARM.Core.Forms.ConnectForms
{
    partial class PartPostConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartPostConnectForm));
            this.btnCancel = new Wc32Api.Widgets.WcButton();
            this.btnSave = new Wc32Api.Widgets.WcButton();
            this.lblHost = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.btnAuto = new Wc32Api.Widgets.WcButton();
            this.lblPath = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnOpen = new Wc32Api.Widgets.WcButton();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lblTestConnect = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btnCheck = new Wc32Api.Widgets.WcButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderRadius = 4;
            this.btnCancel.BorderThickness = 1F;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.BorderRadius = 4;
            this.btnSave.BorderThickness = 1F;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(392, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Принять";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // tbHost
            // 
            this.tbHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHost.BackColor = System.Drawing.Color.White;
            this.tbHost.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHost.ForeColor = System.Drawing.Color.DimGray;
            this.tbHost.Location = new System.Drawing.Point(16, 34);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(451, 29);
            this.tbHost.TabIndex = 1;
            // 
            // btnAuto
            // 
            this.btnAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnAuto.BorderColor = System.Drawing.Color.Silver;
            this.btnAuto.BorderRadius = 4;
            this.btnAuto.BorderThickness = 1F;
            this.btnAuto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuto.ForeColor = System.Drawing.Color.White;
            this.btnAuto.Location = new System.Drawing.Point(473, 30);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(60, 36);
            this.btnAuto.TabIndex = 0;
            this.btnAuto.Text = "Авто";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
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
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.BackColor = System.Drawing.Color.White;
            this.tbPath.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.ForeColor = System.Drawing.Color.DimGray;
            this.tbPath.Location = new System.Drawing.Point(16, 101);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(457, 29);
            this.tbPath.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnOpen.BorderColor = System.Drawing.Color.Silver;
            this.btnOpen.BorderRadius = 4;
            this.btnOpen.BorderThickness = 1F;
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Image = global::ARM.Properties.Resources.white_folder_24;
            this.btnOpen.Location = new System.Drawing.Point(479, 97);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(54, 36);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
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
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblPass.Location = new System.Drawing.Point(275, 143);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(65, 20);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Пароль:";
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.White;
            this.tbUser.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser.ForeColor = System.Drawing.Color.DimGray;
            this.tbUser.Location = new System.Drawing.Point(16, 169);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(253, 29);
            this.tbUser.TabIndex = 3;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.White;
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.ForeColor = System.Drawing.Color.DimGray;
            this.tbPass.Location = new System.Drawing.Point(279, 169);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(253, 29);
            this.tbPass.TabIndex = 4;
            this.tbPass.UseSystemPasswordChar = true;
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
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbType.ForeColor = System.Drawing.Color.DimGray;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(16, 235);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(255, 27);
            this.cbType.TabIndex = 5;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPort.ForeColor = System.Drawing.Color.DimGray;
            this.lblPort.Location = new System.Drawing.Point(275, 210);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(47, 20);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Порт:";
            // 
            // tbPort
            // 
            this.tbPort.BackColor = System.Drawing.Color.White;
            this.tbPort.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPort.ForeColor = System.Drawing.Color.DimGray;
            this.tbPort.Location = new System.Drawing.Point(277, 235);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(76, 27);
            this.tbPort.TabIndex = 6;
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPort_KeyPress);
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
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.White;
            this.tbStatus.Font = new System.Drawing.Font("Consolas", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.tbStatus.Location = new System.Drawing.Point(16, 304);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(255, 27);
            this.tbStatus.TabIndex = 7;
            this.tbStatus.TabStop = false;
            this.tbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStatus_KeyPress);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheck.BorderColor = System.Drawing.Color.Silver;
            this.btnCheck.BorderRadius = 4;
            this.btnCheck.BorderThickness = 1F;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Image = global::ARM.Properties.Resources.white_synchronize_24;
            this.btnCheck.Location = new System.Drawing.Point(277, 299);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(36, 36);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // PartPostConnectForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(544, 411);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.lblTestConnect);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(560, 450);
            this.Name = "PartPostConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PartPostConnectForm";
            this.Load += new System.EventHandler(this.PartPostConnectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wc32Api.Widgets.WcButton btnCancel;
        private Wc32Api.Widgets.WcButton btnSave;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox tbHost;
        private Wc32Api.Widgets.WcButton btnAuto;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox tbPath;
        private Wc32Api.Widgets.WcButton btnOpen;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lblTestConnect;
        private System.Windows.Forms.TextBox tbStatus;
        private Wc32Api.Widgets.WcButton btnCheck;
    }
}