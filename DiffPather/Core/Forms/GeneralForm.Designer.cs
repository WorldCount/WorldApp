
namespace DiffPather.Core.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.flowLayoutPanelButton = new System.Windows.Forms.FlowLayoutPanel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabApps = new System.Windows.Forms.TabPage();
            this.appsDataGridView = new System.Windows.Forms.DataGridView();
            this.appsPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelApps = new System.Windows.Forms.FlowLayoutPanel();
            this.barcodePanelStat = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBarcodeStat = new System.Windows.Forms.FlowLayoutPanel();
            this.appsLabelInfoCount = new System.Windows.Forms.Label();
            this.appsLabelCount = new System.Windows.Forms.Label();
            this.tabFiles = new System.Windows.Forms.TabPage();
            this.rangeDataGridView = new System.Windows.Forms.DataGridView();
            this.rangeColumnExternal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnFirstNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnLastNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnFreeCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnBusyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangePanel = new System.Windows.Forms.Panel();
            this.panelRangeStat = new System.Windows.Forms.Panel();
            this.flowLayoutPanelRangeStat = new System.Windows.Forms.FlowLayoutPanel();
            this.rangeLabelInfoRangeCount = new System.Windows.Forms.Label();
            this.rangeLabelRangeCount = new System.Windows.Forms.Label();
            this.btnUpdateApps = new Wc32Api.Widgets.WcButton();
            this.btnAdd = new Wc32Api.Widgets.WcButton();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appsColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appsColumnCurrentVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appsColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appsColumnDirectoryLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.appsRemoveContexMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appsEditContexMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.flowLayoutPanelButton.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabApps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appsDataGridView)).BeginInit();
            this.appsPanel.SuspendLayout();
            this.barcodePanelStat.SuspendLayout();
            this.flowLayoutPanelBarcodeStat.SuspendLayout();
            this.tabFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangeDataGridView)).BeginInit();
            this.panelRangeStat.SuspendLayout();
            this.flowLayoutPanelRangeStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appInfoBindingSource)).BeginInit();
            this.appsContextMenu.SuspendLayout();
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
            this.settingsMenuItem,
            this.infosMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(800, 40);
            this.menuBar.TabIndex = 3;
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelGeneral.Controls.Add(this.flowLayoutPanelButton);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelGeneral.Location = new System.Drawing.Point(0, 40);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(800, 58);
            this.panelGeneral.TabIndex = 5;
            // 
            // flowLayoutPanelButton
            // 
            this.flowLayoutPanelButton.Controls.Add(this.btnAdd);
            this.flowLayoutPanelButton.Location = new System.Drawing.Point(12, 3);
            this.flowLayoutPanelButton.Name = "flowLayoutPanelButton";
            this.flowLayoutPanelButton.Size = new System.Drawing.Size(578, 52);
            this.flowLayoutPanelButton.TabIndex = 0;
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.statusAuthor});
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 6;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // timerStatus
            // 
            this.timerStatus.Interval = 3000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabApps);
            this.tabControl.Controls.Add(this.tabFiles);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 98);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(60, 6);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 330);
            this.tabControl.TabIndex = 9;
            // 
            // tabApps
            // 
            this.tabApps.Controls.Add(this.appsDataGridView);
            this.tabApps.Controls.Add(this.appsPanel);
            this.tabApps.Controls.Add(this.barcodePanelStat);
            this.tabApps.Location = new System.Drawing.Point(4, 36);
            this.tabApps.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.tabApps.Name = "tabApps";
            this.tabApps.Padding = new System.Windows.Forms.Padding(3);
            this.tabApps.Size = new System.Drawing.Size(792, 290);
            this.tabApps.TabIndex = 0;
            this.tabApps.Text = "Приложения";
            this.tabApps.UseVisualStyleBackColor = true;
            // 
            // appsDataGridView
            // 
            this.appsDataGridView.AllowUserToAddRows = false;
            this.appsDataGridView.AllowUserToDeleteRows = false;
            this.appsDataGridView.AllowUserToResizeColumns = false;
            this.appsDataGridView.AllowUserToResizeRows = false;
            this.appsDataGridView.AutoGenerateColumns = false;
            this.appsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appsDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.appsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.appsDataGridView.ColumnHeadersHeight = 40;
            this.appsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.appsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appsColumnName,
            this.appsColumnCurrentVersion,
            this.appsColumnDescription,
            this.appsColumnDirectoryLocation});
            this.appsDataGridView.DataSource = this.appInfoBindingSource;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.appsDataGridView.DefaultCellStyle = dataGridViewCellStyle20;
            this.appsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appsDataGridView.EnableHeadersVisualStyles = false;
            this.appsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.appsDataGridView.Location = new System.Drawing.Point(3, 51);
            this.appsDataGridView.Name = "appsDataGridView";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.appsDataGridView.RowHeadersVisible = false;
            this.appsDataGridView.RowHeadersWidth = 40;
            this.appsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.appsDataGridView.RowTemplate.Height = 40;
            this.appsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.appsDataGridView.Size = new System.Drawing.Size(786, 206);
            this.appsDataGridView.TabIndex = 6;
            this.appsDataGridView.TabStop = false;
            this.appsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.appsDataGridView_CellEndEdit);
            this.appsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.appsDataGridView_MouseClick);
            // 
            // appsPanel
            // 
            this.appsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appsPanel.Controls.Add(this.btnUpdateApps);
            this.appsPanel.Controls.Add(this.flowLayoutPanelApps);
            this.appsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.appsPanel.Location = new System.Drawing.Point(3, 3);
            this.appsPanel.Name = "appsPanel";
            this.appsPanel.Size = new System.Drawing.Size(786, 48);
            this.appsPanel.TabIndex = 5;
            // 
            // flowLayoutPanelApps
            // 
            this.flowLayoutPanelApps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelApps.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanelApps.Name = "flowLayoutPanelApps";
            this.flowLayoutPanelApps.Size = new System.Drawing.Size(729, 40);
            this.flowLayoutPanelApps.TabIndex = 27;
            this.flowLayoutPanelApps.WrapContents = false;
            // 
            // barcodePanelStat
            // 
            this.barcodePanelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.barcodePanelStat.Controls.Add(this.flowLayoutPanelBarcodeStat);
            this.barcodePanelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barcodePanelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.barcodePanelStat.Location = new System.Drawing.Point(3, 257);
            this.barcodePanelStat.Name = "barcodePanelStat";
            this.barcodePanelStat.Size = new System.Drawing.Size(786, 30);
            this.barcodePanelStat.TabIndex = 7;
            // 
            // flowLayoutPanelBarcodeStat
            // 
            this.flowLayoutPanelBarcodeStat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelBarcodeStat.Controls.Add(this.appsLabelInfoCount);
            this.flowLayoutPanelBarcodeStat.Controls.Add(this.appsLabelCount);
            this.flowLayoutPanelBarcodeStat.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanelBarcodeStat.Name = "flowLayoutPanelBarcodeStat";
            this.flowLayoutPanelBarcodeStat.Size = new System.Drawing.Size(783, 26);
            this.flowLayoutPanelBarcodeStat.TabIndex = 1;
            this.flowLayoutPanelBarcodeStat.WrapContents = false;
            // 
            // appsLabelInfoCount
            // 
            this.appsLabelInfoCount.AutoSize = true;
            this.appsLabelInfoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appsLabelInfoCount.Location = new System.Drawing.Point(8, 2);
            this.appsLabelInfoCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.appsLabelInfoCount.Name = "appsLabelInfoCount";
            this.appsLabelInfoCount.Size = new System.Drawing.Size(52, 20);
            this.appsLabelInfoCount.TabIndex = 0;
            this.appsLabelInfoCount.Text = "Всего:";
            // 
            // appsLabelCount
            // 
            this.appsLabelCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appsLabelCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.appsLabelCount.Location = new System.Drawing.Point(66, 2);
            this.appsLabelCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.appsLabelCount.Name = "appsLabelCount";
            this.appsLabelCount.Size = new System.Drawing.Size(90, 22);
            this.appsLabelCount.TabIndex = 0;
            this.appsLabelCount.Text = "0";
            // 
            // tabFiles
            // 
            this.tabFiles.Controls.Add(this.rangeDataGridView);
            this.tabFiles.Controls.Add(this.rangePanel);
            this.tabFiles.Controls.Add(this.panelRangeStat);
            this.tabFiles.Location = new System.Drawing.Point(4, 36);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiles.Size = new System.Drawing.Size(792, 290);
            this.tabFiles.TabIndex = 1;
            this.tabFiles.Text = "Файлы";
            this.tabFiles.UseVisualStyleBackColor = true;
            // 
            // rangeDataGridView
            // 
            this.rangeDataGridView.AllowUserToAddRows = false;
            this.rangeDataGridView.AllowUserToDeleteRows = false;
            this.rangeDataGridView.AllowUserToResizeColumns = false;
            this.rangeDataGridView.AllowUserToResizeRows = false;
            this.rangeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rangeDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.rangeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rangeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.rangeDataGridView.ColumnHeadersHeight = 40;
            this.rangeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rangeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rangeColumnExternal,
            this.rangeColumnFirstNum,
            this.rangeColumnLastNum,
            this.rangeColumnFreeCount,
            this.rangeColumnBusyCount});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rangeDataGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.rangeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangeDataGridView.EnableHeadersVisualStyles = false;
            this.rangeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rangeDataGridView.Location = new System.Drawing.Point(3, 49);
            this.rangeDataGridView.Name = "rangeDataGridView";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rangeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.rangeDataGridView.RowHeadersVisible = false;
            this.rangeDataGridView.RowHeadersWidth = 40;
            this.rangeDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rangeDataGridView.RowTemplate.Height = 40;
            this.rangeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.rangeDataGridView.Size = new System.Drawing.Size(786, 208);
            this.rangeDataGridView.TabIndex = 7;
            this.rangeDataGridView.TabStop = false;
            // 
            // rangeColumnExternal
            // 
            this.rangeColumnExternal.DataPropertyName = "ExtName";
            this.rangeColumnExternal.HeaderText = "Тип";
            this.rangeColumnExternal.Name = "rangeColumnExternal";
            this.rangeColumnExternal.ReadOnly = true;
            // 
            // rangeColumnFirstNum
            // 
            this.rangeColumnFirstNum.DataPropertyName = "FirstNum";
            this.rangeColumnFirstNum.HeaderText = "  Нач.";
            this.rangeColumnFirstNum.Name = "rangeColumnFirstNum";
            this.rangeColumnFirstNum.ReadOnly = true;
            // 
            // rangeColumnLastNum
            // 
            this.rangeColumnLastNum.DataPropertyName = "LastNum";
            this.rangeColumnLastNum.HeaderText = "  Кон.";
            this.rangeColumnLastNum.Name = "rangeColumnLastNum";
            this.rangeColumnLastNum.ReadOnly = true;
            // 
            // rangeColumnFreeCount
            // 
            this.rangeColumnFreeCount.DataPropertyName = "FreeCountName";
            this.rangeColumnFreeCount.HeaderText = "  Своб.";
            this.rangeColumnFreeCount.Name = "rangeColumnFreeCount";
            this.rangeColumnFreeCount.ReadOnly = true;
            // 
            // rangeColumnBusyCount
            // 
            this.rangeColumnBusyCount.DataPropertyName = "BusyCountName";
            this.rangeColumnBusyCount.HeaderText = "  Зан.";
            this.rangeColumnBusyCount.Name = "rangeColumnBusyCount";
            this.rangeColumnBusyCount.ReadOnly = true;
            // 
            // rangePanel
            // 
            this.rangePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.rangePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rangePanel.Location = new System.Drawing.Point(3, 3);
            this.rangePanel.Name = "rangePanel";
            this.rangePanel.Size = new System.Drawing.Size(786, 46);
            this.rangePanel.TabIndex = 6;
            // 
            // panelRangeStat
            // 
            this.panelRangeStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelRangeStat.Controls.Add(this.flowLayoutPanelRangeStat);
            this.panelRangeStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRangeStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelRangeStat.Location = new System.Drawing.Point(3, 257);
            this.panelRangeStat.Name = "panelRangeStat";
            this.panelRangeStat.Size = new System.Drawing.Size(786, 30);
            this.panelRangeStat.TabIndex = 8;
            // 
            // flowLayoutPanelRangeStat
            // 
            this.flowLayoutPanelRangeStat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelRangeStat.Controls.Add(this.rangeLabelInfoRangeCount);
            this.flowLayoutPanelRangeStat.Controls.Add(this.rangeLabelRangeCount);
            this.flowLayoutPanelRangeStat.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanelRangeStat.Name = "flowLayoutPanelRangeStat";
            this.flowLayoutPanelRangeStat.Size = new System.Drawing.Size(783, 26);
            this.flowLayoutPanelRangeStat.TabIndex = 1;
            this.flowLayoutPanelRangeStat.WrapContents = false;
            // 
            // rangeLabelInfoRangeCount
            // 
            this.rangeLabelInfoRangeCount.AutoSize = true;
            this.rangeLabelInfoRangeCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelInfoRangeCount.Location = new System.Drawing.Point(8, 2);
            this.rangeLabelInfoRangeCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.rangeLabelInfoRangeCount.Name = "rangeLabelInfoRangeCount";
            this.rangeLabelInfoRangeCount.Size = new System.Drawing.Size(100, 20);
            this.rangeLabelInfoRangeCount.TabIndex = 0;
            this.rangeLabelInfoRangeCount.Text = "Диапазонов:";
            // 
            // rangeLabelRangeCount
            // 
            this.rangeLabelRangeCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelRangeCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.rangeLabelRangeCount.Location = new System.Drawing.Point(114, 2);
            this.rangeLabelRangeCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.rangeLabelRangeCount.Name = "rangeLabelRangeCount";
            this.rangeLabelRangeCount.Size = new System.Drawing.Size(90, 22);
            this.rangeLabelRangeCount.TabIndex = 0;
            this.rangeLabelRangeCount.Text = "0";
            // 
            // btnUpdateApps
            // 
            this.btnUpdateApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateApps.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateApps.BorderColor = System.Drawing.Color.Silver;
            this.btnUpdateApps.BorderRadius = 6F;
            this.btnUpdateApps.BorderSize = 0;
            this.btnUpdateApps.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnUpdateApps.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnUpdateApps.FlatAppearance.BorderSize = 0;
            this.btnUpdateApps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnUpdateApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateApps.ForeColor = System.Drawing.Color.White;
            this.btnUpdateApps.Image = global::DiffPather.Properties.Resources.synchronize_24;
            this.btnUpdateApps.Location = new System.Drawing.Point(738, 4);
            this.btnUpdateApps.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnUpdateApps.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnUpdateApps.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnUpdateApps.Name = "btnUpdateApps";
            this.btnUpdateApps.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnUpdateApps.Size = new System.Drawing.Size(40, 40);
            this.btnUpdateApps.TabIndex = 0;
            this.btnUpdateApps.TextColor = System.Drawing.Color.White;
            this.btnUpdateApps.UseVisualStyleBackColor = false;
            this.btnUpdateApps.Click += new System.EventHandler(this.btnUpdateApps_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.BorderRadius = 6F;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnAdd.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::DiffPather.Properties.Resources.add_24;
            this.btnAdd.Location = new System.Drawing.Point(3, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnAdd.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnAdd.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAppMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileMenuItem.Image = global::DiffPather.Properties.Resources.Folder;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(81, 36);
            this.fileMenuItem.Text = "Файл";
            // 
            // addAppMenuItem
            // 
            this.addAppMenuItem.Image = global::DiffPather.Properties.Resources.Folder_Plus;
            this.addAppMenuItem.Name = "addAppMenuItem";
            this.addAppMenuItem.Size = new System.Drawing.Size(246, 30);
            this.addAppMenuItem.Text = "Добавить приложение";
            this.addAppMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Image = global::DiffPather.Properties.Resources.Button_Close;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(246, 30);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDbMenuItem});
            this.settingsMenuItem.Image = global::DiffPather.Properties.Resources.Folder_Settings;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(120, 36);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // createDbMenuItem
            // 
            this.createDbMenuItem.Image = global::DiffPather.Properties.Resources.Server;
            this.createDbMenuItem.Name = "createDbMenuItem";
            this.createDbMenuItem.Size = new System.Drawing.Size(213, 30);
            this.createDbMenuItem.Text = "Создать новую БД";
            this.createDbMenuItem.Click += new System.EventHandler(this.createDbMenuItem_Click);
            // 
            // infosMenuItem
            // 
            this.infosMenuItem.Image = global::DiffPather.Properties.Resources.Folder_Heart;
            this.infosMenuItem.Name = "infosMenuItem";
            this.infosMenuItem.Size = new System.Drawing.Size(84, 36);
            this.infosMenuItem.Text = "Инфо";
            // 
            // appsColumnName
            // 
            this.appsColumnName.DataPropertyName = "Name";
            this.appsColumnName.HeaderText = "Название";
            this.appsColumnName.Name = "appsColumnName";
            this.appsColumnName.ReadOnly = true;
            // 
            // appsColumnCurrentVersion
            // 
            this.appsColumnCurrentVersion.DataPropertyName = "CurrentVersion";
            this.appsColumnCurrentVersion.HeaderText = "Версия";
            this.appsColumnCurrentVersion.Name = "appsColumnCurrentVersion";
            this.appsColumnCurrentVersion.ReadOnly = true;
            // 
            // appsColumnDescription
            // 
            this.appsColumnDescription.DataPropertyName = "Description";
            this.appsColumnDescription.HeaderText = "Описание";
            this.appsColumnDescription.Name = "appsColumnDescription";
            // 
            // appsColumnDirectoryLocation
            // 
            this.appsColumnDirectoryLocation.DataPropertyName = "DirectoryLocation";
            this.appsColumnDirectoryLocation.HeaderText = "Место";
            this.appsColumnDirectoryLocation.Name = "appsColumnDirectoryLocation";
            this.appsColumnDirectoryLocation.ReadOnly = true;
            // 
            // appInfoBindingSource
            // 
            this.appInfoBindingSource.DataSource = typeof(DiffPather.Core.Database.Models.AppInfo);
            // 
            // appsContextMenu
            // 
            this.appsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appsEditContexMenuItem,
            this.toolStripSeparator2,
            this.appsRemoveContexMenuItem});
            this.appsContextMenu.Name = "appsContextMenu";
            this.appsContextMenu.Size = new System.Drawing.Size(185, 84);
            // 
            // appsRemoveContexMenuItem
            // 
            this.appsRemoveContexMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appsRemoveContexMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appsRemoveContexMenuItem.Name = "appsRemoveContexMenuItem";
            this.appsRemoveContexMenuItem.Size = new System.Drawing.Size(184, 26);
            this.appsRemoveContexMenuItem.Text = "Удалить";
            this.appsRemoveContexMenuItem.Click += new System.EventHandler(this.appsRemoveContexMenuItem_Click);
            // 
            // appsEditContexMenuItem
            // 
            this.appsEditContexMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appsEditContexMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.appsEditContexMenuItem.Name = "appsEditContexMenuItem";
            this.appsEditContexMenuItem.Size = new System.Drawing.Size(184, 26);
            this.appsEditContexMenuItem.Text = "Редактировать";
            this.appsEditContexMenuItem.Click += new System.EventHandler(this.appsEditContexMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // GeneralForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.menuBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.KeyPreview = true;
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.flowLayoutPanelButton.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabApps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appsDataGridView)).EndInit();
            this.appsPanel.ResumeLayout(false);
            this.barcodePanelStat.ResumeLayout(false);
            this.flowLayoutPanelBarcodeStat.ResumeLayout(false);
            this.flowLayoutPanelBarcodeStat.PerformLayout();
            this.tabFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rangeDataGridView)).EndInit();
            this.panelRangeStat.ResumeLayout(false);
            this.flowLayoutPanelRangeStat.ResumeLayout(false);
            this.flowLayoutPanelRangeStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appInfoBindingSource)).EndInit();
            this.appsContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDbMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosMenuItem;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButton;
        private Wc32Api.Widgets.WcButton btnAdd;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabApps;
        private System.Windows.Forms.DataGridView appsDataGridView;
        private System.Windows.Forms.Panel appsPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelApps;
        private System.Windows.Forms.Panel barcodePanelStat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBarcodeStat;
        private System.Windows.Forms.Label appsLabelInfoCount;
        private System.Windows.Forms.Label appsLabelCount;
        private System.Windows.Forms.TabPage tabFiles;
        private System.Windows.Forms.DataGridView rangeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnExternal;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnFirstNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnLastNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnFreeCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnBusyCount;
        private System.Windows.Forms.Panel rangePanel;
        private System.Windows.Forms.Panel panelRangeStat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRangeStat;
        private System.Windows.Forms.Label rangeLabelInfoRangeCount;
        private System.Windows.Forms.Label rangeLabelRangeCount;
        private System.Windows.Forms.BindingSource appInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn appsColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn appsColumnCurrentVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn appsColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn appsColumnDirectoryLocation;
        private Wc32Api.Widgets.WcButton btnUpdateApps;
        private System.Windows.Forms.ToolStripMenuItem addAppMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip appsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem appsEditContexMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem appsRemoveContexMenuItem;
    }
}

