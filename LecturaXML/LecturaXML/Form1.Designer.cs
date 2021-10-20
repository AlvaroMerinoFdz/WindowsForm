
namespace LecturaXML
{
    partial class FrmLecturaXML
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLecturaXML));
            this.btnLeerXML = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnTelefonos = new System.Windows.Forms.Button();
            this.btnFicheroGenerado = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.rtbEsquema = new System.Windows.Forms.RichTextBox();
            this.abrir = new System.Windows.Forms.OpenFileDialog();
            this.dsDatos = new System.Data.DataSet();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeerXML
            // 
            this.btnLeerXML.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLeerXML.FlatAppearance.BorderSize = 3;
            this.btnLeerXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerXML.Location = new System.Drawing.Point(41, 504);
            this.btnLeerXML.Name = "btnLeerXML";
            this.btnLeerXML.Size = new System.Drawing.Size(112, 40);
            this.btnLeerXML.TabIndex = 0;
            this.btnLeerXML.Text = "Leer XML";
            this.btnLeerXML.UseVisualStyleBackColor = true;
            this.btnLeerXML.Click += new System.EventHandler(this.btnLeerXML_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Enabled = false;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMostrar.FlatAppearance.BorderSize = 3;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(213, 504);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(105, 40);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Esquema";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnTelefonos
            // 
            this.btnTelefonos.Enabled = false;
            this.btnTelefonos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTelefonos.FlatAppearance.BorderSize = 3;
            this.btnTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelefonos.Location = new System.Drawing.Point(384, 504);
            this.btnTelefonos.Name = "btnTelefonos";
            this.btnTelefonos.Size = new System.Drawing.Size(100, 40);
            this.btnTelefonos.TabIndex = 2;
            this.btnTelefonos.Text = "Teléfonos";
            this.btnTelefonos.UseVisualStyleBackColor = true;
            this.btnTelefonos.Click += new System.EventHandler(this.btnTelefonos_Click);
            // 
            // btnFicheroGenerado
            // 
            this.btnFicheroGenerado.Enabled = false;
            this.btnFicheroGenerado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFicheroGenerado.FlatAppearance.BorderSize = 3;
            this.btnFicheroGenerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFicheroGenerado.Location = new System.Drawing.Point(561, 504);
            this.btnFicheroGenerado.Name = "btnFicheroGenerado";
            this.btnFicheroGenerado.Size = new System.Drawing.Size(109, 40);
            this.btnFicheroGenerado.TabIndex = 3;
            this.btnFicheroGenerado.Text = "Fichero Generado";
            this.btnFicheroGenerado.UseVisualStyleBackColor = true;
            this.btnFicheroGenerado.Click += new System.EventHandler(this.btnFicheroGenerado_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(741, 504);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(39, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(804, 200);
            this.dgvDatos.TabIndex = 5;
            // 
            // rtbEsquema
            // 
            this.rtbEsquema.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbEsquema.Location = new System.Drawing.Point(40, 218);
            this.rtbEsquema.Name = "rtbEsquema";
            this.rtbEsquema.Size = new System.Drawing.Size(803, 273);
            this.rtbEsquema.TabIndex = 6;
            this.rtbEsquema.Text = "";
            // 
            // abrir
            // 
            this.abrir.Filter = "Documentos XML (*.xml)|*.xml";
            // 
            // dsDatos
            // 
            this.dsDatos.DataSetName = "NewDataSet";
            // 
            // FrmLecturaXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(855, 556);
            this.Controls.Add(this.rtbEsquema);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnFicheroGenerado);
            this.Controls.Add(this.btnTelefonos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLeerXML);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLecturaXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lectura XML";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeerXML;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnTelefonos;
        private System.Windows.Forms.Button btnFicheroGenerado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.RichTextBox rtbEsquema;
        private System.Windows.Forms.OpenFileDialog abrir;
        private System.Data.DataSet dsDatos;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
    }
}

