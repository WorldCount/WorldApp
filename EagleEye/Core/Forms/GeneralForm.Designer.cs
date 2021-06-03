
namespace EagleEye.Core.Forms
{
    partial class GeneralForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabPartpost = new System.Windows.Forms.TabPage();
            this.dataGridViewReceive = new System.Windows.Forms.DataGridView();
            this.panelReceived = new System.Windows.Forms.Panel();
            this.tabLK = new System.Windows.Forms.TabPage();
            this.dataGridViewDocReceive = new System.Windows.Forms.DataGridView();
            this.panelReceivedDoc = new System.Windows.Forms.Panel();
            this.btnReceiveDocLoad = new System.Windows.Forms.Button();
            this.receiveDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.receiveDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.tabFrank = new System.Windows.Forms.TabPage();
            this.dataGridViewDocOrg = new System.Windows.Forms.DataGridView();
            this.panelOrgDoc = new System.Windows.Forms.Panel();
            this.btnOrgDocLoad = new System.Windows.Forms.Button();
            this.orgDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.orgDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.tabActiveUsers = new System.Windows.Forms.TabPage();
            this.dataGridViewUserOnline = new System.Windows.Forms.DataGridView();
            this.adminStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelActive = new System.Windows.Forms.Panel();
            this.btnActiveUserLoad = new System.Windows.Forms.Button();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tabsControl.SuspendLayout();
            this.tabPartpost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceive)).BeginInit();
            this.tabLK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocReceive)).BeginInit();
            this.panelReceivedDoc.SuspendLayout();
            this.tabFrank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocOrg)).BeginInit();
            this.panelOrgDoc.SuspendLayout();
            this.tabActiveUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserOnline)).BeginInit();
            this.panelActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.AutoSize = false;
            this.menuBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.connectsMenuItem,
            this.settingsMenuItem,
            this.infosMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(800, 40);
            this.menuBar.TabIndex = 1;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(57, 36);
            this.fileMenuItem.Text = "Файл";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exitMenuItem.Text = "Выход";
            // 
            // connectsMenuItem
            // 
            this.connectsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authMenuItem,
            this.databaseToolStripMenuItem});
            this.connectsMenuItem.Name = "connectsMenuItem";
            this.connectsMenuItem.Size = new System.Drawing.Size(118, 36);
            this.connectsMenuItem.Text = "Подключения";
            // 
            // authMenuItem
            // 
            this.authMenuItem.Name = "authMenuItem";
            this.authMenuItem.Size = new System.Drawing.Size(255, 24);
            this.authMenuItem.Text = "Авторизация на Почта.Ру";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.databaseToolStripMenuItem.Text = "Подключение к БД";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDbMenuItem});
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(96, 36);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // createDbMenuItem
            // 
            this.createDbMenuItem.Name = "createDbMenuItem";
            this.createDbMenuItem.Size = new System.Drawing.Size(205, 24);
            this.createDbMenuItem.Text = "Создать новую БД";
            // 
            // infosMenuItem
            // 
            this.infosMenuItem.Name = "infosMenuItem";
            this.infosMenuItem.Size = new System.Drawing.Size(60, 36);
            this.infosMenuItem.Text = "Инфо";
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(0, 40);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(800, 44);
            this.panelGeneral.TabIndex = 3;
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(671, 17);
            this.statusText.Spring = true;
            // 
            // statusAuthor
            // 
            this.statusAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAuthor.ForeColor = System.Drawing.Color.Gray;
            this.statusAuthor.Name = "statusAuthor";
            this.statusAuthor.Size = new System.Drawing.Size(114, 17);
            this.statusAuthor.Text = "WorldCount, 2021 ©";
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabPartpost);
            this.tabsControl.Controls.Add(this.tabLK);
            this.tabsControl.Controls.Add(this.tabFrank);
            this.tabsControl.Controls.Add(this.tabActiveUsers);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabsControl.Location = new System.Drawing.Point(0, 84);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(800, 344);
            this.tabsControl.TabIndex = 5;
            // 
            // tabPartpost
            // 
            this.tabPartpost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPartpost.Controls.Add(this.dataGridViewReceive);
            this.tabPartpost.Controls.Add(this.panelReceived);
            this.tabPartpost.Location = new System.Drawing.Point(4, 29);
            this.tabPartpost.Name = "tabPartpost";
            this.tabPartpost.Size = new System.Drawing.Size(792, 311);
            this.tabPartpost.TabIndex = 0;
            this.tabPartpost.Text = "Партионная почта";
            // 
            // dataGridViewReceive
            // 
            this.dataGridViewReceive.AllowUserToAddRows = false;
            this.dataGridViewReceive.AllowUserToDeleteRows = false;
            this.dataGridViewReceive.AllowUserToResizeRows = false;
            this.dataGridViewReceive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReceive.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewReceive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReceive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReceive.ColumnHeadersHeight = 40;
            this.dataGridViewReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReceive.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReceive.EnableHeadersVisualStyles = false;
            this.dataGridViewReceive.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewReceive.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewReceive.Name = "dataGridViewReceive";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReceive.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReceive.RowHeadersVisible = false;
            this.dataGridViewReceive.RowHeadersWidth = 40;
            this.dataGridViewReceive.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewReceive.RowTemplate.Height = 40;
            this.dataGridViewReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewReceive.Size = new System.Drawing.Size(792, 263);
            this.dataGridViewReceive.TabIndex = 5;
            this.dataGridViewReceive.TabStop = false;
            // 
            // panelReceived
            // 
            this.panelReceived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelReceived.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceived.Location = new System.Drawing.Point(0, 0);
            this.panelReceived.Name = "panelReceived";
            this.panelReceived.Size = new System.Drawing.Size(792, 48);
            this.panelReceived.TabIndex = 4;
            // 
            // tabLK
            // 
            this.tabLK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabLK.Controls.Add(this.dataGridViewDocReceive);
            this.tabLK.Controls.Add(this.panelReceivedDoc);
            this.tabLK.Location = new System.Drawing.Point(4, 29);
            this.tabLK.Name = "tabLK";
            this.tabLK.Size = new System.Drawing.Size(792, 311);
            this.tabLK.TabIndex = 2;
            this.tabLK.Text = "Личный кабинет";
            // 
            // dataGridViewDocReceive
            // 
            this.dataGridViewDocReceive.AllowUserToAddRows = false;
            this.dataGridViewDocReceive.AllowUserToDeleteRows = false;
            this.dataGridViewDocReceive.AllowUserToResizeRows = false;
            this.dataGridViewDocReceive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDocReceive.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDocReceive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocReceive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDocReceive.ColumnHeadersHeight = 40;
            this.dataGridViewDocReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDocReceive.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDocReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDocReceive.EnableHeadersVisualStyles = false;
            this.dataGridViewDocReceive.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewDocReceive.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewDocReceive.Name = "dataGridViewDocReceive";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocReceive.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDocReceive.RowHeadersVisible = false;
            this.dataGridViewDocReceive.RowHeadersWidth = 40;
            this.dataGridViewDocReceive.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewDocReceive.RowTemplate.Height = 40;
            this.dataGridViewDocReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDocReceive.Size = new System.Drawing.Size(792, 263);
            this.dataGridViewDocReceive.TabIndex = 6;
            this.dataGridViewDocReceive.TabStop = false;
            // 
            // panelReceivedDoc
            // 
            this.panelReceivedDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelReceivedDoc.Controls.Add(this.btnReceiveDocLoad);
            this.panelReceivedDoc.Controls.Add(this.receiveDateTimePickerEnd);
            this.panelReceivedDoc.Controls.Add(this.receiveDateTimePickerStart);
            this.panelReceivedDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceivedDoc.Location = new System.Drawing.Point(0, 0);
            this.panelReceivedDoc.Name = "panelReceivedDoc";
            this.panelReceivedDoc.Size = new System.Drawing.Size(792, 48);
            this.panelReceivedDoc.TabIndex = 3;
            // 
            // btnReceiveDocLoad
            // 
            this.btnReceiveDocLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceiveDocLoad.BackColor = System.Drawing.Color.Brown;
            this.btnReceiveDocLoad.FlatAppearance.BorderSize = 0;
            this.btnReceiveDocLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnReceiveDocLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveDocLoad.ForeColor = System.Drawing.Color.White;
            this.btnReceiveDocLoad.Location = new System.Drawing.Point(748, 6);
            this.btnReceiveDocLoad.Name = "btnReceiveDocLoad";
            this.btnReceiveDocLoad.Size = new System.Drawing.Size(36, 36);
            this.btnReceiveDocLoad.TabIndex = 21;
            this.btnReceiveDocLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceiveDocLoad.UseVisualStyleBackColor = false;
            // 
            // receiveDateTimePickerEnd
            // 
            this.receiveDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.receiveDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.White;
            this.receiveDateTimePickerEnd.Location = new System.Drawing.Point(219, 11);
            this.receiveDateTimePickerEnd.Name = "receiveDateTimePickerEnd";
            this.receiveDateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.receiveDateTimePickerEnd.TabIndex = 4;
            // 
            // receiveDateTimePickerStart
            // 
            this.receiveDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.receiveDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.White;
            this.receiveDateTimePickerStart.Location = new System.Drawing.Point(13, 11);
            this.receiveDateTimePickerStart.Name = "receiveDateTimePickerStart";
            this.receiveDateTimePickerStart.Size = new System.Drawing.Size(200, 27);
            this.receiveDateTimePickerStart.TabIndex = 3;
            // 
            // tabFrank
            // 
            this.tabFrank.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabFrank.Controls.Add(this.dataGridViewDocOrg);
            this.tabFrank.Controls.Add(this.panelOrgDoc);
            this.tabFrank.Location = new System.Drawing.Point(4, 29);
            this.tabFrank.Name = "tabFrank";
            this.tabFrank.Size = new System.Drawing.Size(792, 311);
            this.tabFrank.TabIndex = 1;
            this.tabFrank.Text = "Франкировка";
            // 
            // dataGridViewDocOrg
            // 
            this.dataGridViewDocOrg.AllowUserToAddRows = false;
            this.dataGridViewDocOrg.AllowUserToDeleteRows = false;
            this.dataGridViewDocOrg.AllowUserToResizeRows = false;
            this.dataGridViewDocOrg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDocOrg.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDocOrg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocOrg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewDocOrg.ColumnHeadersHeight = 40;
            this.dataGridViewDocOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDocOrg.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDocOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDocOrg.EnableHeadersVisualStyles = false;
            this.dataGridViewDocOrg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewDocOrg.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewDocOrg.Name = "dataGridViewDocOrg";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocOrg.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewDocOrg.RowHeadersVisible = false;
            this.dataGridViewDocOrg.RowHeadersWidth = 40;
            this.dataGridViewDocOrg.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewDocOrg.RowTemplate.Height = 40;
            this.dataGridViewDocOrg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDocOrg.Size = new System.Drawing.Size(792, 263);
            this.dataGridViewDocOrg.TabIndex = 7;
            this.dataGridViewDocOrg.TabStop = false;
            // 
            // panelOrgDoc
            // 
            this.panelOrgDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelOrgDoc.Controls.Add(this.btnOrgDocLoad);
            this.panelOrgDoc.Controls.Add(this.orgDateTimePickerEnd);
            this.panelOrgDoc.Controls.Add(this.orgDateTimePickerStart);
            this.panelOrgDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrgDoc.Location = new System.Drawing.Point(0, 0);
            this.panelOrgDoc.Name = "panelOrgDoc";
            this.panelOrgDoc.Size = new System.Drawing.Size(792, 48);
            this.panelOrgDoc.TabIndex = 3;
            // 
            // btnOrgDocLoad
            // 
            this.btnOrgDocLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrgDocLoad.BackColor = System.Drawing.Color.Brown;
            this.btnOrgDocLoad.FlatAppearance.BorderSize = 0;
            this.btnOrgDocLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnOrgDocLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrgDocLoad.ForeColor = System.Drawing.Color.White;
            this.btnOrgDocLoad.Location = new System.Drawing.Point(748, 6);
            this.btnOrgDocLoad.Name = "btnOrgDocLoad";
            this.btnOrgDocLoad.Size = new System.Drawing.Size(36, 36);
            this.btnOrgDocLoad.TabIndex = 24;
            this.btnOrgDocLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrgDocLoad.UseVisualStyleBackColor = false;
            // 
            // orgDateTimePickerEnd
            // 
            this.orgDateTimePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgDateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.White;
            this.orgDateTimePickerEnd.Location = new System.Drawing.Point(219, 11);
            this.orgDateTimePickerEnd.Name = "orgDateTimePickerEnd";
            this.orgDateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.orgDateTimePickerEnd.TabIndex = 23;
            // 
            // orgDateTimePickerStart
            // 
            this.orgDateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.orgDateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.White;
            this.orgDateTimePickerStart.Location = new System.Drawing.Point(13, 11);
            this.orgDateTimePickerStart.Name = "orgDateTimePickerStart";
            this.orgDateTimePickerStart.Size = new System.Drawing.Size(200, 27);
            this.orgDateTimePickerStart.TabIndex = 22;
            // 
            // tabActiveUsers
            // 
            this.tabActiveUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabActiveUsers.Controls.Add(this.dataGridViewUserOnline);
            this.tabActiveUsers.Controls.Add(this.panelActive);
            this.tabActiveUsers.Location = new System.Drawing.Point(4, 29);
            this.tabActiveUsers.Name = "tabActiveUsers";
            this.tabActiveUsers.Size = new System.Drawing.Size(792, 311);
            this.tabActiveUsers.TabIndex = 3;
            this.tabActiveUsers.Text = "Подключенные пользователи";
            // 
            // dataGridViewUserOnline
            // 
            this.dataGridViewUserOnline.AllowUserToAddRows = false;
            this.dataGridViewUserOnline.AllowUserToDeleteRows = false;
            this.dataGridViewUserOnline.AllowUserToResizeRows = false;
            this.dataGridViewUserOnline.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUserOnline.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewUserOnline.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserOnline.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewUserOnline.ColumnHeadersHeight = 40;
            this.dataGridViewUserOnline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUserOnline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminStatusDataGridViewTextBoxColumn});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUserOnline.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewUserOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUserOnline.EnableHeadersVisualStyles = false;
            this.dataGridViewUserOnline.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewUserOnline.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewUserOnline.Name = "dataGridViewUserOnline";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserOnline.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewUserOnline.RowHeadersVisible = false;
            this.dataGridViewUserOnline.RowHeadersWidth = 40;
            this.dataGridViewUserOnline.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewUserOnline.RowTemplate.Height = 40;
            this.dataGridViewUserOnline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewUserOnline.Size = new System.Drawing.Size(792, 263);
            this.dataGridViewUserOnline.TabIndex = 1;
            this.dataGridViewUserOnline.TabStop = false;
            // 
            // adminStatusDataGridViewTextBoxColumn
            // 
            this.adminStatusDataGridViewTextBoxColumn.DataPropertyName = "AdminStatus";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = "НЕТ";
            this.adminStatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.adminStatusDataGridViewTextBoxColumn.HeaderText = "  Админ";
            this.adminStatusDataGridViewTextBoxColumn.Name = "adminStatusDataGridViewTextBoxColumn";
            this.adminStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panelActive
            // 
            this.panelActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelActive.Controls.Add(this.btnActiveUserLoad);
            this.panelActive.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActive.Location = new System.Drawing.Point(0, 0);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(792, 48);
            this.panelActive.TabIndex = 2;
            // 
            // btnActiveUserLoad
            // 
            this.btnActiveUserLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActiveUserLoad.BackColor = System.Drawing.Color.Brown;
            this.btnActiveUserLoad.FlatAppearance.BorderSize = 0;
            this.btnActiveUserLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnActiveUserLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiveUserLoad.ForeColor = System.Drawing.Color.White;
            this.btnActiveUserLoad.Location = new System.Drawing.Point(748, 6);
            this.btnActiveUserLoad.Name = "btnActiveUserLoad";
            this.btnActiveUserLoad.Size = new System.Drawing.Size(36, 36);
            this.btnActiveUserLoad.TabIndex = 20;
            this.btnActiveUserLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActiveUserLoad.UseVisualStyleBackColor = false;
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabsControl);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GeneralForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabsControl.ResumeLayout(false);
            this.tabPartpost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceive)).EndInit();
            this.tabLK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocReceive)).EndInit();
            this.panelReceivedDoc.ResumeLayout(false);
            this.tabFrank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocOrg)).EndInit();
            this.panelOrgDoc.ResumeLayout(false);
            this.tabActiveUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserOnline)).EndInit();
            this.panelActive.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDbMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosMenuItem;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabPartpost;
        private System.Windows.Forms.DataGridView dataGridViewReceive;
        private System.Windows.Forms.Panel panelReceived;
        private System.Windows.Forms.TabPage tabLK;
        private System.Windows.Forms.DataGridView dataGridViewDocReceive;
        private System.Windows.Forms.Panel panelReceivedDoc;
        private System.Windows.Forms.Button btnReceiveDocLoad;
        private System.Windows.Forms.DateTimePicker receiveDateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker receiveDateTimePickerStart;
        private System.Windows.Forms.TabPage tabFrank;
        private System.Windows.Forms.DataGridView dataGridViewDocOrg;
        private System.Windows.Forms.Panel panelOrgDoc;
        private System.Windows.Forms.Button btnOrgDocLoad;
        private System.Windows.Forms.DateTimePicker orgDateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker orgDateTimePickerStart;
        private System.Windows.Forms.TabPage tabActiveUsers;
        private System.Windows.Forms.DataGridView dataGridViewUserOnline;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelActive;
        private System.Windows.Forms.Button btnActiveUserLoad;
    }
}

