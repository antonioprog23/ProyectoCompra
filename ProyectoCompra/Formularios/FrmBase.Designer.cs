namespace ProyectoCompra.Formularios
{
    partial class FrmBase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogoMain = new System.Windows.Forms.Button();
            this.mnAlimentacion = new System.Windows.Forms.MenuStrip();
            this.alimentacion = new System.Windows.Forms.ToolStripMenuItem();
            this.lacteosmn = new System.Windows.Forms.ToolStripMenuItem();
            this.aceitesVinagresYSalsasmn = new System.Windows.Forms.ToolStripMenuItem();
            this.desayunomn = new System.Windows.Forms.ToolStripMenuItem();
            this.conservasmn = new System.Windows.Forms.ToolStripMenuItem();
            this.comiadsInternacionalesmn = new System.Windows.Forms.ToolStripMenuItem();
            this.nutriciónDeportivamn = new System.Windows.Forms.ToolStripMenuItem();
            this.frescos = new System.Windows.Forms.ToolStripMenuItem();
            this.frutasmn = new System.Windows.Forms.ToolStripMenuItem();
            this.quesosmn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCarne = new System.Windows.Forms.ToolStripMenuItem();
            this.charcuteriamn = new System.Windows.Forms.ToolStripMenuItem();
            this.pescadosMariscosYMoluscosmn = new System.Windows.Forms.ToolStripMenuItem();
            this.sushimn = new System.Windows.Forms.ToolStripMenuItem();
            this.friosYCongelados = new System.Windows.Forms.ToolStripMenuItem();
            this.congeladosmn = new System.Windows.Forms.ToolStripMenuItem();
            this.postresmn = new System.Windows.Forms.ToolStripMenuItem();
            this.pastelesmn = new System.Windows.Forms.ToolStripMenuItem();
            this.mantequillasmn = new System.Windows.Forms.ToolStripMenuItem();
            this.platosmn = new System.Windows.Forms.ToolStripMenuItem();
            this.masasmn = new System.Windows.Forms.ToolStripMenuItem();
            this.bebidas = new System.Windows.Forms.ToolStripMenuItem();
            this.zumosmn = new System.Windows.Forms.ToolStripMenuItem();
            this.sodamn = new System.Windows.Forms.ToolStripMenuItem();
            this.bebidasConAlcoholmn = new System.Windows.Forms.ToolStripMenuItem();
            this.champagnemn = new System.Windows.Forms.ToolStripMenuItem();
            this.bebidasEcologicasmn = new System.Windows.Forms.ToolStripMenuItem();
            this.bebidasSinAlcoholmn = new System.Windows.Forms.ToolStripMenuItem();
            this.drogueria = new System.Windows.Forms.ToolStripMenuItem();
            this.cuidadoPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.electrodomesticos = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnologia = new System.Windows.Forms.ToolStripMenuItem();
            this.hogar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.btnIdentificarse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.mnAlimentacion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogoMain);
            this.panel1.Controls.Add(this.mnAlimentacion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 100);
            this.panel1.TabIndex = 4;
            // 
            // btnLogoMain
            // 
            this.btnLogoMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogoMain.Image = global::ProyectoCompra.Properties.Resources.icon_logo;
            this.btnLogoMain.Location = new System.Drawing.Point(3, 7);
            this.btnLogoMain.Name = "btnLogoMain";
            this.btnLogoMain.Size = new System.Drawing.Size(86, 66);
            this.btnLogoMain.TabIndex = 5;
            this.btnLogoMain.UseVisualStyleBackColor = true;
            this.btnLogoMain.Click += new System.EventHandler(this.btnLogoMain_Click);
            // 
            // mnAlimentacion
            // 
            this.mnAlimentacion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mnAlimentacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mnAlimentacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mnAlimentacion.Font = new System.Drawing.Font("Arial Nova", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnAlimentacion.GripMargin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.mnAlimentacion.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.mnAlimentacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mnAlimentacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alimentacion,
            this.frescos,
            this.friosYCongelados,
            this.bebidas,
            this.drogueria,
            this.cuidadoPersonal,
            this.electrodomesticos,
            this.tecnologia,
            this.hogar});
            this.mnAlimentacion.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnAlimentacion.Location = new System.Drawing.Point(0, 76);
            this.mnAlimentacion.Name = "mnAlimentacion";
            this.mnAlimentacion.Padding = new System.Windows.Forms.Padding(0);
            this.mnAlimentacion.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnAlimentacion.Size = new System.Drawing.Size(1178, 24);
            this.mnAlimentacion.Stretch = false;
            this.mnAlimentacion.TabIndex = 9;
            this.mnAlimentacion.Text = "Alimentación";
            // 
            // alimentacion
            // 
            this.alimentacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lacteosmn,
            this.aceitesVinagresYSalsasmn,
            this.desayunomn,
            this.conservasmn,
            this.comiadsInternacionalesmn,
            this.nutriciónDeportivamn});
            this.alimentacion.Name = "alimentacion";
            this.alimentacion.Size = new System.Drawing.Size(94, 24);
            this.alimentacion.Text = "Alimentación";
            this.alimentacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lacteosmn
            // 
            this.lacteosmn.Name = "lacteosmn";
            this.lacteosmn.Size = new System.Drawing.Size(283, 22);
            this.lacteosmn.Text = "Lácteos y huevos";
            this.lacteosmn.Click += new System.EventHandler(this.lacteosmn_Click);
            // 
            // aceitesVinagresYSalsasmn
            // 
            this.aceitesVinagresYSalsasmn.Name = "aceitesVinagresYSalsasmn";
            this.aceitesVinagresYSalsasmn.Size = new System.Drawing.Size(283, 22);
            this.aceitesVinagresYSalsasmn.Text = "Aceites, vinagres y salsas especiales";
            this.aceitesVinagresYSalsasmn.Click += new System.EventHandler(this.aceitesVinagresYSalsasmn_Click);
            // 
            // desayunomn
            // 
            this.desayunomn.Name = "desayunomn";
            this.desayunomn.Size = new System.Drawing.Size(283, 22);
            this.desayunomn.Text = "Desayuno y merienda";
            this.desayunomn.Click += new System.EventHandler(this.desayunomn_Click);
            // 
            // conservasmn
            // 
            this.conservasmn.Name = "conservasmn";
            this.conservasmn.Size = new System.Drawing.Size(283, 22);
            this.conservasmn.Text = "Conservas";
            this.conservasmn.Click += new System.EventHandler(this.conservasmn_Click);
            // 
            // comiadsInternacionalesmn
            // 
            this.comiadsInternacionalesmn.Name = "comiadsInternacionalesmn";
            this.comiadsInternacionalesmn.Size = new System.Drawing.Size(283, 22);
            this.comiadsInternacionalesmn.Text = "Comidas internacionales";
            this.comiadsInternacionalesmn.Click += new System.EventHandler(this.comiadsInternacionalesmn_Click);
            // 
            // nutriciónDeportivamn
            // 
            this.nutriciónDeportivamn.Name = "nutriciónDeportivamn";
            this.nutriciónDeportivamn.Size = new System.Drawing.Size(283, 22);
            this.nutriciónDeportivamn.Text = "Nutrición deportiva";
            this.nutriciónDeportivamn.Click += new System.EventHandler(this.nutriciónDeportivamn_Click);
            // 
            // frescos
            // 
            this.frescos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frutasmn,
            this.quesosmn,
            this.mnsCarne,
            this.charcuteriamn,
            this.pescadosMariscosYMoluscosmn,
            this.sushimn});
            this.frescos.Name = "frescos";
            this.frescos.Size = new System.Drawing.Size(64, 24);
            this.frescos.Text = "Frescos";
            // 
            // frutasmn
            // 
            this.frutasmn.Name = "frutasmn";
            this.frutasmn.Size = new System.Drawing.Size(254, 22);
            this.frutasmn.Text = "Verduras y hortalizas";
            this.frutasmn.Click += new System.EventHandler(this.frutasmn_Click);
            // 
            // quesosmn
            // 
            this.quesosmn.Name = "quesosmn";
            this.quesosmn.Size = new System.Drawing.Size(254, 22);
            this.quesosmn.Text = "Quesos";
            this.quesosmn.Click += new System.EventHandler(this.quesosmn_Click);
            // 
            // mnsCarne
            // 
            this.mnsCarne.Name = "mnsCarne";
            this.mnsCarne.Size = new System.Drawing.Size(254, 22);
            this.mnsCarne.Text = "Carne";
            this.mnsCarne.Click += new System.EventHandler(this.mnsCarne_Click);
            // 
            // charcuteriamn
            // 
            this.charcuteriamn.Name = "charcuteriamn";
            this.charcuteriamn.Size = new System.Drawing.Size(254, 22);
            this.charcuteriamn.Text = "Charcutería";
            this.charcuteriamn.Click += new System.EventHandler(this.charcuteriamn_Click);
            // 
            // pescadosMariscosYMoluscosmn
            // 
            this.pescadosMariscosYMoluscosmn.Name = "pescadosMariscosYMoluscosmn";
            this.pescadosMariscosYMoluscosmn.Size = new System.Drawing.Size(254, 22);
            this.pescadosMariscosYMoluscosmn.Text = "Pescados, mariscos y moluscos";
            this.pescadosMariscosYMoluscosmn.Click += new System.EventHandler(this.pescadosMariscosYMoluscosmn_Click);
            // 
            // sushimn
            // 
            this.sushimn.Name = "sushimn";
            this.sushimn.Size = new System.Drawing.Size(254, 22);
            this.sushimn.Text = "Sushi";
            this.sushimn.Click += new System.EventHandler(this.sushimn_Click);
            // 
            // friosYCongelados
            // 
            this.friosYCongelados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.congeladosmn,
            this.postresmn,
            this.pastelesmn,
            this.mantequillasmn,
            this.platosmn,
            this.masasmn});
            this.friosYCongelados.Name = "friosYCongelados";
            this.friosYCongelados.Size = new System.Drawing.Size(125, 24);
            this.friosYCongelados.Text = "Fríos y congelados";
            // 
            // congeladosmn
            // 
            this.congeladosmn.Name = "congeladosmn";
            this.congeladosmn.Size = new System.Drawing.Size(248, 22);
            this.congeladosmn.Text = "Congelados";
            this.congeladosmn.Click += new System.EventHandler(this.congeladosmn_Click);
            // 
            // postresmn
            // 
            this.postresmn.Name = "postresmn";
            this.postresmn.Size = new System.Drawing.Size(248, 22);
            this.postresmn.Text = "Postres";
            this.postresmn.Click += new System.EventHandler(this.postresmn_Click);
            // 
            // pastelesmn
            // 
            this.pastelesmn.Name = "pastelesmn";
            this.pastelesmn.Size = new System.Drawing.Size(248, 22);
            this.pastelesmn.Text = "Pasteles";
            this.pastelesmn.Click += new System.EventHandler(this.pastelesmn_Click);
            // 
            // mantequillasmn
            // 
            this.mantequillasmn.Name = "mantequillasmn";
            this.mantequillasmn.Size = new System.Drawing.Size(248, 22);
            this.mantequillasmn.Text = "Mantequillas, margarina y nata";
            this.mantequillasmn.Click += new System.EventHandler(this.mantequillasmn_Click);
            // 
            // platosmn
            // 
            this.platosmn.Name = "platosmn";
            this.platosmn.Size = new System.Drawing.Size(248, 22);
            this.platosmn.Text = "Platos calentar y listo";
            this.platosmn.Click += new System.EventHandler(this.platosmn_Click);
            // 
            // masasmn
            // 
            this.masasmn.Name = "masasmn";
            this.masasmn.Size = new System.Drawing.Size(248, 22);
            this.masasmn.Text = "Masas, bases, pasta fresca";
            this.masasmn.Click += new System.EventHandler(this.masasmn_Click);
            // 
            // bebidas
            // 
            this.bebidas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zumosmn,
            this.sodamn,
            this.bebidasConAlcoholmn,
            this.champagnemn,
            this.bebidasEcologicasmn,
            this.bebidasSinAlcoholmn});
            this.bebidas.Name = "bebidas";
            this.bebidas.Size = new System.Drawing.Size(64, 24);
            this.bebidas.Text = "Bebidas";
            // 
            // zumosmn
            // 
            this.zumosmn.Name = "zumosmn";
            this.zumosmn.Size = new System.Drawing.Size(227, 22);
            this.zumosmn.Text = "Zumo de frutas";
            this.zumosmn.Click += new System.EventHandler(this.zumosmn_Click);
            // 
            // sodamn
            // 
            this.sodamn.Name = "sodamn";
            this.sodamn.Size = new System.Drawing.Size(227, 22);
            this.sodamn.Text = "Agua, soda y gaseosas";
            this.sodamn.Click += new System.EventHandler(this.sodamn_Click);
            // 
            // bebidasConAlcoholmn
            // 
            this.bebidasConAlcoholmn.Name = "bebidasConAlcoholmn";
            this.bebidasConAlcoholmn.Size = new System.Drawing.Size(227, 22);
            this.bebidasConAlcoholmn.Text = "Bebidas con alcohol";
            this.bebidasConAlcoholmn.Click += new System.EventHandler(this.bebidasConAlcoholmn_Click);
            // 
            // champagnemn
            // 
            this.champagnemn.Name = "champagnemn";
            this.champagnemn.Size = new System.Drawing.Size(227, 22);
            this.champagnemn.Text = "Champagne cavas y sidras";
            this.champagnemn.Click += new System.EventHandler(this.champagnemn_Click);
            // 
            // bebidasEcologicasmn
            // 
            this.bebidasEcologicasmn.Name = "bebidasEcologicasmn";
            this.bebidasEcologicasmn.Size = new System.Drawing.Size(227, 22);
            this.bebidasEcologicasmn.Text = "Bebidas Ecológicas";
            this.bebidasEcologicasmn.Click += new System.EventHandler(this.bebidasEcologicasmn_Click);
            // 
            // bebidasSinAlcoholmn
            // 
            this.bebidasSinAlcoholmn.Name = "bebidasSinAlcoholmn";
            this.bebidasSinAlcoholmn.Size = new System.Drawing.Size(227, 22);
            this.bebidasSinAlcoholmn.Text = "Bebidas sin alcohol";
            this.bebidasSinAlcoholmn.Click += new System.EventHandler(this.bebidasSinAlcoholmn_Click);
            // 
            // drogueria
            // 
            this.drogueria.Name = "drogueria";
            this.drogueria.Size = new System.Drawing.Size(76, 24);
            this.drogueria.Text = "Droguería";
            // 
            // cuidadoPersonal
            // 
            this.cuidadoPersonal.Name = "cuidadoPersonal";
            this.cuidadoPersonal.Size = new System.Drawing.Size(118, 24);
            this.cuidadoPersonal.Text = "Cuidado personal";
            // 
            // electrodomesticos
            // 
            this.electrodomesticos.Name = "electrodomesticos";
            this.electrodomesticos.Size = new System.Drawing.Size(124, 24);
            this.electrodomesticos.Text = "Electrodomésticos";
            // 
            // tecnologia
            // 
            this.tecnologia.Name = "tecnologia";
            this.tecnologia.Size = new System.Drawing.Size(80, 24);
            this.tecnologia.Text = "Tecnología";
            // 
            // hogar
            // 
            this.hogar.Name = "hogar";
            this.hogar.Size = new System.Drawing.Size(54, 24);
            this.hogar.Text = "Hogar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPerfil);
            this.panel2.Controls.Add(this.lblContador);
            this.panel2.Controls.Add(this.lblSaludo);
            this.panel2.Controls.Add(this.btnCarrito);
            this.panel2.Controls.Add(this.btnIdentificarse);
            this.panel2.Location = new System.Drawing.Point(95, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 70);
            this.panel2.TabIndex = 8;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Image = global::ProyectoCompra.Properties.Resources.icon_perfil;
            this.btnPerfil.Location = new System.Drawing.Point(970, 11);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(43, 58);
            this.btnPerfil.TabIndex = 4;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            this.btnPerfil.MouseEnter += new System.EventHandler(this.btnPerfil_MouseEnter);
            this.btnPerfil.MouseLeave += new System.EventHandler(this.btnPerfil_MouseLeave);
            // 
            // lblContador
            // 
            this.lblContador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(1051, 36);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(21, 12);
            this.lblContador.TabIndex = 8;
            this.lblContador.Text = "0";
            // 
            // lblSaludo
            // 
            this.lblSaludo.Font = new System.Drawing.Font("Arial Nova Cond", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(3, 6);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(222, 58);
            this.lblSaludo.TabIndex = 5;
            this.lblSaludo.Text = "Easy Shop";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarrito
            // 
            this.btnCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarrito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCarrito.FlatAppearance.BorderSize = 0;
            this.btnCarrito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrito.Image = global::ProyectoCompra.Properties.Resources.icon_carrito;
            this.btnCarrito.Location = new System.Drawing.Point(1000, 3);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(72, 63);
            this.btnCarrito.TabIndex = 7;
            this.btnCarrito.Text = "Carrito";
            this.btnCarrito.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarrito.UseMnemonic = false;
            this.btnCarrito.UseVisualStyleBackColor = false;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            this.btnCarrito.MouseEnter += new System.EventHandler(this.btnCarrito_MouseEnter);
            this.btnCarrito.MouseLeave += new System.EventHandler(this.btnCarrito_MouseLeave);
            // 
            // btnIdentificarse
            // 
            this.btnIdentificarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIdentificarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdentificarse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIdentificarse.FlatAppearance.BorderSize = 0;
            this.btnIdentificarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnIdentificarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnIdentificarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentificarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentificarse.Image = global::ProyectoCompra.Properties.Resources.icon_perfil;
            this.btnIdentificarse.Location = new System.Drawing.Point(945, 11);
            this.btnIdentificarse.Name = "btnIdentificarse";
            this.btnIdentificarse.Size = new System.Drawing.Size(67, 58);
            this.btnIdentificarse.TabIndex = 3;
            this.btnIdentificarse.Text = "Mi cuenta";
            this.btnIdentificarse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIdentificarse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIdentificarse.UseVisualStyleBackColor = true;
            this.btnIdentificarse.Click += new System.EventHandler(this.btnIdentificarse_Click);
            this.btnIdentificarse.MouseEnter += new System.EventHandler(this.btnIdentificarse_MouseEnter);
            this.btnIdentificarse.MouseLeave += new System.EventHandler(this.btnIdentificarse_MouseLeave);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 103);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBase";
            this.Text = "FrmBase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBase_FormClosed);
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnAlimentacion.ResumeLayout(false);
            this.mnAlimentacion.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogoMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnIdentificarse;
        private System.Windows.Forms.MenuStrip mnAlimentacion;
        private System.Windows.Forms.ToolStripMenuItem alimentacion;
        private System.Windows.Forms.ToolStripMenuItem lacteosmn;
        private System.Windows.Forms.ToolStripMenuItem aceitesVinagresYSalsasmn;
        private System.Windows.Forms.ToolStripMenuItem desayunomn;
        private System.Windows.Forms.ToolStripMenuItem conservasmn;
        private System.Windows.Forms.ToolStripMenuItem comiadsInternacionalesmn;
        private System.Windows.Forms.ToolStripMenuItem nutriciónDeportivamn;
        private System.Windows.Forms.ToolStripMenuItem frescos;
        private System.Windows.Forms.ToolStripMenuItem frutasmn;
        private System.Windows.Forms.ToolStripMenuItem quesosmn;
        private System.Windows.Forms.ToolStripMenuItem mnsCarne;
        private System.Windows.Forms.ToolStripMenuItem charcuteriamn;
        private System.Windows.Forms.ToolStripMenuItem pescadosMariscosYMoluscosmn;
        private System.Windows.Forms.ToolStripMenuItem sushimn;
        private System.Windows.Forms.ToolStripMenuItem friosYCongelados;
        private System.Windows.Forms.ToolStripMenuItem congeladosmn;
        private System.Windows.Forms.ToolStripMenuItem postresmn;
        private System.Windows.Forms.ToolStripMenuItem pastelesmn;
        private System.Windows.Forms.ToolStripMenuItem mantequillasmn;
        private System.Windows.Forms.ToolStripMenuItem platosmn;
        private System.Windows.Forms.ToolStripMenuItem masasmn;
        private System.Windows.Forms.ToolStripMenuItem bebidas;
        private System.Windows.Forms.ToolStripMenuItem zumosmn;
        private System.Windows.Forms.ToolStripMenuItem sodamn;
        private System.Windows.Forms.ToolStripMenuItem bebidasConAlcoholmn;
        private System.Windows.Forms.ToolStripMenuItem champagnemn;
        private System.Windows.Forms.ToolStripMenuItem bebidasEcologicasmn;
        private System.Windows.Forms.ToolStripMenuItem bebidasSinAlcoholmn;
        private System.Windows.Forms.ToolStripMenuItem drogueria;
        private System.Windows.Forms.ToolStripMenuItem cuidadoPersonal;
        private System.Windows.Forms.ToolStripMenuItem electrodomesticos;
        private System.Windows.Forms.ToolStripMenuItem tecnologia;
        private System.Windows.Forms.ToolStripMenuItem hogar;
        private System.Windows.Forms.Button btnCarrito;
        public System.Windows.Forms.Label lblContador;
    }
}