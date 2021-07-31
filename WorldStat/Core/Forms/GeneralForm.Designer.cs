
namespace WorldStat.Core.Forms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFrankReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.panelReceived = new System.Windows.Forms.Panel();
            this.tabStat = new System.Windows.Forms.TabPage();
            this.dataGridViewDocReceive = new System.Windows.Forms.DataGridView();
            this.panelReceivedDoc = new System.Windows.Forms.Panel();
            this.btnReceiveDocLoad = new System.Windows.Forms.Button();
            this.receiveDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.receiveDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.tabOrg = new System.Windows.Forms.TabPage();
            this.dataGridViewDocOrg = new System.Windows.Forms.DataGridView();
            this.panelOrgDoc = new System.Windows.Forms.Panel();
            this.btnOrgDocLoad = new System.Windows.Forms.Button();
            this.orgDateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.orgDateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.dataGridViewUserOnline = new System.Windows.Forms.DataGridView();
            this.adminStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelActive = new System.Windows.Forms.Panel();
            this.btnActiveUserLoad = new System.Windows.Forms.Button();
            this.dateTimePickerReport = new System.Windows.Forms.DateTimePicker();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tabsControl.SuspendLayout();
            this.tabAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.panelReceived.SuspendLayout();
            this.tabStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocReceive)).BeginInit();
            this.panelReceivedDoc.SuspendLayout();
            this.tabOrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocOrg)).BeginInit();
            this.panelOrgDoc.SuspendLayout();
            this.tabChart.SuspendLayout();
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
            this.firmsMenuItem,
            this.connectsMenuItem,
            this.settingsMenuItem,
            this.infosMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(956, 40);
            this.menuBar.TabIndex = 2;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFrankReportMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(57, 36);
            this.fileMenuItem.Text = "Файл";
            // 
            // loadFrankReportMenuItem
            // 
            this.loadFrankReportMenuItem.Name = "loadFrankReportMenuItem";
            this.loadFrankReportMenuItem.Size = new System.Drawing.Size(263, 24);
            this.loadFrankReportMenuItem.Text = "Загрузить отчет по франку";
            this.loadFrankReportMenuItem.Click += new System.EventHandler(this.loadFrankReportMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(263, 24);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // firmsMenuItem
            // 
            this.firmsMenuItem.Name = "firmsMenuItem";
            this.firmsMenuItem.Size = new System.Drawing.Size(115, 36);
            this.firmsMenuItem.Text = "Организации";
            // 
            // connectsMenuItem
            // 
            this.connectsMenuItem.Name = "connectsMenuItem";
            this.connectsMenuItem.Size = new System.Drawing.Size(118, 36);
            this.connectsMenuItem.Text = "Подключения";
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
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelGeneral.Location = new System.Drawing.Point(0, 40);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(956, 58);
            this.panelGeneral.TabIndex = 4;
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.statusBar.Location = new System.Drawing.Point(0, 504);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(956, 22);
            this.statusBar.TabIndex = 5;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(827, 17);
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
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabAll);
            this.tabsControl.Controls.Add(this.tabOrg);
            this.tabsControl.Controls.Add(this.tabStat);
            this.tabsControl.Controls.Add(this.tabChart);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabsControl.Location = new System.Drawing.Point(0, 98);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(956, 406);
            this.tabsControl.TabIndex = 6;
            // 
            // tabAll
            // 
            this.tabAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAll.Controls.Add(this.dataGridViewReport);
            this.tabAll.Controls.Add(this.panelReceived);
            this.tabAll.Location = new System.Drawing.Point(4, 29);
            this.tabAll.Name = "tabAll";
            this.tabAll.Size = new System.Drawing.Size(948, 373);
            this.tabAll.TabIndex = 0;
            this.tabAll.Text = "Общее";
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.AllowUserToDeleteRows = false;
            this.dataGridViewReport.AllowUserToResizeRows = false;
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewReport.ColumnHeadersHeight = 40;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReport.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReport.EnableHeadersVisualStyles = false;
            this.dataGridViewReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewReport.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewReport.RowHeadersVisible = false;
            this.dataGridViewReport.RowHeadersWidth = 40;
            this.dataGridViewReport.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewReport.RowTemplate.Height = 40;
            this.dataGridViewReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewReport.Size = new System.Drawing.Size(948, 325);
            this.dataGridViewReport.TabIndex = 5;
            this.dataGridViewReport.TabStop = false;
            // 
            // panelReceived
            // 
            this.panelReceived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelReceived.Controls.Add(this.dateTimePickerReport);
            this.panelReceived.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReceived.Location = new System.Drawing.Point(0, 0);
            this.panelReceived.Name = "panelReceived";
            this.panelReceived.Size = new System.Drawing.Size(948, 48);
            this.panelReceived.TabIndex = 4;
            // 
            // tabStat
            // 
            this.tabStat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabStat.Controls.Add(this.dataGridViewDocReceive);
            this.tabStat.Controls.Add(this.panelReceivedDoc);
            this.tabStat.Location = new System.Drawing.Point(4, 29);
            this.tabStat.Name = "tabStat";
            this.tabStat.Size = new System.Drawing.Size(739, 287);
            this.tabStat.TabIndex = 2;
            this.tabStat.Text = "Статистика";
            // 
            // dataGridViewDocReceive
            // 
            this.dataGridViewDocReceive.AllowUserToAddRows = false;
            this.dataGridViewDocReceive.AllowUserToDeleteRows = false;
            this.dataGridViewDocReceive.AllowUserToResizeRows = false;
            this.dataGridViewDocReceive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDocReceive.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDocReceive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocReceive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewDocReceive.ColumnHeadersHeight = 40;
            this.dataGridViewDocReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDocReceive.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewDocReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDocReceive.EnableHeadersVisualStyles = false;
            this.dataGridViewDocReceive.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewDocReceive.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewDocReceive.Name = "dataGridViewDocReceive";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocReceive.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewDocReceive.RowHeadersVisible = false;
            this.dataGridViewDocReceive.RowHeadersWidth = 40;
            this.dataGridViewDocReceive.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewDocReceive.RowTemplate.Height = 40;
            this.dataGridViewDocReceive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDocReceive.Size = new System.Drawing.Size(739, 239);
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
            this.panelReceivedDoc.Size = new System.Drawing.Size(739, 48);
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
            this.btnReceiveDocLoad.Location = new System.Drawing.Point(695, 6);
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
            // tabOrg
            // 
            this.tabOrg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabOrg.Controls.Add(this.dataGridViewDocOrg);
            this.tabOrg.Controls.Add(this.panelOrgDoc);
            this.tabOrg.Location = new System.Drawing.Point(4, 29);
            this.tabOrg.Name = "tabOrg";
            this.tabOrg.Size = new System.Drawing.Size(739, 287);
            this.tabOrg.TabIndex = 1;
            this.tabOrg.Text = "Организации";
            // 
            // dataGridViewDocOrg
            // 
            this.dataGridViewDocOrg.AllowUserToAddRows = false;
            this.dataGridViewDocOrg.AllowUserToDeleteRows = false;
            this.dataGridViewDocOrg.AllowUserToResizeRows = false;
            this.dataGridViewDocOrg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDocOrg.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDocOrg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocOrg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewDocOrg.ColumnHeadersHeight = 40;
            this.dataGridViewDocOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDocOrg.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewDocOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDocOrg.EnableHeadersVisualStyles = false;
            this.dataGridViewDocOrg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewDocOrg.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewDocOrg.Name = "dataGridViewDocOrg";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDocOrg.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewDocOrg.RowHeadersVisible = false;
            this.dataGridViewDocOrg.RowHeadersWidth = 40;
            this.dataGridViewDocOrg.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewDocOrg.RowTemplate.Height = 40;
            this.dataGridViewDocOrg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDocOrg.Size = new System.Drawing.Size(739, 239);
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
            this.panelOrgDoc.Size = new System.Drawing.Size(739, 48);
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
            this.btnOrgDocLoad.Location = new System.Drawing.Point(695, 6);
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
            // tabChart
            // 
            this.tabChart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabChart.Controls.Add(this.dataGridViewUserOnline);
            this.tabChart.Controls.Add(this.panelActive);
            this.tabChart.Location = new System.Drawing.Point(4, 29);
            this.tabChart.Name = "tabChart";
            this.tabChart.Size = new System.Drawing.Size(739, 287);
            this.tabChart.TabIndex = 3;
            this.tabChart.Text = "Инфографика";
            // 
            // dataGridViewUserOnline
            // 
            this.dataGridViewUserOnline.AllowUserToAddRows = false;
            this.dataGridViewUserOnline.AllowUserToDeleteRows = false;
            this.dataGridViewUserOnline.AllowUserToResizeRows = false;
            this.dataGridViewUserOnline.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUserOnline.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewUserOnline.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserOnline.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewUserOnline.ColumnHeadersHeight = 40;
            this.dataGridViewUserOnline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUserOnline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminStatusDataGridViewTextBoxColumn});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUserOnline.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewUserOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUserOnline.EnableHeadersVisualStyles = false;
            this.dataGridViewUserOnline.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridViewUserOnline.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewUserOnline.Name = "dataGridViewUserOnline";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserOnline.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewUserOnline.RowHeadersVisible = false;
            this.dataGridViewUserOnline.RowHeadersWidth = 40;
            this.dataGridViewUserOnline.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewUserOnline.RowTemplate.Height = 40;
            this.dataGridViewUserOnline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewUserOnline.Size = new System.Drawing.Size(739, 239);
            this.dataGridViewUserOnline.TabIndex = 1;
            this.dataGridViewUserOnline.TabStop = false;
            // 
            // adminStatusDataGridViewTextBoxColumn
            // 
            this.adminStatusDataGridViewTextBoxColumn.DataPropertyName = "AdminStatus";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.NullValue = "НЕТ";
            this.adminStatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
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
            this.panelActive.Size = new System.Drawing.Size(739, 48);
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
            this.btnActiveUserLoad.Location = new System.Drawing.Point(695, 6);
            this.btnActiveUserLoad.Name = "btnActiveUserLoad";
            this.btnActiveUserLoad.Size = new System.Drawing.Size(36, 36);
            this.btnActiveUserLoad.TabIndex = 20;
            this.btnActiveUserLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActiveUserLoad.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerReport
            // 
            this.dateTimePickerReport.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.dateTimePickerReport.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerReport.CustomFormat = "MMMM.yyyy";
            this.dateTimePickerReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReport.Location = new System.Drawing.Point(8, 11);
            this.dateTimePickerReport.Name = "dateTimePickerReport";
            this.dateTimePickerReport.ShowUpDown = true;
            this.dateTimePickerReport.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerReport.TabIndex = 23;
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(956, 526);
            this.Controls.Add(this.tabsControl);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GeneralForm";
            this.Text = "WorldStat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabsControl.ResumeLayout(false);
            this.tabAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.panelReceived.ResumeLayout(false);
            this.tabStat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocReceive)).EndInit();
            this.panelReceivedDoc.ResumeLayout(false);
            this.tabOrg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocOrg)).EndInit();
            this.panelOrgDoc.ResumeLayout(false);
            this.tabChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserOnline)).EndInit();
            this.panelActive.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFrankReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDbMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosMenuItem;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Panel panelReceived;
        private System.Windows.Forms.TabPage tabStat;
        private System.Windows.Forms.DataGridView dataGridViewDocReceive;
        private System.Windows.Forms.Panel panelReceivedDoc;
        private System.Windows.Forms.Button btnReceiveDocLoad;
        private System.Windows.Forms.DateTimePicker receiveDateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker receiveDateTimePickerStart;
        private System.Windows.Forms.TabPage tabOrg;
        private System.Windows.Forms.DataGridView dataGridViewDocOrg;
        private System.Windows.Forms.Panel panelOrgDoc;
        private System.Windows.Forms.Button btnOrgDocLoad;
        private System.Windows.Forms.DateTimePicker orgDateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker orgDateTimePickerStart;
        private System.Windows.Forms.TabPage tabChart;
        private System.Windows.Forms.DataGridView dataGridViewUserOnline;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelActive;
        private System.Windows.Forms.Button btnActiveUserLoad;
        private System.Windows.Forms.DateTimePicker dateTimePickerReport;
    }
}

