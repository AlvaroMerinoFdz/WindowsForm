
namespace LecturaXML
{
    partial class frmTelefonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelefonos));
            this.rtbTelefonos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbTelefonos
            // 
            this.rtbTelefonos.Location = new System.Drawing.Point(12, 12);
            this.rtbTelefonos.Name = "rtbTelefonos";
            this.rtbTelefonos.ReadOnly = true;
            this.rtbTelefonos.Size = new System.Drawing.Size(249, 284);
            this.rtbTelefonos.TabIndex = 0;
            this.rtbTelefonos.Text = "";
            // 
            // frmTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(273, 308);
            this.Controls.Add(this.rtbTelefonos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelefonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefonos";
            this.Load += new System.EventHandler(this.frmTelefonos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTelefonos;
    }
}