namespace Kpo4381.nmv.Main
{
    partial class FrmMaterial
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
            this.txtBoxMaterial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxMaterial
            // 
            this.txtBoxMaterial.Location = new System.Drawing.Point(48, 45);
            this.txtBoxMaterial.Name = "txtBoxMaterial";
            this.txtBoxMaterial.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMaterial.TabIndex = 0;
            // 
            // FrmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtBoxMaterial);
            this.Name = "FrmMaterial";
            this.Text = "Материал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMaterial;
    }
}