
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBarcodes = new System.Windows.Forms.TabPage();
            this.tabRanges = new System.Windows.Forms.TabPage();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelReport = new System.Windows.Forms.FlowLayoutPanel();
            this.barcodeLabelInfoBarcode = new System.Windows.Forms.Label();
            this.barcodeDataGridView = new System.Windows.Forms.DataGridView();
            this.reportColumnDayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportPanelStat = new System.Windows.Forms.Panel();
            this.barcodeLabelCount = new System.Windows.Forms.Label();
            this.barcodeLabelInfoCount = new System.Windows.Forms.Label();
            this.barcodeTextBoxBarcode = new Wc32Api.Widgets.WcTextBox();
            this.btnLoadBarcode = new Wc32Api.Widgets.WcButton();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabBarcodes.SuspendLayout();
            this.reportPanel.SuspendLayout();
            this.flowLayoutPanelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeDataGridView)).BeginInit();
            this.reportPanelStat.SuspendLayout();
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
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(122, 24);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(96, 36);
            this.settingsMenuItem.Text = "Настройки";
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
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelGeneral.Location = new System.Drawing.Point(0, 40);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(800, 58);
            this.panelGeneral.TabIndex = 5;
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
            this.tabBarcodes.Controls.Add(this.reportPanelStat);
            this.tabBarcodes.Controls.Add(this.barcodeDataGridView);
            this.tabBarcodes.Controls.Add(this.reportPanel);
            this.tabBarcodes.Location = new System.Drawing.Point(4, 36);
            this.tabBarcodes.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.tabBarcodes.Name = "tabBarcodes";
            this.tabBarcodes.Padding = new System.Windows.Forms.Padding(3);
            this.tabBarcodes.Size = new System.Drawing.Size(792, 290);
            this.tabBarcodes.TabIndex = 0;
            this.tabBarcodes.Text = "ШПИ";
            this.tabBarcodes.UseVisualStyleBackColor = true;
            // 
            // tabRanges
            // 
            this.tabRanges.Location = new System.Drawing.Point(4, 36);
            this.tabRanges.Name = "tabRanges";
            this.tabRanges.Padding = new System.Windows.Forms.Padding(3);
            this.tabRanges.Size = new System.Drawing.Size(792, 290);
            this.tabRanges.TabIndex = 1;
            this.tabRanges.Text = "Диапазоны";
            this.tabRanges.UseVisualStyleBackColor = true;
            // 
            // reportPanel
            // 
            this.reportPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.reportPanel.Controls.Add(this.flowLayoutPanelReport);
            this.reportPanel.Controls.Add(this.btnLoadBarcode);
            this.reportPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportPanel.Location = new System.Drawing.Point(3, 3);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(786, 48);
            this.reportPanel.TabIndex = 5;
            // 
            // flowLayoutPanelReport
            // 
            this.flowLayoutPanelReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelReport.Controls.Add(this.barcodeLabelInfoBarcode);
            this.flowLayoutPanelReport.Controls.Add(this.barcodeTextBoxBarcode);
            this.flowLayoutPanelReport.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanelReport.Name = "flowLayoutPanelReport";
            this.flowLayoutPanelReport.Size = new System.Drawing.Size(729, 41);
            this.flowLayoutPanelReport.TabIndex = 27;
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
            // barcodeDataGridView
            // 
            this.barcodeDataGridView.AllowUserToAddRows = false;
            this.barcodeDataGridView.AllowUserToDeleteRows = false;
            this.barcodeDataGridView.AllowUserToResizeColumns = false;
            this.barcodeDataGridView.AllowUserToResizeRows = false;
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
            this.reportColumnDayName,
            this.reportColumnType});
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
            // reportColumnDayName
            // 
            this.reportColumnDayName.DataPropertyName = "DayName";
            this.reportColumnDayName.HeaderText = "День";
            this.reportColumnDayName.Name = "reportColumnDayName";
            this.reportColumnDayName.ReadOnly = true;
            // 
            // reportColumnType
            // 
            this.reportColumnType.DataPropertyName = "Type";
            this.reportColumnType.HeaderText = "Смена";
            this.reportColumnType.Name = "reportColumnType";
            this.reportColumnType.ReadOnly = true;
            // 
            // reportPanelStat
            // 
            this.reportPanelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.reportPanelStat.Controls.Add(this.barcodeLabelCount);
            this.reportPanelStat.Controls.Add(this.barcodeLabelInfoCount);
            this.reportPanelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportPanelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.reportPanelStat.Location = new System.Drawing.Point(3, 257);
            this.reportPanelStat.Name = "reportPanelStat";
            this.reportPanelStat.Size = new System.Drawing.Size(786, 30);
            this.reportPanelStat.TabIndex = 7;
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
            // barcodeTextBoxBarcode
            // 
            this.barcodeTextBoxBarcode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.barcodeTextBoxBarcode.BorderColor = System.Drawing.Color.DimGray;
            this.barcodeTextBoxBarcode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.barcodeTextBoxBarcode.BorderSize = 2;
            this.barcodeTextBoxBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
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
            this.barcodeTextBoxBarcode.Texts = "";
            this.barcodeTextBoxBarcode.UnderlinedStyle = false;
            this.barcodeTextBoxBarcode.UsePasswordChar = false;
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
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabBarcodes.ResumeLayout(false);
            this.reportPanel.ResumeLayout(false);
            this.flowLayoutPanelReport.ResumeLayout(false);
            this.flowLayoutPanelReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeDataGridView)).EndInit();
            this.reportPanelStat.ResumeLayout(false);
            this.reportPanelStat.PerformLayout();
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
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReport;
        private System.Windows.Forms.Label barcodeLabelInfoBarcode;
        private Wc32Api.Widgets.WcButton btnLoadBarcode;
        private Wc32Api.Widgets.WcTextBox barcodeTextBoxBarcode;
        private System.Windows.Forms.DataGridView barcodeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportColumnDayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportColumnType;
        private System.Windows.Forms.Panel reportPanelStat;
        private System.Windows.Forms.Label barcodeLabelCount;
        private System.Windows.Forms.Label barcodeLabelInfoCount;
    }
}

