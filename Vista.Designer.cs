namespace TelefericoSanBernardo
{
    partial class Vista
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista));
            this.logo = new System.Windows.Forms.PictureBox();
            this.PanelResultados = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelInternacionales = new System.Windows.Forms.Label();
            this.labelNacionales = new System.Windows.Forms.Label();
            this.labelProvinciales = new System.Windows.Forms.Label();
            this.labelAdultos = new System.Windows.Forms.Label();
            this.labelJovenes = new System.Windows.Forms.Label();
            this.labelMenores = new System.Windows.Forms.Label();
            this.labelTotalPersonas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonSimular = new System.Windows.Forms.Button();
            this.sourceSimulacion = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.PanelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceSimulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(440, 12);
            this.logo.Name = "logo";
            this.logo.Padding = new System.Windows.Forms.Padding(10);
            this.logo.Size = new System.Drawing.Size(360, 218);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // PanelResultados
            // 
            this.PanelResultados.BackColor = System.Drawing.Color.Black;
            this.PanelResultados.Controls.Add(this.label23);
            this.PanelResultados.Controls.Add(this.label22);
            this.PanelResultados.Controls.Add(this.label21);
            this.PanelResultados.Controls.Add(this.label20);
            this.PanelResultados.Controls.Add(this.labelInternacionales);
            this.PanelResultados.Controls.Add(this.labelNacionales);
            this.PanelResultados.Controls.Add(this.labelProvinciales);
            this.PanelResultados.Controls.Add(this.labelAdultos);
            this.PanelResultados.Controls.Add(this.labelJovenes);
            this.PanelResultados.Controls.Add(this.labelMenores);
            this.PanelResultados.Controls.Add(this.labelTotalPersonas);
            this.PanelResultados.Controls.Add(this.label12);
            this.PanelResultados.Controls.Add(this.label11);
            this.PanelResultados.Controls.Add(this.label10);
            this.PanelResultados.Controls.Add(this.label9);
            this.PanelResultados.Controls.Add(this.label8);
            this.PanelResultados.Controls.Add(this.label7);
            this.PanelResultados.Controls.Add(this.label6);
            this.PanelResultados.Controls.Add(this.label5);
            this.PanelResultados.Controls.Add(this.label4);
            this.PanelResultados.Controls.Add(this.label3);
            this.PanelResultados.Controls.Add(this.label2);
            this.PanelResultados.Controls.Add(this.label1);
            this.PanelResultados.Location = new System.Drawing.Point(12, 12);
            this.PanelResultados.Name = "PanelResultados";
            this.PanelResultados.Padding = new System.Windows.Forms.Padding(10);
            this.PanelResultados.Size = new System.Drawing.Size(370, 495);
            this.PanelResultados.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sourceSimulacion, "ingresoPicnic", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(123, 430);
            this.label23.Name = "label23";
            this.label23.Padding = new System.Windows.Forms.Padding(10);
            this.label23.Size = new System.Drawing.Size(38, 39);
            this.label23.TabIndex = 21;
            this.label23.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sourceSimulacion, "ingresoRegalos", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(164, 391);
            this.label22.Name = "label22";
            this.label22.Padding = new System.Windows.Forms.Padding(10);
            this.label22.Size = new System.Drawing.Size(38, 39);
            this.label22.TabIndex = 20;
            this.label22.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sourceSimulacion, "ingresoMascotas", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(153, 352);
            this.label21.Name = "label21";
            this.label21.Padding = new System.Windows.Forms.Padding(10);
            this.label21.Size = new System.Drawing.Size(38, 39);
            this.label21.TabIndex = 19;
            this.label21.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sourceSimulacion, "ingresoTeleferico", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C0"));
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(129, 313);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(10);
            this.label20.Size = new System.Drawing.Size(38, 39);
            this.label20.TabIndex = 18;
            this.label20.Text = "0";
            // 
            // labelInternacionales
            // 
            this.labelInternacionales.AutoSize = true;
            this.labelInternacionales.BackColor = System.Drawing.Color.Transparent;
            this.labelInternacionales.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sourceSimulacion, "internacionales", true));
            this.labelInternacionales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInternacionales.ForeColor = System.Drawing.Color.White;
            this.labelInternacionales.Location = new System.Drawing.Point(112, 274);
            this.labelInternacionales.Name = "labelInternacionales";
            this.labelInternacionales.Padding = new System.Windows.Forms.Padding(10);
            this.labelInternacionales.Size = new System.Drawing.Size(38, 39);
            this.labelInternacionales.TabIndex = 17;
            this.labelInternacionales.Text = "0";
            // 
            // labelNacionales
            // 
            this.labelNacionales.AutoSize = true;
            this.labelNacionales.BackColor = System.Drawing.Color.Transparent;
            this.labelNacionales.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sourceSimulacion, "nacionales", true));
            this.labelNacionales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNacionales.ForeColor = System.Drawing.Color.White;
            this.labelNacionales.Location = new System.Drawing.Point(85, 235);
            this.labelNacionales.Name = "labelNacionales";
            this.labelNacionales.Padding = new System.Windows.Forms.Padding(10);
            this.labelNacionales.Size = new System.Drawing.Size(38, 39);
            this.labelNacionales.TabIndex = 13;
            this.labelNacionales.Text = "0";
            // 
            // labelProvinciales
            // 
            this.labelProvinciales.AutoSize = true;
            this.labelProvinciales.BackColor = System.Drawing.Color.Transparent;
            this.labelProvinciales.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sourceSimulacion, "provinciales", true));
            this.labelProvinciales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProvinciales.ForeColor = System.Drawing.Color.White;
            this.labelProvinciales.Location = new System.Drawing.Point(96, 196);
            this.labelProvinciales.Name = "labelProvinciales";
            this.labelProvinciales.Padding = new System.Windows.Forms.Padding(10);
            this.labelProvinciales.Size = new System.Drawing.Size(38, 39);
            this.labelProvinciales.TabIndex = 16;
            this.labelProvinciales.Text = "0";
            // 
            // labelAdultos
            // 
            this.labelAdultos.AutoSize = true;
            this.labelAdultos.BackColor = System.Drawing.Color.Transparent;
            this.labelAdultos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sourceSimulacion, "adultos", true));
            this.labelAdultos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdultos.ForeColor = System.Drawing.Color.White;
            this.labelAdultos.Location = new System.Drawing.Point(72, 156);
            this.labelAdultos.Name = "labelAdultos";
            this.labelAdultos.Padding = new System.Windows.Forms.Padding(10);
            this.labelAdultos.Size = new System.Drawing.Size(38, 39);
            this.labelAdultos.TabIndex = 15;
            this.labelAdultos.Text = "0";
            // 
            // labelJovenes
            // 
            this.labelJovenes.AutoSize = true;
            this.labelJovenes.BackColor = System.Drawing.Color.Transparent;
            this.labelJovenes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sourceSimulacion, "jovenes", true));
            this.labelJovenes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJovenes.ForeColor = System.Drawing.Color.White;
            this.labelJovenes.Location = new System.Drawing.Point(72, 118);
            this.labelJovenes.Name = "labelJovenes";
            this.labelJovenes.Padding = new System.Windows.Forms.Padding(10);
            this.labelJovenes.Size = new System.Drawing.Size(38, 39);
            this.labelJovenes.TabIndex = 14;
            this.labelJovenes.Text = "0";
            // 
            // labelMenores
            // 
            this.labelMenores.AutoSize = true;
            this.labelMenores.BackColor = System.Drawing.Color.Transparent;
            this.labelMenores.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sourceSimulacion, "menores", true));
            this.labelMenores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenores.ForeColor = System.Drawing.Color.White;
            this.labelMenores.Location = new System.Drawing.Point(72, 79);
            this.labelMenores.Name = "labelMenores";
            this.labelMenores.Padding = new System.Windows.Forms.Padding(10);
            this.labelMenores.Size = new System.Drawing.Size(38, 39);
            this.labelMenores.TabIndex = 13;
            this.labelMenores.Text = "0";
            // 
            // labelTotalPersonas
            // 
            this.labelTotalPersonas.AutoSize = true;
            this.labelTotalPersonas.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPersonas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sourceSimulacion, "totalPersonas", true));
            this.labelTotalPersonas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPersonas.ForeColor = System.Drawing.Color.White;
            this.labelTotalPersonas.Location = new System.Drawing.Point(153, 39);
            this.labelTotalPersonas.Name = "labelTotalPersonas";
            this.labelTotalPersonas.Padding = new System.Windows.Forms.Padding(10);
            this.labelTotalPersonas.Size = new System.Drawing.Size(38, 39);
            this.labelTotalPersonas.TabIndex = 12;
            this.labelTotalPersonas.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 429);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(10);
            this.label12.Size = new System.Drawing.Size(135, 40);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ingresos PICNIC:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 390);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10);
            this.label11.Size = new System.Drawing.Size(179, 40);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ingresos tienda regalos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 351);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(10);
            this.label10.Size = new System.Drawing.Size(168, 40);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ingreso por mascotas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 312);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10);
            this.label9.Size = new System.Drawing.Size(141, 40);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ingreso teleférico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 273);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10);
            this.label8.Size = new System.Drawing.Size(128, 40);
            this.label8.TabIndex = 7;
            this.label8.Text = "Internacionales:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 234);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10);
            this.label7.Size = new System.Drawing.Size(101, 40);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nacionales:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 195);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10);
            this.label6.Size = new System.Drawing.Size(110, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Provinciales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 156);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10);
            this.label5.Size = new System.Drawing.Size(81, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adultos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 117);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(84, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jóvenes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 78);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(86, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(172, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de personas: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(326, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulación de la jornada (09:00 a 19:00)";
            // 
            // botonSimular
            // 
            this.botonSimular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonSimular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSimular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonSimular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSimular.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSimular.ForeColor = System.Drawing.Color.White;
            this.botonSimular.Location = new System.Drawing.Point(440, 464);
            this.botonSimular.Name = "botonSimular";
            this.botonSimular.Size = new System.Drawing.Size(360, 43);
            this.botonSimular.TabIndex = 2;
            this.botonSimular.Text = "Simular";
            this.botonSimular.UseVisualStyleBackColor = false;
            this.botonSimular.Click += new System.EventHandler(this.botonSimular_Click);
            // 
            // sourceSimulacion
            // 
            this.sourceSimulacion.DataSource = typeof(TelefericoSanBernardo.assets.Simulacion);
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 519);
            this.Controls.Add(this.botonSimular);
            this.Controls.Add(this.PanelResultados);
            this.Controls.Add(this.logo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Vista";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teleférico San Bernardo";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.PanelResultados.ResumeLayout(false);
            this.PanelResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceSimulacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel PanelResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelTotalPersonas;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelInternacionales;
        private System.Windows.Forms.Label labelNacionales;
        private System.Windows.Forms.Label labelProvinciales;
        private System.Windows.Forms.Label labelAdultos;
        private System.Windows.Forms.Label labelJovenes;
        private System.Windows.Forms.Label labelMenores;
        private System.Windows.Forms.BindingSource sourceSimulacion;
        private System.Windows.Forms.Button botonSimular;
    }
}

