
namespace DwUtils.Core.Forms
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
            this.connectPostUnitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectPostItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.labelInfoLoadLk = new System.Windows.Forms.Label();
            this.toggleLoadLk = new Wc32Api.Widgets.WcToggleButton();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabFreeRpo = new System.Windows.Forms.TabPage();
            this.freeRpoDataGridView = new System.Windows.Forms.DataGridView();
            this.panelFreeRpo = new System.Windows.Forms.Panel();
            this.btnLoadFreeRpo = new Wc32Api.Widgets.WcButton();
            this.flowLayoutPanelFreeRpo = new System.Windows.Forms.FlowLayoutPanel();
            this.barcodePanelStat = new System.Windows.Forms.Panel();
            this.flowLayoutPanelFreeRpoStat = new System.Windows.Forms.FlowLayoutPanel();
            this.freeRpoLabelInfoCount = new System.Windows.Forms.Label();
            this.freeRpoLabelCount = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabFreeRpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freeRpoDataGridView)).BeginInit();
            this.panelFreeRpo.SuspendLayout();
            this.barcodePanelStat.SuspendLayout();
            this.flowLayoutPanelFreeRpoStat.SuspendLayout();
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
            this.fileMenuItem.Image = global::DwUtils.Properties.Resources.Folder;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(81, 36);
            this.fileMenuItem.Text = "Файл";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.exitMenuItem.Image = global::DwUtils.Properties.Resources.Button_Close;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(188, 30);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectPostUnitMenuItem,
            this.connectPostItemMenuItem});
            this.settingsMenuItem.Image = global::DwUtils.Properties.Resources.Folder_Settings;
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(120, 36);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // connectPostUnitMenuItem
            // 
            this.connectPostUnitMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.connectPostUnitMenuItem.Image = global::DwUtils.Properties.Resources.Server;
            this.connectPostUnitMenuItem.Name = "connectPostUnitMenuItem";
            this.connectPostUnitMenuItem.Size = new System.Drawing.Size(255, 30);
            this.connectPostUnitMenuItem.Text = "Подключение к PostUnit";
            this.connectPostUnitMenuItem.Click += new System.EventHandler(this.connectPostUnitMenuItem_Click);
            // 
            // connectPostItemMenuItem
            // 
            this.connectPostItemMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.connectPostItemMenuItem.Image = global::DwUtils.Properties.Resources.Server;
            this.connectPostItemMenuItem.Name = "connectPostItemMenuItem";
            this.connectPostItemMenuItem.Size = new System.Drawing.Size(255, 30);
            this.connectPostItemMenuItem.Text = "Подключение к PostItem";
            this.connectPostItemMenuItem.Click += new System.EventHandler(this.connectPostItemMenuItem_Click);
            // 
            // infosMenuItem
            // 
            this.infosMenuItem.Image = global::DwUtils.Properties.Resources.Folder_Heart;
            this.infosMenuItem.Name = "infosMenuItem";
            this.infosMenuItem.Size = new System.Drawing.Size(84, 36);
            this.infosMenuItem.Text = "Инфо";
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelGeneral.Controls.Add(this.labelInfoLoadLk);
            this.panelGeneral.Controls.Add(this.toggleLoadLk);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelGeneral.Location = new System.Drawing.Point(0, 40);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(800, 58);
            this.panelGeneral.TabIndex = 5;
            // 
            // labelInfoLoadLk
            // 
            this.labelInfoLoadLk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfoLoadLk.AutoSize = true;
            this.labelInfoLoadLk.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoLoadLk.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelInfoLoadLk.Location = new System.Drawing.Point(639, 19);
            this.labelInfoLoadLk.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.labelInfoLoadLk.Name = "labelInfoLoadLk";
            this.labelInfoLoadLk.Size = new System.Drawing.Size(98, 20);
            this.labelInfoLoadLk.TabIndex = 27;
            this.labelInfoLoadLk.Text = "Загрузка ЛК:";
            // 
            // toggleLoadLk
            // 
            this.toggleLoadLk.AutoSize = true;
            this.toggleLoadLk.Checked = true;
            this.toggleLoadLk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleLoadLk.DisableBackColor = System.Drawing.Color.DimGray;
            this.toggleLoadLk.DisableToggleColor = System.Drawing.Color.Gray;
            this.toggleLoadLk.Location = new System.Drawing.Point(743, 18);
            this.toggleLoadLk.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleLoadLk.Name = "toggleLoadLk";
            this.toggleLoadLk.OffBackColor = System.Drawing.Color.Firebrick;
            this.toggleLoadLk.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleLoadLk.OnBackColor = System.Drawing.Color.SeaGreen;
            this.toggleLoadLk.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleLoadLk.Size = new System.Drawing.Size(45, 22);
            this.toggleLoadLk.TabIndex = 0;
            this.toggleLoadLk.UseVisualStyleBackColor = true;
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
            this.tabControl.Controls.Add(this.tabFreeRpo);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 98);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(60, 6);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 330);
            this.tabControl.TabIndex = 10;
            // 
            // tabFreeRpo
            // 
            this.tabFreeRpo.Controls.Add(this.freeRpoDataGridView);
            this.tabFreeRpo.Controls.Add(this.panelFreeRpo);
            this.tabFreeRpo.Controls.Add(this.barcodePanelStat);
            this.tabFreeRpo.Location = new System.Drawing.Point(4, 36);
            this.tabFreeRpo.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.tabFreeRpo.Name = "tabFreeRpo";
            this.tabFreeRpo.Padding = new System.Windows.Forms.Padding(3);
            this.tabFreeRpo.Size = new System.Drawing.Size(792, 290);
            this.tabFreeRpo.TabIndex = 0;
            this.tabFreeRpo.Text = "Сводобные РПО";
            this.tabFreeRpo.UseVisualStyleBackColor = true;
            // 
            // freeRpoDataGridView
            // 
            this.freeRpoDataGridView.AllowUserToAddRows = false;
            this.freeRpoDataGridView.AllowUserToDeleteRows = false;
            this.freeRpoDataGridView.AllowUserToResizeColumns = false;
            this.freeRpoDataGridView.AllowUserToResizeRows = false;
            this.freeRpoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.freeRpoDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.freeRpoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.freeRpoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.freeRpoDataGridView.ColumnHeadersHeight = 40;
            this.freeRpoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.freeRpoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.freeRpoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freeRpoDataGridView.EnableHeadersVisualStyles = false;
            this.freeRpoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.freeRpoDataGridView.Location = new System.Drawing.Point(3, 51);
            this.freeRpoDataGridView.Name = "freeRpoDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.freeRpoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.freeRpoDataGridView.RowHeadersVisible = false;
            this.freeRpoDataGridView.RowHeadersWidth = 40;
            this.freeRpoDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.freeRpoDataGridView.RowTemplate.Height = 40;
            this.freeRpoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.freeRpoDataGridView.Size = new System.Drawing.Size(786, 206);
            this.freeRpoDataGridView.TabIndex = 6;
            this.freeRpoDataGridView.TabStop = false;
            // 
            // panelFreeRpo
            // 
            this.panelFreeRpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.panelFreeRpo.Controls.Add(this.btnLoadFreeRpo);
            this.panelFreeRpo.Controls.Add(this.flowLayoutPanelFreeRpo);
            this.panelFreeRpo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFreeRpo.Location = new System.Drawing.Point(3, 3);
            this.panelFreeRpo.Name = "panelFreeRpo";
            this.panelFreeRpo.Size = new System.Drawing.Size(786, 48);
            this.panelFreeRpo.TabIndex = 5;
            // 
            // btnLoadFreeRpo
            // 
            this.btnLoadFreeRpo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFreeRpo.BackColor = System.Drawing.Color.Crimson;
            this.btnLoadFreeRpo.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadFreeRpo.BorderRadius = 6F;
            this.btnLoadFreeRpo.BorderSize = 0;
            this.btnLoadFreeRpo.DisableBackColor = System.Drawing.Color.DimGray;
            this.btnLoadFreeRpo.DisableBorderColor = System.Drawing.Color.Silver;
            this.btnLoadFreeRpo.FlatAppearance.BorderSize = 0;
            this.btnLoadFreeRpo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLoadFreeRpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFreeRpo.ForeColor = System.Drawing.Color.White;
            this.btnLoadFreeRpo.Image = global::DwUtils.Properties.Resources.synchronize_24;
            this.btnLoadFreeRpo.Location = new System.Drawing.Point(738, 4);
            this.btnLoadFreeRpo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnLoadFreeRpo.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnLoadFreeRpo.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLoadFreeRpo.Name = "btnLoadFreeRpo";
            this.btnLoadFreeRpo.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnLoadFreeRpo.Size = new System.Drawing.Size(40, 40);
            this.btnLoadFreeRpo.TabIndex = 0;
            this.btnLoadFreeRpo.TextColor = System.Drawing.Color.White;
            this.btnLoadFreeRpo.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelFreeRpo
            // 
            this.flowLayoutPanelFreeRpo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelFreeRpo.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanelFreeRpo.Name = "flowLayoutPanelFreeRpo";
            this.flowLayoutPanelFreeRpo.Size = new System.Drawing.Size(729, 40);
            this.flowLayoutPanelFreeRpo.TabIndex = 27;
            this.flowLayoutPanelFreeRpo.WrapContents = false;
            // 
            // barcodePanelStat
            // 
            this.barcodePanelStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(58)))));
            this.barcodePanelStat.Controls.Add(this.flowLayoutPanelFreeRpoStat);
            this.barcodePanelStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barcodePanelStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.barcodePanelStat.Location = new System.Drawing.Point(3, 257);
            this.barcodePanelStat.Name = "barcodePanelStat";
            this.barcodePanelStat.Size = new System.Drawing.Size(786, 30);
            this.barcodePanelStat.TabIndex = 7;
            // 
            // flowLayoutPanelFreeRpoStat
            // 
            this.flowLayoutPanelFreeRpoStat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelFreeRpoStat.Controls.Add(this.freeRpoLabelInfoCount);
            this.flowLayoutPanelFreeRpoStat.Controls.Add(this.freeRpoLabelCount);
            this.flowLayoutPanelFreeRpoStat.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanelFreeRpoStat.Name = "flowLayoutPanelFreeRpoStat";
            this.flowLayoutPanelFreeRpoStat.Size = new System.Drawing.Size(783, 26);
            this.flowLayoutPanelFreeRpoStat.TabIndex = 1;
            this.flowLayoutPanelFreeRpoStat.WrapContents = false;
            // 
            // freeRpoLabelInfoCount
            // 
            this.freeRpoLabelInfoCount.AutoSize = true;
            this.freeRpoLabelInfoCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeRpoLabelInfoCount.Location = new System.Drawing.Point(8, 2);
            this.freeRpoLabelInfoCount.Margin = new System.Windows.Forms.Padding(8, 2, 3, 0);
            this.freeRpoLabelInfoCount.Name = "freeRpoLabelInfoCount";
            this.freeRpoLabelInfoCount.Size = new System.Drawing.Size(52, 20);
            this.freeRpoLabelInfoCount.TabIndex = 0;
            this.freeRpoLabelInfoCount.Text = "Всего:";
            // 
            // freeRpoLabelCount
            // 
            this.freeRpoLabelCount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeRpoLabelCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.freeRpoLabelCount.Location = new System.Drawing.Point(66, 2);
            this.freeRpoLabelCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.freeRpoLabelCount.Name = "freeRpoLabelCount";
            this.freeRpoLabelCount.Size = new System.Drawing.Size(90, 22);
            this.freeRpoLabelCount.TabIndex = 0;
            this.freeRpoLabelCount.Text = "0";
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DWUtils: GeneralForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabFreeRpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.freeRpoDataGridView)).EndInit();
            this.panelFreeRpo.ResumeLayout(false);
            this.barcodePanelStat.ResumeLayout(false);
            this.flowLayoutPanelFreeRpoStat.ResumeLayout(false);
            this.flowLayoutPanelFreeRpoStat.PerformLayout();
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
        private Wc32Api.Widgets.WcToggleButton toggleLoadLk;
        private System.Windows.Forms.Label labelInfoLoadLk;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabFreeRpo;
        private System.Windows.Forms.DataGridView freeRpoDataGridView;
        private System.Windows.Forms.Panel panelFreeRpo;
        private Wc32Api.Widgets.WcButton btnLoadFreeRpo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFreeRpo;
        private System.Windows.Forms.Panel barcodePanelStat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFreeRpoStat;
        private System.Windows.Forms.Label freeRpoLabelInfoCount;
        private System.Windows.Forms.Label freeRpoLabelCount;
        private System.Windows.Forms.ToolStripMenuItem connectPostUnitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectPostItemMenuItem;
    }
}

