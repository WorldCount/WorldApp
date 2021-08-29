namespace DiffPather.Core.Forms.AppsForms
{
    partial class AddAppForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppForm));
            this.labelInfo = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.uncheckAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.reportPanelStat = new System.Windows.Forms.Panel();
            this.btnCancel = new Wc32Api.Widgets.WcButton();
            this.btnAdd = new Wc32Api.Widgets.WcButton();
            this.panelAppInfo = new System.Windows.Forms.Panel();
            this.appLocationTextBox = new Wc32Api.Widgets.WcTextBox();
            this.appLocationInfo = new System.Windows.Forms.Label();
            this.appDescriptionTextBox = new Wc32Api.Widgets.WcTextBox();
            this.appDescriptionInfo = new System.Windows.Forms.Label();
            this.appVersionInfo = new System.Windows.Forms.Label();
            this.appVersionTextBox = new Wc32Api.Widgets.WcTextBox();
            this.appNameTextBox = new Wc32Api.Widgets.WcTextBox();
            this.appNameInfo = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.filesColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filesColumnExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filesColumnHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filesColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toggleBtnRepository = new Wc32Api.Widgets.WcToggleButton();
            this.labelInfoReporitory = new System.Windows.Forms.Label();
            this.contextMenu.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.reportPanelStat.SuspendLayout();
            this.panelAppInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appFileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelInfo.Location = new System.Drawing.Point(23, 12);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(239, 25);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Добавление приложения";
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAllMenuItem,
            this.toolStripSeparator3,
            this.uncheckAllMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(206, 58);
            // 
            // checkAllMenuItem
            // 
            this.checkAllMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkAllMenuItem.Name = "checkAllMenuItem";
            this.checkAllMenuItem.Size = new System.Drawing.Size(205, 24);
            this.checkAllMenuItem.Text = "Отметить все";
            this.checkAllMenuItem.Click += new System.EventHandler(this.checkAllMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(202, 6);
            // 
            // uncheckAllMenuItem
            // 
            this.uncheckAllMenuItem.Name = "uncheckAllMenuItem";
            this.uncheckAllMenuItem.Size = new System.Drawing.Size(205, 24);
            this.uncheckAllMenuItem.Text = "Снять все отметки";
            this.uncheckAllMenuItem.Click += new System.EventHandler(this.uncheckAllMenuItem_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelInfo.Controls.Add(this.labelInfoReporitory);
            this.panelInfo.Controls.Add(this.toggleBtnRepository);
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.ForeColor = System.Drawing.Color.Orange;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(884, 52);
            this.panelInfo.TabIndex = 19;
            // 
            // reportPanelStat
            // 
            this.reportPanelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.reportPanelStat.Controls.Add(this.btnCancel);
            this.reportPanelStat.Controls.Add(this.btnAdd);
            this.reportPanelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportPanelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.reportPanelStat.Location = new System.Drawing.Point(0, 468);
            this.reportPanelStat.Name = "reportPanelStat";
            this.reportPanelStat.Size = new System.Drawing.Size(884, 59);
            this.reportPanelStat.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderRadius = 4F;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnCancel.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::DiffPather.Properties.Resources.close_window_24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(626, 6);
            this.btnCancel.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnCancel.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancel.Size = new System.Drawing.Size(120, 46);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.BorderRadius = 4F;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnAdd.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::DiffPather.Properties.Resources.add_24;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(752, 6);
            this.btnAdd.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnAdd.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAdd.Size = new System.Drawing.Size(120, 46);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelAppInfo
            // 
            this.panelAppInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAppInfo.Controls.Add(this.appLocationTextBox);
            this.panelAppInfo.Controls.Add(this.appLocationInfo);
            this.panelAppInfo.Controls.Add(this.appDescriptionTextBox);
            this.panelAppInfo.Controls.Add(this.appDescriptionInfo);
            this.panelAppInfo.Controls.Add(this.appVersionInfo);
            this.panelAppInfo.Controls.Add(this.appVersionTextBox);
            this.panelAppInfo.Controls.Add(this.appNameTextBox);
            this.panelAppInfo.Controls.Add(this.appNameInfo);
            this.panelAppInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAppInfo.Location = new System.Drawing.Point(0, 52);
            this.panelAppInfo.Name = "panelAppInfo";
            this.panelAppInfo.Size = new System.Drawing.Size(884, 150);
            this.panelAppInfo.TabIndex = 21;
            // 
            // appLocationTextBox
            // 
            this.appLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appLocationTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.appLocationTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appLocationTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appLocationTextBox.BorderSize = 1;
            this.appLocationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.appLocationTextBox.DisableBackColor = System.Drawing.Color.DarkGray;
            this.appLocationTextBox.DisableBorderColor = System.Drawing.Color.DimGray;
            this.appLocationTextBox.DisableForeColor = System.Drawing.Color.DimGray;
            this.appLocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appLocationTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.appLocationTextBox.Location = new System.Drawing.Point(28, 97);
            this.appLocationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.appLocationTextBox.MaxLength = 32767;
            this.appLocationTextBox.Multiline = false;
            this.appLocationTextBox.Name = "appLocationTextBox";
            this.appLocationTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.appLocationTextBox.PasswordChar = '\0';
            this.appLocationTextBox.ReadOnly = true;
            this.appLocationTextBox.Size = new System.Drawing.Size(843, 31);
            this.appLocationTextBox.TabIndex = 0;
            this.appLocationTextBox.TabStop = false;
            this.appLocationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.appLocationTextBox.UnderlinedStyle = false;
            this.appLocationTextBox.UsePasswordChar = false;
            // 
            // appLocationInfo
            // 
            this.appLocationInfo.AutoSize = true;
            this.appLocationInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appLocationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appLocationInfo.Location = new System.Drawing.Point(24, 73);
            this.appLocationInfo.Margin = new System.Windows.Forms.Padding(5, 6, 2, 0);
            this.appLocationInfo.Name = "appLocationInfo";
            this.appLocationInfo.Size = new System.Drawing.Size(118, 20);
            this.appLocationInfo.TabIndex = 0;
            this.appLocationInfo.Text = "Расположение:";
            // 
            // appDescriptionTextBox
            // 
            this.appDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appDescriptionTextBox.BackColor = System.Drawing.Color.White;
            this.appDescriptionTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appDescriptionTextBox.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.appDescriptionTextBox.BorderSize = 1;
            this.appDescriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.appDescriptionTextBox.DisableBackColor = System.Drawing.Color.DarkGray;
            this.appDescriptionTextBox.DisableBorderColor = System.Drawing.Color.DimGray;
            this.appDescriptionTextBox.DisableForeColor = System.Drawing.Color.DimGray;
            this.appDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appDescriptionTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.appDescriptionTextBox.Location = new System.Drawing.Point(453, 33);
            this.appDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.appDescriptionTextBox.MaxLength = 32767;
            this.appDescriptionTextBox.Multiline = false;
            this.appDescriptionTextBox.Name = "appDescriptionTextBox";
            this.appDescriptionTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.appDescriptionTextBox.PasswordChar = '\0';
            this.appDescriptionTextBox.ReadOnly = false;
            this.appDescriptionTextBox.Size = new System.Drawing.Size(418, 31);
            this.appDescriptionTextBox.TabIndex = 2;
            this.appDescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.appDescriptionTextBox.UnderlinedStyle = false;
            this.appDescriptionTextBox.UsePasswordChar = false;
            // 
            // appDescriptionInfo
            // 
            this.appDescriptionInfo.AutoSize = true;
            this.appDescriptionInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appDescriptionInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appDescriptionInfo.Location = new System.Drawing.Point(449, 9);
            this.appDescriptionInfo.Margin = new System.Windows.Forms.Padding(5, 6, 2, 0);
            this.appDescriptionInfo.Name = "appDescriptionInfo";
            this.appDescriptionInfo.Size = new System.Drawing.Size(83, 20);
            this.appDescriptionInfo.TabIndex = 0;
            this.appDescriptionInfo.Text = "Описание:";
            // 
            // appVersionInfo
            // 
            this.appVersionInfo.AutoSize = true;
            this.appVersionInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appVersionInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appVersionInfo.Location = new System.Drawing.Point(298, 9);
            this.appVersionInfo.Margin = new System.Windows.Forms.Padding(5, 6, 2, 0);
            this.appVersionInfo.Name = "appVersionInfo";
            this.appVersionInfo.Size = new System.Drawing.Size(63, 20);
            this.appVersionInfo.TabIndex = 0;
            this.appVersionInfo.Text = "Версия:";
            // 
            // appVersionTextBox
            // 
            this.appVersionTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.appVersionTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appVersionTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appVersionTextBox.BorderSize = 1;
            this.appVersionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.appVersionTextBox.DisableBackColor = System.Drawing.Color.DarkGray;
            this.appVersionTextBox.DisableBorderColor = System.Drawing.Color.DimGray;
            this.appVersionTextBox.DisableForeColor = System.Drawing.Color.DimGray;
            this.appVersionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appVersionTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.appVersionTextBox.Location = new System.Drawing.Point(302, 33);
            this.appVersionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.appVersionTextBox.MaxLength = 32767;
            this.appVersionTextBox.Multiline = false;
            this.appVersionTextBox.Name = "appVersionTextBox";
            this.appVersionTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.appVersionTextBox.PasswordChar = '\0';
            this.appVersionTextBox.ReadOnly = true;
            this.appVersionTextBox.Size = new System.Drawing.Size(127, 31);
            this.appVersionTextBox.TabIndex = 0;
            this.appVersionTextBox.TabStop = false;
            this.appVersionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.appVersionTextBox.UnderlinedStyle = false;
            this.appVersionTextBox.UsePasswordChar = false;
            // 
            // appNameTextBox
            // 
            this.appNameTextBox.BackColor = System.Drawing.Color.White;
            this.appNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appNameTextBox.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.appNameTextBox.BorderSize = 1;
            this.appNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.appNameTextBox.DisableBackColor = System.Drawing.Color.DarkGray;
            this.appNameTextBox.DisableBorderColor = System.Drawing.Color.DimGray;
            this.appNameTextBox.DisableForeColor = System.Drawing.Color.DimGray;
            this.appNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appNameTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.appNameTextBox.Location = new System.Drawing.Point(28, 33);
            this.appNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.appNameTextBox.MaxLength = 32767;
            this.appNameTextBox.Multiline = false;
            this.appNameTextBox.Name = "appNameTextBox";
            this.appNameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.appNameTextBox.PasswordChar = '\0';
            this.appNameTextBox.ReadOnly = false;
            this.appNameTextBox.Size = new System.Drawing.Size(250, 31);
            this.appNameTextBox.TabIndex = 1;
            this.appNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.appNameTextBox.UnderlinedStyle = false;
            this.appNameTextBox.UsePasswordChar = false;
            // 
            // appNameInfo
            // 
            this.appNameInfo.AutoSize = true;
            this.appNameInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appNameInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appNameInfo.Location = new System.Drawing.Point(24, 9);
            this.appNameInfo.Margin = new System.Windows.Forms.Padding(5, 6, 2, 0);
            this.appNameInfo.Name = "appNameInfo";
            this.appNameInfo.Size = new System.Drawing.Size(81, 20);
            this.appNameInfo.TabIndex = 0;
            this.appNameInfo.Text = "Название:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filesColumnName,
            this.filesColumnExtension,
            this.filesColumnHash,
            this.filesColumnLocation});
            this.dataGridView.DataSource = this.appFileBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridView.Location = new System.Drawing.Point(0, 202);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 40;
            this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(884, 266);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.TabStop = false;
            // 
            // filesColumnName
            // 
            this.filesColumnName.DataPropertyName = "Name";
            this.filesColumnName.HeaderText = "Имя";
            this.filesColumnName.Name = "filesColumnName";
            this.filesColumnName.ReadOnly = true;
            // 
            // filesColumnExtension
            // 
            this.filesColumnExtension.DataPropertyName = "Extension";
            this.filesColumnExtension.HeaderText = "Ext";
            this.filesColumnExtension.Name = "filesColumnExtension";
            this.filesColumnExtension.ReadOnly = true;
            // 
            // filesColumnHash
            // 
            this.filesColumnHash.DataPropertyName = "Hash";
            this.filesColumnHash.HeaderText = "Хеш";
            this.filesColumnHash.Name = "filesColumnHash";
            this.filesColumnHash.ReadOnly = true;
            // 
            // filesColumnLocation
            // 
            this.filesColumnLocation.DataPropertyName = "Location";
            this.filesColumnLocation.HeaderText = "Расположение";
            this.filesColumnLocation.Name = "filesColumnLocation";
            this.filesColumnLocation.ReadOnly = true;
            // 
            // appFileBindingSource
            // 
            this.appFileBindingSource.DataSource = typeof(DiffPather.Core.Database.Models.AppFile);
            // 
            // toggleBtnRepository
            // 
            this.toggleBtnRepository.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleBtnRepository.AutoSize = true;
            this.toggleBtnRepository.Checked = true;
            this.toggleBtnRepository.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleBtnRepository.DisableBackColor = System.Drawing.Color.DimGray;
            this.toggleBtnRepository.DisableToggleColor = System.Drawing.Color.Gray;
            this.toggleBtnRepository.Location = new System.Drawing.Point(826, 15);
            this.toggleBtnRepository.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleBtnRepository.Name = "toggleBtnRepository";
            this.toggleBtnRepository.OffBackColor = System.Drawing.Color.Firebrick;
            this.toggleBtnRepository.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleBtnRepository.OnBackColor = System.Drawing.Color.SeaGreen;
            this.toggleBtnRepository.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleBtnRepository.Size = new System.Drawing.Size(45, 22);
            this.toggleBtnRepository.TabIndex = 1;
            this.toggleBtnRepository.UseVisualStyleBackColor = true;
            // 
            // labelInfoReporitory
            // 
            this.labelInfoReporitory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfoReporitory.AutoSize = true;
            this.labelInfoReporitory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoReporitory.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelInfoReporitory.Location = new System.Drawing.Point(702, 16);
            this.labelInfoReporitory.Margin = new System.Windows.Forms.Padding(0, 6, 2, 0);
            this.labelInfoReporitory.Name = "labelInfoReporitory";
            this.labelInfoReporitory.Size = new System.Drawing.Size(119, 20);
            this.labelInfoReporitory.TabIndex = 31;
            this.labelInfoReporitory.Text = "В репозиторий:";
            // 
            // AddAppForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(884, 527);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelAppInfo);
            this.Controls.Add(this.reportPanelStat);
            this.Controls.Add(this.panelInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "AddAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FirmsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddAppForm_Load);
            this.SizeChanged += new System.EventHandler(this.AddAppForm_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddAppForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddAppForm_KeyDown);
            this.contextMenu.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.reportPanelStat.ResumeLayout(false);
            this.panelAppInfo.ResumeLayout(false);
            this.panelAppInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appFileBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem checkAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel reportPanelStat;
        private Wc32Api.Widgets.WcButton btnAdd;
        private Wc32Api.Widgets.WcButton btnCancel;
        private System.Windows.Forms.Panel panelAppInfo;
        private System.Windows.Forms.Label appNameInfo;
        private Wc32Api.Widgets.WcTextBox appNameTextBox;
        private Wc32Api.Widgets.WcTextBox appDescriptionTextBox;
        private System.Windows.Forms.Label appDescriptionInfo;
        private System.Windows.Forms.Label appVersionInfo;
        private Wc32Api.Widgets.WcTextBox appVersionTextBox;
        private Wc32Api.Widgets.WcTextBox appLocationTextBox;
        private System.Windows.Forms.Label appLocationInfo;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource appFileBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesColumnExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesColumnHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesColumnLocation;
        private Wc32Api.Widgets.WcToggleButton toggleBtnRepository;
        private System.Windows.Forms.Label labelInfoReporitory;
    }
}