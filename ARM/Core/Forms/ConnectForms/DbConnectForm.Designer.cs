
using Wc32Api.Widgets.Buttons;

namespace ARM.Core.Forms.ConnectForms
{
    partial class DBConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBConnectForm));
            this.btnCancel = new WcButton();
            this.btnSave = new WcButton();
            this.lblHost = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.btnAuto = new WcButton();
            this.lblPath = new System.Windows.Forms.Label();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lblTestConnect = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btnCheck = new WcButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderRadius = 4;
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
            this.lblPath.Size = new System.Drawing.Size(65, 20);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Имя БД:";
            // 
            // tbDatabase
            // 
            this.tbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDatabase.BackColor = System.Drawing.Color.Gainsboro;
            this.tbDatabase.Enabled = false;
            this.tbDatabase.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDatabase.ForeColor = System.Drawing.Color.DimGray;
            this.tbDatabase.Location = new System.Drawing.Point(16, 101);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.ReadOnly = true;
            this.tbDatabase.Size = new System.Drawing.Size(457, 29);
            this.tbDatabase.TabIndex = 0;
            this.tbDatabase.TabStop = false;
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
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPort.ForeColor = System.Drawing.Color.DimGray;
            this.lblPort.Location = new System.Drawing.Point(12, 213);
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
            this.tbPort.Location = new System.Drawing.Point(14, 238);
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
            this.tbStatus.BackColor = System.Drawing.Color.LightGray;
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
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnCheck.BorderColor = System.Drawing.Color.Silver;
            this.btnCheck.BorderRadius = 4;
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
            // DBConnectForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(544, 411);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.lblTestConnect);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbDatabase);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(560, 450);
            this.Name = "DBConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PartPostConnectForm";
            this.Load += new System.EventHandler(this.DBConnectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WcButton btnCancel;
        private WcButton btnSave;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox tbHost;
        private WcButton btnAuto;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lblTestConnect;
        private System.Windows.Forms.TextBox tbStatus;
        private WcButton btnCheck;
    }
}