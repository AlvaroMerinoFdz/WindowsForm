
namespace Agencia_de_Viajes
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.stsBarraInferior = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBarraProgeso = new System.Windows.Forms.ToolStripProgressBar();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenu1 = new System.Windows.Forms.MenuStrip();
            this.acuerdoEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.lstbDestino = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nupdPersonas = new System.Windows.Forms.NumericUpDown();
            this.nupdEstrellas = new System.Windows.Forms.NumericUpDown();
            this.imgListDestino = new System.Windows.Forms.ImageList(this.components);
            this.gpbEstancia = new System.Windows.Forms.GroupBox();
            this.rdbCompleta = new System.Windows.Forms.RadioButton();
            this.rdbMedia = new System.Windows.Forms.RadioButton();
            this.rdbDormir = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mntclndFechas = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtValidar = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tmrBarra = new System.Windows.Forms.Timer(this.components);
            this.stsBarraInferior.SuspendLayout();
            this.msMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdEstrellas)).BeginInit();
            this.gpbEstancia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // stsBarraInferior
            // 
            this.stsBarraInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsBarraProgeso,
            this.lblHora});
            this.stsBarraInferior.Location = new System.Drawing.Point(0, 629);
            this.stsBarraInferior.Name = "stsBarraInferior";
            this.stsBarraInferior.Size = new System.Drawing.Size(838, 22);
            this.stsBarraInferior.TabIndex = 1;
            this.stsBarraInferior.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(181, 17);
            this.toolStripStatusLabel1.Text = "viajeconnosotros@gmail.com";
            this.toolStripStatusLabel1.ToolTipText = "Email de Contacto";
            // 
            // tsBarraProgeso
            // 
            this.tsBarraProgeso.Name = "tsBarraProgeso";
            this.tsBarraProgeso.Size = new System.Drawing.Size(100, 16);
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Image = ((System.Drawing.Image)(resources.GetObject("lblHora.Image")));
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(49, 17);
            this.lblHora.Text = "Hora";
            // 
            // msMenu1
            // 
            this.msMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acuerdoEmpresaToolStripMenuItem,
            this.preciosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.msMenu1.Location = new System.Drawing.Point(0, 0);
            this.msMenu1.Name = "msMenu1";
            this.msMenu1.Size = new System.Drawing.Size(838, 24);
            this.msMenu1.TabIndex = 2;
            this.msMenu1.Text = "menuStrip1";
            // 
            // acuerdoEmpresaToolStripMenuItem
            // 
            this.acuerdoEmpresaToolStripMenuItem.Name = "acuerdoEmpresaToolStripMenuItem";
            this.acuerdoEmpresaToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.acuerdoEmpresaToolStripMenuItem.Text = "Acuerdo Empresa";
            this.acuerdoEmpresaToolStripMenuItem.Click += new System.EventHandler(this.acuerdoEmpresaToolStripMenuItem_Click);
            // 
            // preciosToolStripMenuItem
            // 
            this.preciosToolStripMenuItem.Name = "preciosToolStripMenuItem";
            this.preciosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.preciosToolStripMenuItem.Text = "Precios";
            this.preciosToolStripMenuItem.Click += new System.EventHandler(this.preciosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pcbImagen
            // 
            this.pcbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pcbImagen.Image")));
            this.pcbImagen.Location = new System.Drawing.Point(5, 59);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(207, 167);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen.TabIndex = 3;
            this.pcbImagen.TabStop = false;
            // 
            // lstbDestino
            // 
            this.lstbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbDestino.FormattingEnabled = true;
            this.lstbDestino.ItemHeight = 18;
            this.lstbDestino.Items.AddRange(new object[] {
            "Ciudad",
            "Playa",
            "Montaña",
            "Tour"});
            this.lstbDestino.Location = new System.Drawing.Point(265, 77);
            this.lstbDestino.Name = "lstbDestino";
            this.lstbDestino.Size = new System.Drawing.Size(127, 94);
            this.lstbDestino.TabIndex = 4;
            this.lstbDestino.SelectedIndexChanged += new System.EventHandler(this.lstbDestino_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Elige un destino: ";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Cena y Espectáculo",
            "Excursiones",
            "Lavandería",
            "NaturAventura",
            "Spa"});
            this.checkedListBox1.Location = new System.Drawing.Point(563, 77);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(202, 94);
            this.checkedListBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 58);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Actividades Extras: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Personas ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(612, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estrellas del hotel";
            // 
            // nupdPersonas
            // 
            this.nupdPersonas.Location = new System.Drawing.Point(563, 216);
            this.nupdPersonas.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupdPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdPersonas.Name = "nupdPersonas";
            this.nupdPersonas.Size = new System.Drawing.Size(33, 20);
            this.nupdPersonas.TabIndex = 10;
            this.nupdPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupdEstrellas
            // 
            this.nupdEstrellas.Location = new System.Drawing.Point(563, 259);
            this.nupdEstrellas.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupdEstrellas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdEstrellas.Name = "nupdEstrellas";
            this.nupdEstrellas.Size = new System.Drawing.Size(33, 20);
            this.nupdEstrellas.TabIndex = 11;
            this.nupdEstrellas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // imgListDestino
            // 
            this.imgListDestino.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListDestino.ImageStream")));
            this.imgListDestino.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListDestino.Images.SetKeyName(0, "ciudad.jpg");
            this.imgListDestino.Images.SetKeyName(1, "playa.jpeg");
            this.imgListDestino.Images.SetKeyName(2, "montaña.jpg");
            this.imgListDestino.Images.SetKeyName(3, "tour.jpg");
            // 
            // gpbEstancia
            // 
            this.gpbEstancia.Controls.Add(this.rdbCompleta);
            this.gpbEstancia.Controls.Add(this.rdbMedia);
            this.gpbEstancia.Controls.Add(this.rdbDormir);
            this.gpbEstancia.Location = new System.Drawing.Point(12, 259);
            this.gpbEstancia.Name = "gpbEstancia";
            this.gpbEstancia.Size = new System.Drawing.Size(200, 100);
            this.gpbEstancia.TabIndex = 12;
            this.gpbEstancia.TabStop = false;
            this.gpbEstancia.Text = "Tipo de Estancia";
            // 
            // rdbCompleta
            // 
            this.rdbCompleta.AutoSize = true;
            this.rdbCompleta.Location = new System.Drawing.Point(14, 65);
            this.rdbCompleta.Name = "rdbCompleta";
            this.rdbCompleta.Size = new System.Drawing.Size(110, 17);
            this.rdbCompleta.TabIndex = 2;
            this.rdbCompleta.Text = "Pensión Completa";
            this.rdbCompleta.UseVisualStyleBackColor = true;
            // 
            // rdbMedia
            // 
            this.rdbMedia.AutoSize = true;
            this.rdbMedia.Location = new System.Drawing.Point(14, 42);
            this.rdbMedia.Name = "rdbMedia";
            this.rdbMedia.Size = new System.Drawing.Size(95, 17);
            this.rdbMedia.TabIndex = 1;
            this.rdbMedia.Text = "Media Pensión";
            this.rdbMedia.UseVisualStyleBackColor = true;
            // 
            // rdbDormir
            // 
            this.rdbDormir.AutoSize = true;
            this.rdbDormir.Checked = true;
            this.rdbDormir.Location = new System.Drawing.Point(14, 19);
            this.rdbDormir.Name = "rdbDormir";
            this.rdbDormir.Size = new System.Drawing.Size(79, 17);
            this.rdbDormir.TabIndex = 0;
            this.rdbDormir.TabStop = true;
            this.rdbDormir.Text = "Solo Dormir";
            this.rdbDormir.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 407);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(200, 30);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha:";
            // 
            // mntclndFechas
            // 
            this.mntclndFechas.Location = new System.Drawing.Point(265, 216);
            this.mntclndFechas.Name = "mntclndFechas";
            this.mntclndFechas.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnValidar);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.txtValidar);
            this.panel1.Location = new System.Drawing.Point(268, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 236);
            this.panel1.TabIndex = 16;
            // 
            // btnValidar
            // 
            this.btnValidar.Enabled = false;
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(428, 199);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(30, 204);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // txtValidar
            // 
            this.txtValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidar.Location = new System.Drawing.Point(24, 17);
            this.txtValidar.Multiline = true;
            this.txtValidar.Name = "txtValidar";
            this.txtValidar.Size = new System.Drawing.Size(479, 176);
            this.txtValidar.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(838, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Acuerdo Empresa";
            this.toolStripButton1.Click += new System.EventHandler(this.acuerdoEmpresaToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Precios";
            this.toolStripButton2.Click += new System.EventHandler(this.preciosToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Salir";
            this.toolStripButton3.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(838, 651);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mntclndFechas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbEstancia);
            this.Controls.Add(this.nupdEstrellas);
            this.Controls.Add(this.nupdPersonas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbDestino);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.stsBarraInferior);
            this.Controls.Add(this.msMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agencia de Viajes IFP VdG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.stsBarraInferior.ResumeLayout(false);
            this.stsBarraInferior.PerformLayout();
            this.msMenu1.ResumeLayout(false);
            this.msMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdEstrellas)).EndInit();
            this.gpbEstancia.ResumeLayout(false);
            this.gpbEstancia.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.StatusStrip stsBarraInferior;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripProgressBar tsBarraProgeso;
        private System.Windows.Forms.MenuStrip msMenu1;
        private System.Windows.Forms.ToolStripMenuItem acuerdoEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.ListBox lstbDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupdPersonas;
        private System.Windows.Forms.NumericUpDown nupdEstrellas;
        private System.Windows.Forms.ImageList imgListDestino;
        private System.Windows.Forms.GroupBox gpbEstancia;
        private System.Windows.Forms.RadioButton rdbMedia;
        private System.Windows.Forms.RadioButton rdbDormir;
        private System.Windows.Forms.RadioButton rdbCompleta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar mntclndFechas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtValidar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Timer tmrBarra;
    }
}