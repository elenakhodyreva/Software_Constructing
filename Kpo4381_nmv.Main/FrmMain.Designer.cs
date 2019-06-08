namespace Kpo4381_nmv.Main
{
    partial class Form1
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
            this.MMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMaterials = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.SStatus = new System.Windows.Forms.StatusStrip();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.tbLogPath = new System.Windows.Forms.TextBox();
            this.tbDataFileName = new System.Windows.Forms.TextBox();
            this.MMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // MMenu
            // 
            this.MMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmMaterials});
            this.MMenu.Location = new System.Drawing.Point(0, 0);
            this.MMenu.Name = "MMenu";
            this.MMenu.Size = new System.Drawing.Size(414, 24);
            this.MMenu.TabIndex = 0;
            this.MMenu.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit,
            this.mnOpen});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(57, 20);
            this.mmFile.Text = "1&.Файл";
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(121, 22);
            this.mnExit.Text = "Выход";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(121, 22);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // mmMaterials
            // 
            this.mmMaterials.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpenMaterial});
            this.mmMaterials.Name = "mmMaterials";
            this.mmMaterials.Size = new System.Drawing.Size(92, 20);
            this.mmMaterials.Text = "2&.Материалы";
            // 
            // mnOpenMaterial
            // 
            this.mnOpenMaterial.Name = "mnOpenMaterial";
            this.mnOpenMaterial.Size = new System.Drawing.Size(227, 22);
            this.mnOpenMaterial.Text = "Открыть данные материала";
            this.mnOpenMaterial.Click += new System.EventHandler(this.mnOpenMaterial_Click);
            // 
            // SStatus
            // 
            this.SStatus.Location = new System.Drawing.Point(0, 258);
            this.SStatus.Name = "SStatus";
            this.SStatus.Size = new System.Drawing.Size(414, 22);
            this.SStatus.TabIndex = 1;
            this.SStatus.Text = "statusStrip1";
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterials.Location = new System.Drawing.Point(13, 28);
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.Size = new System.Drawing.Size(240, 150);
            this.dgvMaterials.TabIndex = 2;
            // 
            // tbLogPath
            // 
            this.tbLogPath.Location = new System.Drawing.Point(13, 204);
            this.tbLogPath.Name = "tbLogPath";
            this.tbLogPath.Size = new System.Drawing.Size(100, 20);
            this.tbLogPath.TabIndex = 3;
            // 
            // tbDataFileName
            // 
            this.tbDataFileName.Location = new System.Drawing.Point(138, 204);
            this.tbDataFileName.Name = "tbDataFileName";
            this.tbDataFileName.Size = new System.Drawing.Size(100, 20);
            this.tbDataFileName.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 280);
            this.Controls.Add(this.tbDataFileName);
            this.Controls.Add(this.tbLogPath);
            this.Controls.Add(this.dgvMaterials);
            this.Controls.Add(this.SStatus);
            this.Controls.Add(this.MMenu);
            this.MainMenuStrip = this.MMenu;
            this.Name = "Form1";
            this.Text = "КПО:4381:Вдовичев";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MMenu.ResumeLayout(false);
            this.MMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.StatusStrip SStatus;
        private System.Windows.Forms.DataGridView dgvMaterials;
        private System.Windows.Forms.ToolStripMenuItem mmMaterials;
        private System.Windows.Forms.ToolStripMenuItem mnOpenMaterial;
        private System.Windows.Forms.TextBox tbLogPath;
        private System.Windows.Forms.TextBox tbDataFileName;
    }
}

