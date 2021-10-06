
namespace Agencia_de_Viajes
{
    partial class frmPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrecios));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnVolver = new System.Windows.Forms.ToolStripButton();
            this.tcPrecios = new System.Windows.Forms.TabControl();
            this.tpDestinos = new System.Windows.Forms.TabPage();
            this.txtPersona = new System.Windows.Forms.MaskedTextBox();
            this.grbEstancia = new System.Windows.Forms.GroupBox();
            this.txtCompleta = new System.Windows.Forms.MaskedTextBox();
            this.txtMedia = new System.Windows.Forms.MaskedTextBox();
            this.txtDormir = new System.Windows.Forms.MaskedTextBox();
            this.lblCompleta = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblDormir = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCincoEstrella = new System.Windows.Forms.MaskedTextBox();
            this.txtCuatroEstrella = new System.Windows.Forms.MaskedTextBox();
            this.txtTresEstrella = new System.Windows.Forms.MaskedTextBox();
            this.txtDosEstrella = new System.Windows.Forms.MaskedTextBox();
            this.txtUnaEstrella = new System.Windows.Forms.MaskedTextBox();
            this.pcbCincoEstrella = new System.Windows.Forms.PictureBox();
            this.pcbCuatroEstrella = new System.Windows.Forms.PictureBox();
            this.pcbTresEstrella = new System.Windows.Forms.PictureBox();
            this.pcbDosEstrella = new System.Windows.Forms.PictureBox();
            this.pcbUnaEstrella = new System.Windows.Forms.PictureBox();
            this.grbDestinos = new System.Windows.Forms.GroupBox();
            this.txtTour = new System.Windows.Forms.MaskedTextBox();
            this.txtMontain = new System.Windows.Forms.MaskedTextBox();
            this.txtPlaya = new System.Windows.Forms.MaskedTextBox();
            this.txtCiudad = new System.Windows.Forms.MaskedTextBox();
            this.lblTour = new System.Windows.Forms.Label();
            this.lblMontain = new System.Windows.Forms.Label();
            this.lblPlaya = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.tpActividades = new System.Windows.Forms.TabPage();
            this.grbActividades = new System.Windows.Forms.GroupBox();
            this.txtCena = new System.Windows.Forms.MaskedTextBox();
            this.txtSpa = new System.Windows.Forms.MaskedTextBox();
            this.txtNaturAventura = new System.Windows.Forms.MaskedTextBox();
            this.txtLavanderia = new System.Windows.Forms.MaskedTextBox();
            this.txtExcursion = new System.Windows.Forms.MaskedTextBox();
            this.lblSpa = new System.Windows.Forms.Label();
            this.lblNaturAventura = new System.Windows.Forms.Label();
            this.lblLavanderia = new System.Windows.Forms.Label();
            this.lblExcursion = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.tpFechas = new System.Windows.Forms.TabPage();
            this.grbFechas = new System.Windows.Forms.GroupBox();
            this.txtBaja = new System.Windows.Forms.MaskedTextBox();
            this.txtMediaTem = new System.Windows.Forms.MaskedTextBox();
            this.txtAlta = new System.Windows.Forms.MaskedTextBox();
            this.lblBaja = new System.Windows.Forms.Label();
            this.lblMediaTem = new System.Windows.Forms.Label();
            this.lblAlta = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            this.tcPrecios.SuspendLayout();
            this.tpDestinos.SuspendLayout();
            this.grbEstancia.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCincoEstrella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCuatroEstrella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTresEstrella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDosEstrella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUnaEstrella)).BeginInit();
            this.grbDestinos.SuspendLayout();
            this.tpActividades.SuspendLayout();
            this.grbActividades.SuspendLayout();
            this.tpFechas.SuspendLayout();
            this.grbFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnVolver});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(800, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbtnVolver
            // 
            this.tsbtnVolver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnVolver.Image")));
            this.tsbtnVolver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnVolver.Name = "tsbtnVolver";
            this.tsbtnVolver.Size = new System.Drawing.Size(23, 22);
            this.tsbtnVolver.Text = "toolStripButton1";
            this.tsbtnVolver.Click += new System.EventHandler(this.tsbtnVolver_Click);
            // 
            // tcPrecios
            // 
            this.tcPrecios.Controls.Add(this.tpDestinos);
            this.tcPrecios.Controls.Add(this.tpActividades);
            this.tcPrecios.Controls.Add(this.tpFechas);
            this.tcPrecios.Location = new System.Drawing.Point(0, 28);
            this.tcPrecios.Name = "tcPrecios";
            this.tcPrecios.SelectedIndex = 0;
            this.tcPrecios.Size = new System.Drawing.Size(800, 420);
            this.tcPrecios.TabIndex = 1;
            // 
            // tpDestinos
            // 
            this.tpDestinos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDestinos.BackgroundImage")));
            this.tpDestinos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpDestinos.Controls.Add(this.txtPersona);
            this.tpDestinos.Controls.Add(this.grbEstancia);
            this.tpDestinos.Controls.Add(this.lblPersona);
            this.tpDestinos.Controls.Add(this.groupBox1);
            this.tpDestinos.Controls.Add(this.grbDestinos);
            this.tpDestinos.Location = new System.Drawing.Point(4, 22);
            this.tpDestinos.Name = "tpDestinos";
            this.tpDestinos.Padding = new System.Windows.Forms.Padding(3);
            this.tpDestinos.Size = new System.Drawing.Size(792, 394);
            this.tpDestinos.TabIndex = 0;
            this.tpDestinos.Text = "Destinos";
            this.tpDestinos.UseVisualStyleBackColor = true;
            // 
            // txtPersona
            // 
            this.txtPersona.Location = new System.Drawing.Point(597, 300);
            this.txtPersona.Mask = "00";
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(98, 20);
            this.txtPersona.TabIndex = 16;
            this.txtPersona.Text = "20";
            this.txtPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grbEstancia
            // 
            this.grbEstancia.BackColor = System.Drawing.Color.White;
            this.grbEstancia.Controls.Add(this.txtCompleta);
            this.grbEstancia.Controls.Add(this.txtMedia);
            this.grbEstancia.Controls.Add(this.txtDormir);
            this.grbEstancia.Controls.Add(this.lblCompleta);
            this.grbEstancia.Controls.Add(this.lblMedia);
            this.grbEstancia.Controls.Add(this.lblDormir);
            this.grbEstancia.Location = new System.Drawing.Point(33, 224);
            this.grbEstancia.Name = "grbEstancia";
            this.grbEstancia.Size = new System.Drawing.Size(271, 144);
            this.grbEstancia.TabIndex = 15;
            this.grbEstancia.TabStop = false;
            this.grbEstancia.Text = "Tipo de estancia";
            // 
            // txtCompleta
            // 
            this.txtCompleta.Location = new System.Drawing.Point(111, 96);
            this.txtCompleta.Mask = "00";
            this.txtCompleta.Name = "txtCompleta";
            this.txtCompleta.Size = new System.Drawing.Size(141, 20);
            this.txtCompleta.TabIndex = 12;
            this.txtCompleta.Text = "60";
            this.txtCompleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(111, 64);
            this.txtMedia.Mask = "00";
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(141, 20);
            this.txtMedia.TabIndex = 11;
            this.txtMedia.Text = "30";
            this.txtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDormir
            // 
            this.txtDormir.Location = new System.Drawing.Point(111, 29);
            this.txtDormir.Mask = "00";
            this.txtDormir.Name = "txtDormir";
            this.txtDormir.Size = new System.Drawing.Size(141, 20);
            this.txtDormir.TabIndex = 10;
            this.txtDormir.Text = "20";
            this.txtDormir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCompleta
            // 
            this.lblCompleta.AutoSize = true;
            this.lblCompleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleta.Location = new System.Drawing.Point(19, 103);
            this.lblCompleta.Name = "lblCompleta";
            this.lblCompleta.Size = new System.Drawing.Size(59, 13);
            this.lblCompleta.TabIndex = 2;
            this.lblCompleta.Text = "Completa";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(19, 67);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(41, 13);
            this.lblMedia.TabIndex = 1;
            this.lblMedia.Text = "Media";
            // 
            // lblDormir
            // 
            this.lblDormir.AutoSize = true;
            this.lblDormir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDormir.Location = new System.Drawing.Point(19, 32);
            this.lblDormir.Name = "lblDormir";
            this.lblDormir.Size = new System.Drawing.Size(43, 13);
            this.lblDormir.TabIndex = 0;
            this.lblDormir.Text = "Dormir";
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.BackColor = System.Drawing.Color.White;
            this.lblPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.Location = new System.Drawing.Point(516, 303);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(75, 13);
            this.lblPersona.TabIndex = 13;
            this.lblPersona.Text = "Por persona";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtCincoEstrella);
            this.groupBox1.Controls.Add(this.txtCuatroEstrella);
            this.groupBox1.Controls.Add(this.txtTresEstrella);
            this.groupBox1.Controls.Add(this.txtDosEstrella);
            this.groupBox1.Controls.Add(this.txtUnaEstrella);
            this.groupBox1.Controls.Add(this.pcbCincoEstrella);
            this.groupBox1.Controls.Add(this.pcbCuatroEstrella);
            this.groupBox1.Controls.Add(this.pcbTresEstrella);
            this.groupBox1.Controls.Add(this.pcbDosEstrella);
            this.groupBox1.Controls.Add(this.pcbUnaEstrella);
            this.groupBox1.Location = new System.Drawing.Point(452, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 231);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estrellas";
            // 
            // txtCincoEstrella
            // 
            this.txtCincoEstrella.Location = new System.Drawing.Point(145, 183);
            this.txtCincoEstrella.Mask = "00";
            this.txtCincoEstrella.Name = "txtCincoEstrella";
            this.txtCincoEstrella.Size = new System.Drawing.Size(141, 20);
            this.txtCincoEstrella.TabIndex = 15;
            this.txtCincoEstrella.Text = "80";
            this.txtCincoEstrella.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCuatroEstrella
            // 
            this.txtCuatroEstrella.Location = new System.Drawing.Point(145, 144);
            this.txtCuatroEstrella.Mask = "00";
            this.txtCuatroEstrella.Name = "txtCuatroEstrella";
            this.txtCuatroEstrella.Size = new System.Drawing.Size(141, 20);
            this.txtCuatroEstrella.TabIndex = 14;
            this.txtCuatroEstrella.Text = "60";
            this.txtCuatroEstrella.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTresEstrella
            // 
            this.txtTresEstrella.Location = new System.Drawing.Point(145, 110);
            this.txtTresEstrella.Mask = "00";
            this.txtTresEstrella.Name = "txtTresEstrella";
            this.txtTresEstrella.Size = new System.Drawing.Size(141, 20);
            this.txtTresEstrella.TabIndex = 13;
            this.txtTresEstrella.Text = "40";
            this.txtTresEstrella.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDosEstrella
            // 
            this.txtDosEstrella.Location = new System.Drawing.Point(145, 68);
            this.txtDosEstrella.Mask = "00";
            this.txtDosEstrella.Name = "txtDosEstrella";
            this.txtDosEstrella.Size = new System.Drawing.Size(141, 20);
            this.txtDosEstrella.TabIndex = 12;
            this.txtDosEstrella.Text = "30";
            this.txtDosEstrella.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUnaEstrella
            // 
            this.txtUnaEstrella.Location = new System.Drawing.Point(145, 31);
            this.txtUnaEstrella.Mask = "00";
            this.txtUnaEstrella.Name = "txtUnaEstrella";
            this.txtUnaEstrella.Size = new System.Drawing.Size(141, 20);
            this.txtUnaEstrella.TabIndex = 11;
            this.txtUnaEstrella.Text = "20";
            this.txtUnaEstrella.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pcbCincoEstrella
            // 
            this.pcbCincoEstrella.Image = ((System.Drawing.Image)(resources.GetObject("pcbCincoEstrella.Image")));
            this.pcbCincoEstrella.Location = new System.Drawing.Point(18, 183);
            this.pcbCincoEstrella.Name = "pcbCincoEstrella";
            this.pcbCincoEstrella.Size = new System.Drawing.Size(121, 22);
            this.pcbCincoEstrella.TabIndex = 4;
            this.pcbCincoEstrella.TabStop = false;
            // 
            // pcbCuatroEstrella
            // 
            this.pcbCuatroEstrella.Image = ((System.Drawing.Image)(resources.GetObject("pcbCuatroEstrella.Image")));
            this.pcbCuatroEstrella.Location = new System.Drawing.Point(18, 142);
            this.pcbCuatroEstrella.Name = "pcbCuatroEstrella";
            this.pcbCuatroEstrella.Size = new System.Drawing.Size(121, 22);
            this.pcbCuatroEstrella.TabIndex = 3;
            this.pcbCuatroEstrella.TabStop = false;
            // 
            // pcbTresEstrella
            // 
            this.pcbTresEstrella.Image = ((System.Drawing.Image)(resources.GetObject("pcbTresEstrella.Image")));
            this.pcbTresEstrella.Location = new System.Drawing.Point(18, 108);
            this.pcbTresEstrella.Name = "pcbTresEstrella";
            this.pcbTresEstrella.Size = new System.Drawing.Size(121, 22);
            this.pcbTresEstrella.TabIndex = 2;
            this.pcbTresEstrella.TabStop = false;
            // 
            // pcbDosEstrella
            // 
            this.pcbDosEstrella.Image = ((System.Drawing.Image)(resources.GetObject("pcbDosEstrella.Image")));
            this.pcbDosEstrella.Location = new System.Drawing.Point(18, 68);
            this.pcbDosEstrella.Name = "pcbDosEstrella";
            this.pcbDosEstrella.Size = new System.Drawing.Size(121, 22);
            this.pcbDosEstrella.TabIndex = 1;
            this.pcbDosEstrella.TabStop = false;
            // 
            // pcbUnaEstrella
            // 
            this.pcbUnaEstrella.Image = ((System.Drawing.Image)(resources.GetObject("pcbUnaEstrella.Image")));
            this.pcbUnaEstrella.Location = new System.Drawing.Point(18, 31);
            this.pcbUnaEstrella.Name = "pcbUnaEstrella";
            this.pcbUnaEstrella.Size = new System.Drawing.Size(121, 22);
            this.pcbUnaEstrella.TabIndex = 0;
            this.pcbUnaEstrella.TabStop = false;
            // 
            // grbDestinos
            // 
            this.grbDestinos.BackColor = System.Drawing.Color.White;
            this.grbDestinos.Controls.Add(this.txtTour);
            this.grbDestinos.Controls.Add(this.txtMontain);
            this.grbDestinos.Controls.Add(this.txtPlaya);
            this.grbDestinos.Controls.Add(this.txtCiudad);
            this.grbDestinos.Controls.Add(this.lblTour);
            this.grbDestinos.Controls.Add(this.lblMontain);
            this.grbDestinos.Controls.Add(this.lblPlaya);
            this.grbDestinos.Controls.Add(this.lblCiudad);
            this.grbDestinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDestinos.Location = new System.Drawing.Point(33, 27);
            this.grbDestinos.Name = "grbDestinos";
            this.grbDestinos.Size = new System.Drawing.Size(271, 174);
            this.grbDestinos.TabIndex = 2;
            this.grbDestinos.TabStop = false;
            this.grbDestinos.Text = "Destinos";
            // 
            // txtTour
            // 
            this.txtTour.Location = new System.Drawing.Point(111, 139);
            this.txtTour.Mask = "000";
            this.txtTour.Name = "txtTour";
            this.txtTour.Size = new System.Drawing.Size(141, 20);
            this.txtTour.TabIndex = 12;
            this.txtTour.Text = "200";
            this.txtTour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMontain
            // 
            this.txtMontain.Location = new System.Drawing.Point(111, 101);
            this.txtMontain.Mask = "000";
            this.txtMontain.Name = "txtMontain";
            this.txtMontain.Size = new System.Drawing.Size(141, 20);
            this.txtMontain.TabIndex = 11;
            this.txtMontain.Text = "400";
            this.txtMontain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPlaya
            // 
            this.txtPlaya.Location = new System.Drawing.Point(111, 65);
            this.txtPlaya.Mask = "000";
            this.txtPlaya.Name = "txtPlaya";
            this.txtPlaya.Size = new System.Drawing.Size(141, 20);
            this.txtPlaya.TabIndex = 10;
            this.txtPlaya.Text = "300";
            this.txtPlaya.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(111, 28);
            this.txtCiudad.Mask = "000";
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(141, 20);
            this.txtCiudad.TabIndex = 9;
            this.txtCiudad.Text = "200";
            this.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTour.Location = new System.Drawing.Point(19, 142);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(33, 13);
            this.lblTour.TabIndex = 3;
            this.lblTour.Text = "Tour";
            // 
            // lblMontain
            // 
            this.lblMontain.AutoSize = true;
            this.lblMontain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontain.Location = new System.Drawing.Point(19, 108);
            this.lblMontain.Name = "lblMontain";
            this.lblMontain.Size = new System.Drawing.Size(56, 13);
            this.lblMontain.TabIndex = 2;
            this.lblMontain.Text = "Montaña";
            // 
            // lblPlaya
            // 
            this.lblPlaya.AutoSize = true;
            this.lblPlaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaya.Location = new System.Drawing.Point(19, 68);
            this.lblPlaya.Name = "lblPlaya";
            this.lblPlaya.Size = new System.Drawing.Size(38, 13);
            this.lblPlaya.TabIndex = 1;
            this.lblPlaya.Text = "Playa";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(19, 31);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(46, 13);
            this.lblCiudad.TabIndex = 0;
            this.lblCiudad.Text = "Ciudad";
            // 
            // tpActividades
            // 
            this.tpActividades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpActividades.BackgroundImage")));
            this.tpActividades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpActividades.Controls.Add(this.grbActividades);
            this.tpActividades.Location = new System.Drawing.Point(4, 22);
            this.tpActividades.Name = "tpActividades";
            this.tpActividades.Padding = new System.Windows.Forms.Padding(3);
            this.tpActividades.Size = new System.Drawing.Size(792, 394);
            this.tpActividades.TabIndex = 1;
            this.tpActividades.Text = "Actividades";
            this.tpActividades.UseVisualStyleBackColor = true;
            // 
            // grbActividades
            // 
            this.grbActividades.BackColor = System.Drawing.Color.White;
            this.grbActividades.Controls.Add(this.txtCena);
            this.grbActividades.Controls.Add(this.txtSpa);
            this.grbActividades.Controls.Add(this.txtNaturAventura);
            this.grbActividades.Controls.Add(this.txtLavanderia);
            this.grbActividades.Controls.Add(this.txtExcursion);
            this.grbActividades.Controls.Add(this.lblSpa);
            this.grbActividades.Controls.Add(this.lblNaturAventura);
            this.grbActividades.Controls.Add(this.lblLavanderia);
            this.grbActividades.Controls.Add(this.lblExcursion);
            this.grbActividades.Controls.Add(this.lblCena);
            this.grbActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbActividades.Location = new System.Drawing.Point(257, 55);
            this.grbActividades.Name = "grbActividades";
            this.grbActividades.Size = new System.Drawing.Size(334, 285);
            this.grbActividades.TabIndex = 1;
            this.grbActividades.TabStop = false;
            this.grbActividades.Text = "Actividades";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(159, 51);
            this.txtCena.Mask = "00";
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(133, 20);
            this.txtCena.TabIndex = 21;
            this.txtCena.Text = "50";
            this.txtCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSpa
            // 
            this.txtSpa.Location = new System.Drawing.Point(159, 240);
            this.txtSpa.Mask = "00";
            this.txtSpa.Name = "txtSpa";
            this.txtSpa.Size = new System.Drawing.Size(133, 20);
            this.txtSpa.TabIndex = 20;
            this.txtSpa.Text = "40";
            this.txtSpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNaturAventura
            // 
            this.txtNaturAventura.Location = new System.Drawing.Point(159, 194);
            this.txtNaturAventura.Mask = "00";
            this.txtNaturAventura.Name = "txtNaturAventura";
            this.txtNaturAventura.Size = new System.Drawing.Size(133, 20);
            this.txtNaturAventura.TabIndex = 19;
            this.txtNaturAventura.Text = "60";
            this.txtNaturAventura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLavanderia
            // 
            this.txtLavanderia.Location = new System.Drawing.Point(159, 151);
            this.txtLavanderia.Mask = "00";
            this.txtLavanderia.Name = "txtLavanderia";
            this.txtLavanderia.Size = new System.Drawing.Size(133, 20);
            this.txtLavanderia.TabIndex = 18;
            this.txtLavanderia.Text = "15";
            this.txtLavanderia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtExcursion
            // 
            this.txtExcursion.Location = new System.Drawing.Point(159, 94);
            this.txtExcursion.Mask = "00";
            this.txtExcursion.Name = "txtExcursion";
            this.txtExcursion.Size = new System.Drawing.Size(133, 20);
            this.txtExcursion.TabIndex = 17;
            this.txtExcursion.Text = "60";
            this.txtExcursion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSpa
            // 
            this.lblSpa.AutoSize = true;
            this.lblSpa.Location = new System.Drawing.Point(32, 247);
            this.lblSpa.Name = "lblSpa";
            this.lblSpa.Size = new System.Drawing.Size(26, 13);
            this.lblSpa.TabIndex = 5;
            this.lblSpa.Text = "Spa";
            // 
            // lblNaturAventura
            // 
            this.lblNaturAventura.AutoSize = true;
            this.lblNaturAventura.Location = new System.Drawing.Point(32, 201);
            this.lblNaturAventura.Name = "lblNaturAventura";
            this.lblNaturAventura.Size = new System.Drawing.Size(76, 13);
            this.lblNaturAventura.TabIndex = 4;
            this.lblNaturAventura.Text = "NaturAventura";
            // 
            // lblLavanderia
            // 
            this.lblLavanderia.AutoSize = true;
            this.lblLavanderia.Location = new System.Drawing.Point(32, 154);
            this.lblLavanderia.Name = "lblLavanderia";
            this.lblLavanderia.Size = new System.Drawing.Size(62, 13);
            this.lblLavanderia.TabIndex = 3;
            this.lblLavanderia.Text = "Lavandería";
            // 
            // lblExcursion
            // 
            this.lblExcursion.AutoSize = true;
            this.lblExcursion.Location = new System.Drawing.Point(32, 94);
            this.lblExcursion.Name = "lblExcursion";
            this.lblExcursion.Size = new System.Drawing.Size(79, 26);
            this.lblExcursion.TabIndex = 2;
            this.lblExcursion.Text = "Excursión a \r\nsitios de interés";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(32, 45);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(78, 26);
            this.lblCena.TabIndex = 0;
            this.lblCena.Text = "Cena \r\ny espectáculos";
            // 
            // tpFechas
            // 
            this.tpFechas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpFechas.BackgroundImage")));
            this.tpFechas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpFechas.Controls.Add(this.grbFechas);
            this.tpFechas.Location = new System.Drawing.Point(4, 22);
            this.tpFechas.Name = "tpFechas";
            this.tpFechas.Padding = new System.Windows.Forms.Padding(3);
            this.tpFechas.Size = new System.Drawing.Size(792, 394);
            this.tpFechas.TabIndex = 2;
            this.tpFechas.Text = "Fechas";
            this.tpFechas.UseVisualStyleBackColor = true;
            // 
            // grbFechas
            // 
            this.grbFechas.BackColor = System.Drawing.Color.White;
            this.grbFechas.Controls.Add(this.txtBaja);
            this.grbFechas.Controls.Add(this.txtMediaTem);
            this.grbFechas.Controls.Add(this.txtAlta);
            this.grbFechas.Controls.Add(this.lblBaja);
            this.grbFechas.Controls.Add(this.lblMediaTem);
            this.grbFechas.Controls.Add(this.lblAlta);
            this.grbFechas.Location = new System.Drawing.Point(235, 101);
            this.grbFechas.Name = "grbFechas";
            this.grbFechas.Size = new System.Drawing.Size(324, 168);
            this.grbFechas.TabIndex = 1;
            this.grbFechas.TabStop = false;
            this.grbFechas.Text = "Por día según la temporada";
            // 
            // txtBaja
            // 
            this.txtBaja.Location = new System.Drawing.Point(156, 131);
            this.txtBaja.Mask = "00";
            this.txtBaja.Name = "txtBaja";
            this.txtBaja.Size = new System.Drawing.Size(133, 20);
            this.txtBaja.TabIndex = 25;
            this.txtBaja.Text = "10";
            this.txtBaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMediaTem
            // 
            this.txtMediaTem.Location = new System.Drawing.Point(156, 82);
            this.txtMediaTem.Mask = "00";
            this.txtMediaTem.Name = "txtMediaTem";
            this.txtMediaTem.Size = new System.Drawing.Size(133, 20);
            this.txtMediaTem.TabIndex = 24;
            this.txtMediaTem.Text = "30";
            this.txtMediaTem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAlta
            // 
            this.txtAlta.Location = new System.Drawing.Point(156, 39);
            this.txtAlta.Mask = "00";
            this.txtAlta.Name = "txtAlta";
            this.txtAlta.Size = new System.Drawing.Size(133, 20);
            this.txtAlta.TabIndex = 23;
            this.txtAlta.Text = "50";
            this.txtAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBaja
            // 
            this.lblBaja.AutoSize = true;
            this.lblBaja.Location = new System.Drawing.Point(34, 125);
            this.lblBaja.Name = "lblBaja";
            this.lblBaja.Size = new System.Drawing.Size(80, 26);
            this.lblBaja.TabIndex = 2;
            this.lblBaja.Text = "Baja\r\n(febrero a junio)";
            // 
            // lblMediaTem
            // 
            this.lblMediaTem.AutoSize = true;
            this.lblMediaTem.Location = new System.Drawing.Point(34, 76);
            this.lblMediaTem.Name = "lblMediaTem";
            this.lblMediaTem.Size = new System.Drawing.Size(103, 26);
            this.lblMediaTem.TabIndex = 1;
            this.lblMediaTem.Text = "Media\r\n(septiembre a enero)";
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Location = new System.Drawing.Point(34, 33);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(74, 26);
            this.lblAlta.TabIndex = 0;
            this.lblAlta.Text = "Alta\r\n(julio y agosto)";
            // 
            // frmPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcPrecios);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrecios";
            this.Shown += new System.EventHandler(this.frmPrecios_Shown);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.tcPrecios.ResumeLayout(false);
            this.tpDestinos.ResumeLayout(false);
            this.tpDestinos.PerformLayout();
            this.grbEstancia.ResumeLayout(false);
            this.grbEstancia.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCincoEstrella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCuatroEstrella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTresEstrella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDosEstrella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUnaEstrella)).EndInit();
            this.grbDestinos.ResumeLayout(false);
            this.grbDestinos.PerformLayout();
            this.tpActividades.ResumeLayout(false);
            this.grbActividades.ResumeLayout(false);
            this.grbActividades.PerformLayout();
            this.tpFechas.ResumeLayout(false);
            this.grbFechas.ResumeLayout(false);
            this.grbFechas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbtnVolver;
        private System.Windows.Forms.TabControl tcPrecios;
        private System.Windows.Forms.TabPage tpDestinos;
        private System.Windows.Forms.TabPage tpActividades;
        private System.Windows.Forms.TabPage tpFechas;
        private System.Windows.Forms.GroupBox grbDestinos;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.Label lblMontain;
        private System.Windows.Forms.Label lblPlaya;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.GroupBox grbEstancia;
        private System.Windows.Forms.Label lblCompleta;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblDormir;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbCincoEstrella;
        private System.Windows.Forms.PictureBox pcbCuatroEstrella;
        private System.Windows.Forms.PictureBox pcbTresEstrella;
        private System.Windows.Forms.PictureBox pcbDosEstrella;
        private System.Windows.Forms.PictureBox pcbUnaEstrella;
        private System.Windows.Forms.GroupBox grbActividades;
        private System.Windows.Forms.Label lblSpa;
        private System.Windows.Forms.Label lblNaturAventura;
        private System.Windows.Forms.Label lblLavanderia;
        private System.Windows.Forms.Label lblExcursion;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.GroupBox grbFechas;
        private System.Windows.Forms.Label lblBaja;
        private System.Windows.Forms.Label lblMediaTem;
        private System.Windows.Forms.Label lblAlta;
        private System.Windows.Forms.MaskedTextBox txtCiudad;
        private System.Windows.Forms.MaskedTextBox txtPlaya;
        private System.Windows.Forms.MaskedTextBox txtMontain;
        private System.Windows.Forms.MaskedTextBox txtTour;
        private System.Windows.Forms.MaskedTextBox txtMedia;
        private System.Windows.Forms.MaskedTextBox txtDormir;
        private System.Windows.Forms.MaskedTextBox txtCompleta;
        private System.Windows.Forms.MaskedTextBox txtDosEstrella;
        private System.Windows.Forms.MaskedTextBox txtUnaEstrella;
        private System.Windows.Forms.MaskedTextBox txtTresEstrella;
        private System.Windows.Forms.MaskedTextBox txtCuatroEstrella;
        private System.Windows.Forms.MaskedTextBox txtCincoEstrella;
        private System.Windows.Forms.MaskedTextBox txtPersona;
        private System.Windows.Forms.MaskedTextBox txtSpa;
        private System.Windows.Forms.MaskedTextBox txtNaturAventura;
        private System.Windows.Forms.MaskedTextBox txtLavanderia;
        private System.Windows.Forms.MaskedTextBox txtExcursion;
        private System.Windows.Forms.MaskedTextBox txtCena;
        private System.Windows.Forms.MaskedTextBox txtAlta;
        private System.Windows.Forms.MaskedTextBox txtBaja;
        private System.Windows.Forms.MaskedTextBox txtMediaTem;
    }
}