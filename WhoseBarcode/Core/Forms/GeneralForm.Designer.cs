
namespace WhoseBarcode.Core.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.lblInfoDebug = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBarcodes = new System.Windows.Forms.TabPage();
            this.barcodePanelStat = new System.Windows.Forms.Panel();
            this.barcodeLabelCount = new System.Windows.Forms.Label();
            this.barcodeLabelInfoCount = new System.Windows.Forms.Label();
            this.barcodeDataGridView = new System.Windows.Forms.DataGridView();
            this.barcodePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBarcode = new System.Windows.Forms.FlowLayoutPanel();
            this.barcodeLabelInfoBarcode = new System.Windows.Forms.Label();
            this.barcodeLabelError = new System.Windows.Forms.Label();
            this.tabRanges = new System.Windows.Forms.TabPage();
            this.barcodeTextBoxBarcode = new Wc32Api.Widgets.WcTextBox();
            this.btnLoadBarcode = new Wc32Api.Widgets.WcButton();
            this.btnDebug = new Wc32Api.Widgets.WcToggleButton();
            this.barcodeColumnOps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelRange = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadRange = new Wc32Api.Widgets.WcButton();
            this.rangeDataGridView = new System.Windows.Forms.DataGridView();
            this.rangePanelStat = new System.Windows.Forms.Panel();
            this.rangeLabelCount = new System.Windows.Forms.Label();
            this.rangeLabelInfoCount = new System.Windows.Forms.Label();
            this.barcodeColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumnBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumnMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumnSeria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumnFirmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbBarcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbRangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rangeColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnOps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnSeria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnFirmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBar.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabBarcodes.SuspendLayout();
            this.barcodePanelStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeDataGridView)).BeginInit();
            this.barcodePanel.SuspendLayout();
            this.flowLayoutPanelBarcode.SuspendLayout();
            this.tabRanges.SuspendLayout();
            this.rangePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangeDataGridView)).BeginInit();
            this.rangePanelStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbBarcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRangeBindingSource)).BeginInit();
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
            this.exitMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(122, 24);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectItem});
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(96, 36);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // connectItem
            // 
            this.connectItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.connectItem.Name = "connectItem";
            this.connectItem.Size = new System.Drawing.Size(209, 24);
            this.connectItem.Text = "Подключение к БД";
            this.connectItem.Click += new System.EventHandler(this.connectItem_Click);
            // 
            // infosMenuItem
            // 
            this.infosMenuItem.Name = "infosMenuItem";
            this.infosMenuItem.Size = new System.Drawing.Size(60, 36);
            this.infosMenuItem.Text = "Инфо";
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelGeneral.Controls.Add(this.lblInfoDebug);
            this.panelGeneral.Controls.Add(this.btnDebug);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelGeneral.Location = new System.Drawing.Point(0, 40);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(800, 58);
            this.panelGeneral.TabIndex = 5;
            // 
            // lblInfoDebug
            // 
            this.lblInfoDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoDebug.AutoSize = true;
            this.lblInfoDebug.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoDebug.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInfoDebug.Location = new System.Drawing.Point(663, 17);
            this.lblInfoDebug.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.lblInfoDebug.Name = "lblInfoDebug";
            this.lblInfoDebug.Size = new System.Drawing.Size(71, 20);
            this.lblInfoDebug.TabIndex = 27;
            this.lblInfoDebug.Text = "Отладка:";
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
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBarcodes);
            this.tabControl.Controls.Add(this.tabRanges);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 98);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(60, 6);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 330);
            this.tabControl.TabIndex = 8;
            // 
            // tabBarcodes
            // 
            this.tabBarcodes.Controls.Add(this.barcodePanelStat);
            this.tabBarcodes.Controls.Add(this.barcodeDataGridView);
            this.tabBarcodes.Controls.Add(this.barcodePanel);
            this.tabBarcodes.Location = new System.Drawing.Point(4, 36);
            this.tabBarcodes.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.tabBarcodes.Name = "tabBarcodes";
            this.tabBarcodes.Padding = new System.Windows.Forms.Padding(3);
            this.tabBarcodes.Size = new System.Drawing.Size(792, 290);
            this.tabBarcodes.TabIndex = 0;
            this.tabBarcodes.Text = "ШПИ";
            this.tabBarcodes.UseVisualStyleBackColor = true;
            // 
            // barcodePanelStat
            // 
            this.barcodePanelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.barcodePanelStat.Controls.Add(this.barcodeLabelCount);
            this.barcodePanelStat.Controls.Add(this.barcodeLabelInfoCount);
            this.barcodePanelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barcodePanelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.barcodePanelStat.Location = new System.Drawing.Point(3, 257);
            this.barcodePanelStat.Name = "barcodePanelStat";
            this.barcodePanelStat.Size = new System.Drawing.Size(786, 30);
            this.barcodePanelStat.TabIndex = 7;
            // 
            // barcodeLabelCount
            // 
            this.barcodeLabelCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLabelCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.barcodeLabelCount.Location = new System.Drawing.Point(122, 5);
            this.barcodeLabelCount.Name = "barcodeLabelCount";
            this.barcodeLabelCount.Size = new System.Drawing.Size(140, 20);
            this.barcodeLabelCount.TabIndex = 0;
            this.barcodeLabelCount.Text = "0";
            // 
            // barcodeLabelInfoCount
            // 
            this.barcodeLabelInfoCount.AutoSize = true;
            this.barcodeLabelInfoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLabelInfoCount.Location = new System.Drawing.Point(21, 5);
            this.barcodeLabelInfoCount.Name = "barcodeLabelInfoCount";
            this.barcodeLabelInfoCount.Size = new System.Drawing.Size(95, 20);
            this.barcodeLabelInfoCount.TabIndex = 0;
            this.barcodeLabelInfoCount.Text = "Количество:";
            // 
            // barcodeDataGridView
            // 
            this.barcodeDataGridView.AllowUserToAddRows = false;
            this.barcodeDataGridView.AllowUserToDeleteRows = false;
            this.barcodeDataGridView.AllowUserToResizeColumns = false;
            this.barcodeDataGridView.AllowUserToResizeRows = false;
            this.barcodeDataGridView.AutoGenerateColumns = false;
            this.barcodeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.barcodeDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.barcodeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.barcodeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.barcodeDataGridView.ColumnHeadersHeight = 40;
            this.barcodeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.barcodeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeColumnDate,
            this.barcodeColumnBarcode,
            this.barcodeColumnOps,
            this.barcodeColumnMonth,
            this.barcodeColumnSeria,
            this.barcodeColumnNum,
            this.barcodeColumnFirmName,
            this.barcodeColumnState});
            this.barcodeDataGridView.DataSource = this.dbBarcodeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.barcodeDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.barcodeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeDataGridView.EnableHeadersVisualStyles = false;
            this.barcodeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.barcodeDataGridView.Location = new System.Drawing.Point(3, 51);
            this.barcodeDataGridView.Name = "barcodeDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.barcodeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.barcodeDataGridView.RowHeadersVisible = false;
            this.barcodeDataGridView.RowHeadersWidth = 40;
            this.barcodeDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.barcodeDataGridView.RowTemplate.Height = 40;
            this.barcodeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.barcodeDataGridView.Size = new System.Drawing.Size(786, 236);
            this.barcodeDataGridView.TabIndex = 6;
            this.barcodeDataGridView.TabStop = false;
            // 
            // barcodePanel
            // 
            this.barcodePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.barcodePanel.Controls.Add(this.flowLayoutPanelBarcode);
            this.barcodePanel.Controls.Add(this.btnLoadBarcode);
            this.barcodePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.barcodePanel.Location = new System.Drawing.Point(3, 3);
            this.barcodePanel.Name = "barcodePanel";
            this.barcodePanel.Size = new System.Drawing.Size(786, 48);
            this.barcodePanel.TabIndex = 5;
            // 
            // flowLayoutPanelBarcode
            // 
            this.flowLayoutPanelBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelBarcode.Controls.Add(this.barcodeLabelInfoBarcode);
            this.flowLayoutPanelBarcode.Controls.Add(this.barcodeTextBoxBarcode);
            this.flowLayoutPanelBarcode.Controls.Add(this.barcodeLabelError);
            this.flowLayoutPanelBarcode.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanelBarcode.Name = "flowLayoutPanelBarcode";
            this.flowLayoutPanelBarcode.Size = new System.Drawing.Size(729, 41);
            this.flowLayoutPanelBarcode.TabIndex = 27;
            this.flowLayoutPanelBarcode.WrapContents = false;
            // 
            // barcodeLabelInfoBarcode
            // 
            this.barcodeLabelInfoBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeLabelInfoBarcode.AutoSize = true;
            this.barcodeLabelInfoBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLabelInfoBarcode.ForeColor = System.Drawing.Color.Gainsboro;
            this.barcodeLabelInfoBarcode.Location = new System.Drawing.Point(6, 10);
            this.barcodeLabelInfoBarcode.Margin = new System.Windows.Forms.Padding(6, 10, 3, 0);
            this.barcodeLabelInfoBarcode.Name = "barcodeLabelInfoBarcode";
            this.barcodeLabelInfoBarcode.Size = new System.Drawing.Size(51, 20);
            this.barcodeLabelInfoBarcode.TabIndex = 26;
            this.barcodeLabelInfoBarcode.Text = "ШПИ:";
            // 
            // barcodeLabelError
            // 
            this.barcodeLabelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeLabelError.AutoSize = true;
            this.barcodeLabelError.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLabelError.ForeColor = System.Drawing.Color.DarkOrange;
            this.barcodeLabelError.Location = new System.Drawing.Point(284, 12);
            this.barcodeLabelError.Margin = new System.Windows.Forms.Padding(6, 12, 3, 0);
            this.barcodeLabelError.Name = "barcodeLabelError";
            this.barcodeLabelError.Size = new System.Drawing.Size(59, 17);
            this.barcodeLabelError.TabIndex = 28;
            this.barcodeLabelError.Text = "Ошибка";
            this.barcodeLabelError.Visible = false;
            // 
            // tabRanges
            // 
            this.tabRanges.Controls.Add(this.rangePanelStat);
            this.tabRanges.Controls.Add(this.rangeDataGridView);
            this.tabRanges.Controls.Add(this.rangePanel);
            this.tabRanges.Location = new System.Drawing.Point(4, 36);
            this.tabRanges.Name = "tabRanges";
            this.tabRanges.Padding = new System.Windows.Forms.Padding(3);
            this.tabRanges.Size = new System.Drawing.Size(792, 290);
            this.tabRanges.TabIndex = 1;
            this.tabRanges.Text = "Диапазоны";
            this.tabRanges.UseVisualStyleBackColor = true;
            // 
            // barcodeTextBoxBarcode
            // 
            this.barcodeTextBoxBarcode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.barcodeTextBoxBarcode.BorderColor = System.Drawing.Color.DimGray;
            this.barcodeTextBoxBarcode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.barcodeTextBoxBarcode.BorderSize = 2;
            this.barcodeTextBoxBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.barcodeTextBoxBarcode.DisableBackColor = System.Drawing.Color.DarkGray;
            this.barcodeTextBoxBarcode.DisableBorderColor = System.Drawing.Color.DimGray;
            this.barcodeTextBoxBarcode.DisableForeColor = System.Drawing.Color.DimGray;
            this.barcodeTextBoxBarcode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeTextBoxBarcode.ForeColor = System.Drawing.Color.DimGray;
            this.barcodeTextBoxBarcode.Location = new System.Drawing.Point(64, 3);
            this.barcodeTextBoxBarcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this.barcodeTextBoxBarcode.MaxLength = 14;
            this.barcodeTextBoxBarcode.Multiline = false;
            this.barcodeTextBoxBarcode.Name = "barcodeTextBoxBarcode";
            this.barcodeTextBoxBarcode.Padding = new System.Windows.Forms.Padding(7);
            this.barcodeTextBoxBarcode.PasswordChar = '\0';
            this.barcodeTextBoxBarcode.ReadOnly = false;
            this.barcodeTextBoxBarcode.Size = new System.Drawing.Size(210, 35);
            this.barcodeTextBoxBarcode.TabIndex = 27;
            this.barcodeTextBoxBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.barcodeTextBoxBarcode.UnderlinedStyle = false;
            this.barcodeTextBoxBarcode.UsePasswordChar = false;
            this.barcodeTextBoxBarcode.Enter += new System.EventHandler(this.barcodeTextBoxBarcode_Enter);
            this.barcodeTextBoxBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcodeTextBoxBarcode_KeyDown);
            // 
            // btnLoadBarcode
            // 
            this.btnLoadBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnLoadBarcode.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadBarcode.BorderRadius = 6F;
            this.btnLoadBarcode.BorderSize = 0;
            this.btnLoadBarcode.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadBarcode.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadBarcode.FlatAppearance.BorderSize = 0;
            this.btnLoadBarcode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnLoadBarcode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(119)))), ((int)(((byte)(190)))));
            this.btnLoadBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadBarcode.ForeColor = System.Drawing.Color.White;
            this.btnLoadBarcode.Image = global::WhoseBarcode.Properties.Resources.sinchronize_24;
            this.btnLoadBarcode.Location = new System.Drawing.Point(738, 4);
            this.btnLoadBarcode.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnLoadBarcode.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(119)))), ((int)(((byte)(190)))));
            this.btnLoadBarcode.Name = "btnLoadBarcode";
            this.btnLoadBarcode.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadBarcode.Size = new System.Drawing.Size(40, 40);
            this.btnLoadBarcode.TabIndex = 24;
            this.btnLoadBarcode.TextColor = System.Drawing.Color.White;
            this.btnLoadBarcode.UseVisualStyleBackColor = false;
            this.btnLoadBarcode.Click += new System.EventHandler(this.btnLoadBarcode_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDebug.AutoSize = true;
            this.btnDebug.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnDebug.DisableToggleColor = System.Drawing.Color.Gray;
            this.btnDebug.Location = new System.Drawing.Point(740, 17);
            this.btnDebug.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.OffBackColor = System.Drawing.Color.Firebrick;
            this.btnDebug.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnDebug.OnBackColor = System.Drawing.Color.SeaGreen;
            this.btnDebug.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnDebug.Size = new System.Drawing.Size(45, 22);
            this.btnDebug.TabIndex = 0;
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.CheckedChanged += new System.EventHandler(this.btnDebug_CheckedChanged);
            // 
            // barcodeColumnOps
            // 
            this.barcodeColumnOps.DataPropertyName = "Ops";
            this.barcodeColumnOps.HeaderText = "   ОПС";
            this.barcodeColumnOps.Name = "barcodeColumnOps";
            this.barcodeColumnOps.ReadOnly = true;
            // 
            // rangePanel
            // 
            this.rangePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.rangePanel.Controls.Add(this.flowLayoutPanelRange);
            this.rangePanel.Controls.Add(this.btnLoadRange);
            this.rangePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rangePanel.Location = new System.Drawing.Point(3, 3);
            this.rangePanel.Name = "rangePanel";
            this.rangePanel.Size = new System.Drawing.Size(786, 48);
            this.rangePanel.TabIndex = 6;
            // 
            // flowLayoutPanelRange
            // 
            this.flowLayoutPanelRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelRange.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanelRange.Name = "flowLayoutPanelRange";
            this.flowLayoutPanelRange.Size = new System.Drawing.Size(729, 41);
            this.flowLayoutPanelRange.TabIndex = 27;
            this.flowLayoutPanelRange.WrapContents = false;
            // 
            // btnLoadRange
            // 
            this.btnLoadRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnLoadRange.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadRange.BorderRadius = 6F;
            this.btnLoadRange.BorderSize = 0;
            this.btnLoadRange.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadRange.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadRange.FlatAppearance.BorderSize = 0;
            this.btnLoadRange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnLoadRange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(119)))), ((int)(((byte)(190)))));
            this.btnLoadRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadRange.ForeColor = System.Drawing.Color.White;
            this.btnLoadRange.Image = global::WhoseBarcode.Properties.Resources.sinchronize_24;
            this.btnLoadRange.Location = new System.Drawing.Point(738, 4);
            this.btnLoadRange.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(71)))), ((int)(((byte)(136)))));
            this.btnLoadRange.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(119)))), ((int)(((byte)(190)))));
            this.btnLoadRange.Name = "btnLoadRange";
            this.btnLoadRange.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadRange.Size = new System.Drawing.Size(40, 40);
            this.btnLoadRange.TabIndex = 24;
            this.btnLoadRange.TextColor = System.Drawing.Color.White;
            this.btnLoadRange.UseVisualStyleBackColor = false;
            // 
            // rangeDataGridView
            // 
            this.rangeDataGridView.AllowUserToAddRows = false;
            this.rangeDataGridView.AllowUserToDeleteRows = false;
            this.rangeDataGridView.AllowUserToResizeColumns = false;
            this.rangeDataGridView.AllowUserToResizeRows = false;
            this.rangeDataGridView.AutoGenerateColumns = false;
            this.rangeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rangeDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.rangeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rangeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.rangeDataGridView.ColumnHeadersHeight = 40;
            this.rangeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rangeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rangeColumnId,
            this.rangeColumnDate,
            this.rangeColumnOps,
            this.rangeColumnMonth,
            this.rangeColumnSeria,
            this.rangeColumnFirmName,
            this.rangeColumnCount});
            this.rangeDataGridView.DataSource = this.dbRangeBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rangeDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.rangeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangeDataGridView.EnableHeadersVisualStyles = false;
            this.rangeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rangeDataGridView.Location = new System.Drawing.Point(3, 51);
            this.rangeDataGridView.Name = "rangeDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rangeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.rangeDataGridView.RowHeadersVisible = false;
            this.rangeDataGridView.RowHeadersWidth = 40;
            this.rangeDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rangeDataGridView.RowTemplate.Height = 40;
            this.rangeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.rangeDataGridView.Size = new System.Drawing.Size(786, 236);
            this.rangeDataGridView.TabIndex = 7;
            this.rangeDataGridView.TabStop = false;
            // 
            // rangePanelStat
            // 
            this.rangePanelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.rangePanelStat.Controls.Add(this.rangeLabelCount);
            this.rangePanelStat.Controls.Add(this.rangeLabelInfoCount);
            this.rangePanelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rangePanelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.rangePanelStat.Location = new System.Drawing.Point(3, 257);
            this.rangePanelStat.Name = "rangePanelStat";
            this.rangePanelStat.Size = new System.Drawing.Size(786, 30);
            this.rangePanelStat.TabIndex = 8;
            // 
            // rangeLabelCount
            // 
            this.rangeLabelCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.rangeLabelCount.Location = new System.Drawing.Point(122, 5);
            this.rangeLabelCount.Name = "rangeLabelCount";
            this.rangeLabelCount.Size = new System.Drawing.Size(140, 20);
            this.rangeLabelCount.TabIndex = 0;
            this.rangeLabelCount.Text = "0";
            // 
            // rangeLabelInfoCount
            // 
            this.rangeLabelInfoCount.AutoSize = true;
            this.rangeLabelInfoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeLabelInfoCount.Location = new System.Drawing.Point(21, 5);
            this.rangeLabelInfoCount.Name = "rangeLabelInfoCount";
            this.rangeLabelInfoCount.Size = new System.Drawing.Size(95, 20);
            this.rangeLabelInfoCount.TabIndex = 0;
            this.rangeLabelInfoCount.Text = "Количество:";
            // 
            // barcodeColumnDate
            // 
            this.barcodeColumnDate.DataPropertyName = "Date";
            this.barcodeColumnDate.HeaderText = "  Дата";
            this.barcodeColumnDate.Name = "barcodeColumnDate";
            this.barcodeColumnDate.ReadOnly = true;
            // 
            // barcodeColumnBarcode
            // 
            this.barcodeColumnBarcode.DataPropertyName = "Barcode";
            this.barcodeColumnBarcode.HeaderText = "   ШПИ";
            this.barcodeColumnBarcode.Name = "barcodeColumnBarcode";
            this.barcodeColumnBarcode.ReadOnly = true;
            // 
            // barcodeColumnMonth
            // 
            this.barcodeColumnMonth.DataPropertyName = "Month";
            this.barcodeColumnMonth.HeaderText = " Месяц";
            this.barcodeColumnMonth.Name = "barcodeColumnMonth";
            this.barcodeColumnMonth.ReadOnly = true;
            // 
            // barcodeColumnSeria
            // 
            this.barcodeColumnSeria.DataPropertyName = "Seria";
            this.barcodeColumnSeria.HeaderText = " Серия";
            this.barcodeColumnSeria.Name = "barcodeColumnSeria";
            this.barcodeColumnSeria.ReadOnly = true;
            // 
            // barcodeColumnNum
            // 
            this.barcodeColumnNum.DataPropertyName = "Num";
            this.barcodeColumnNum.HeaderText = "  Номер";
            this.barcodeColumnNum.Name = "barcodeColumnNum";
            this.barcodeColumnNum.ReadOnly = true;
            // 
            // barcodeColumnFirmName
            // 
            this.barcodeColumnFirmName.DataPropertyName = "FirmName";
            this.barcodeColumnFirmName.HeaderText = "Организация";
            this.barcodeColumnFirmName.Name = "barcodeColumnFirmName";
            this.barcodeColumnFirmName.ReadOnly = true;
            // 
            // barcodeColumnState
            // 
            this.barcodeColumnState.DataPropertyName = "State";
            this.barcodeColumnState.HeaderText = "   Статус";
            this.barcodeColumnState.Name = "barcodeColumnState";
            this.barcodeColumnState.ReadOnly = true;
            // 
            // dbBarcodeBindingSource
            // 
            this.dbBarcodeBindingSource.DataSource = typeof(WhoseBarcode.Core.Database.Models.DbBarcode);
            // 
            // dbRangeBindingSource
            // 
            this.dbRangeBindingSource.DataSource = typeof(WhoseBarcode.Core.Database.Models.DbRange);
            // 
            // rangeColumnId
            // 
            this.rangeColumnId.DataPropertyName = "Id";
            this.rangeColumnId.HeaderText = "    Id";
            this.rangeColumnId.Name = "rangeColumnId";
            this.rangeColumnId.ReadOnly = true;
            // 
            // rangeColumnDate
            // 
            this.rangeColumnDate.DataPropertyName = "Date";
            this.rangeColumnDate.HeaderText = "   Дата";
            this.rangeColumnDate.Name = "rangeColumnDate";
            this.rangeColumnDate.ReadOnly = true;
            // 
            // rangeColumnOps
            // 
            this.rangeColumnOps.DataPropertyName = "Ops";
            this.rangeColumnOps.HeaderText = "   ОПС";
            this.rangeColumnOps.Name = "rangeColumnOps";
            this.rangeColumnOps.ReadOnly = true;
            // 
            // rangeColumnMonth
            // 
            this.rangeColumnMonth.DataPropertyName = "Month";
            this.rangeColumnMonth.HeaderText = " Месяц";
            this.rangeColumnMonth.Name = "rangeColumnMonth";
            this.rangeColumnMonth.ReadOnly = true;
            // 
            // rangeColumnSeria
            // 
            this.rangeColumnSeria.DataPropertyName = "Seria";
            this.rangeColumnSeria.HeaderText = " Серия";
            this.rangeColumnSeria.Name = "rangeColumnSeria";
            this.rangeColumnSeria.ReadOnly = true;
            // 
            // rangeColumnFirmName
            // 
            this.rangeColumnFirmName.DataPropertyName = "FirmName";
            this.rangeColumnFirmName.HeaderText = "Организация";
            this.rangeColumnFirmName.Name = "rangeColumnFirmName";
            this.rangeColumnFirmName.ReadOnly = true;
            // 
            // rangeColumnCount
            // 
            this.rangeColumnCount.DataPropertyName = "Count";
            this.rangeColumnCount.HeaderText = "   Кол-во";
            this.rangeColumnCount.Name = "rangeColumnCount";
            this.rangeColumnCount.ReadOnly = true;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabBarcodes.ResumeLayout(false);
            this.barcodePanelStat.ResumeLayout(false);
            this.barcodePanelStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeDataGridView)).EndInit();
            this.barcodePanel.ResumeLayout(false);
            this.flowLayoutPanelBarcode.ResumeLayout(false);
            this.flowLayoutPanelBarcode.PerformLayout();
            this.tabRanges.ResumeLayout(false);
            this.rangePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rangeDataGridView)).EndInit();
            this.rangePanelStat.ResumeLayout(false);
            this.rangePanelStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbBarcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRangeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosMenuItem;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel statusAuthor;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBarcodes;
        private System.Windows.Forms.TabPage tabRanges;
        private System.Windows.Forms.Panel barcodePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBarcode;
        private System.Windows.Forms.Label barcodeLabelInfoBarcode;
        private Wc32Api.Widgets.WcButton btnLoadBarcode;
        private Wc32Api.Widgets.WcTextBox barcodeTextBoxBarcode;
        private System.Windows.Forms.DataGridView barcodeDataGridView;
        private System.Windows.Forms.Panel barcodePanelStat;
        private System.Windows.Forms.Label barcodeLabelCount;
        private System.Windows.Forms.Label barcodeLabelInfoCount;
        private System.Windows.Forms.Label barcodeLabelError;
        private System.Windows.Forms.BindingSource dbBarcodeBindingSource;
        private System.Windows.Forms.ToolStripMenuItem connectItem;
        private System.Windows.Forms.Label lblInfoDebug;
        private Wc32Api.Widgets.WcToggleButton btnDebug;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnOps;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnSeria;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnFirmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumnState;
        private System.Windows.Forms.Panel rangePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRange;
        private Wc32Api.Widgets.WcButton btnLoadRange;
        private System.Windows.Forms.DataGridView rangeDataGridView;
        private System.Windows.Forms.Panel rangePanelStat;
        private System.Windows.Forms.Label rangeLabelCount;
        private System.Windows.Forms.Label rangeLabelInfoCount;
        private System.Windows.Forms.BindingSource dbRangeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnOps;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnSeria;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnFirmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeColumnCount;
    }
}

