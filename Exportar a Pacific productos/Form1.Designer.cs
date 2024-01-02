namespace Exportar_a_Pacific_productos
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnConectar = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnImportar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombreHoja = new System.Windows.Forms.TextBox();
			this.BtnBulk = new System.Windows.Forms.Button();
			this.gif = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbGrupos = new System.Windows.Forms.ComboBox();
			this.cmbAgrupaciones = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lblLoadGrupos = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configurarServidorDeDestinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnConectar
			// 
			this.btnConectar.Location = new System.Drawing.Point(986, 290);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(102, 39);
			this.btnConectar.TabIndex = 0;
			this.btnConectar.Text = "Conectar";
			this.btnConectar.UseVisualStyleBackColor = true;
			this.btnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(936, 356);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(181, 212);
			this.listBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1044, 266);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(153)))), ((int)(((byte)(111)))));
			this.label2.Location = new System.Drawing.Point(138, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(630, 42);
			this.label2.TabIndex = 3;
			this.label2.Text = "Selecciona el archivo excel que deseas importar";
			// 
			// BtnImportar
			// 
			this.BtnImportar.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnImportar.Location = new System.Drawing.Point(53, 97);
			this.BtnImportar.Name = "BtnImportar";
			this.BtnImportar.Size = new System.Drawing.Size(175, 51);
			this.BtnImportar.TabIndex = 4;
			this.BtnImportar.Text = "Importar";
			this.BtnImportar.UseVisualStyleBackColor = true;
			this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(27, 172);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(835, 380);
			this.dataGridView1.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(35)))));
			this.label3.Location = new System.Drawing.Point(279, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 32);
			this.label3.TabIndex = 6;
			this.label3.Text = "Nombre de la hoja";
			// 
			// txtNombreHoja
			// 
			this.txtNombreHoja.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreHoja.Location = new System.Drawing.Point(505, 103);
			this.txtNombreHoja.Name = "txtNombreHoja";
			this.txtNombreHoja.Size = new System.Drawing.Size(225, 39);
			this.txtNombreHoja.TabIndex = 7;
			// 
			// BtnBulk
			// 
			this.BtnBulk.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnBulk.Location = new System.Drawing.Point(53, 574);
			this.BtnBulk.Name = "BtnBulk";
			this.BtnBulk.Size = new System.Drawing.Size(341, 57);
			this.BtnBulk.TabIndex = 8;
			this.BtnBulk.Text = "Meter a la base de datos";
			this.BtnBulk.UseVisualStyleBackColor = true;
			this.BtnBulk.Click += new System.EventHandler(this.BtnBulk_Click);
			// 
			// gif
			// 
			this.gif.Image = ((System.Drawing.Image)(resources.GetObject("gif.Image")));
			this.gif.Location = new System.Drawing.Point(0, 0);
			this.gif.Name = "gif";
			this.gif.Size = new System.Drawing.Size(1254, 681);
			this.gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.gif.TabIndex = 9;
			this.gif.TabStop = false;
			this.gif.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(35)))));
			this.label4.Location = new System.Drawing.Point(883, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 32);
			this.label4.TabIndex = 10;
			this.label4.Text = "Grupo";
			// 
			// cmbGrupos
			// 
			this.cmbGrupos.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGrupos.FormattingEnabled = true;
			this.cmbGrupos.Location = new System.Drawing.Point(976, 72);
			this.cmbGrupos.Name = "cmbGrupos";
			this.cmbGrupos.Size = new System.Drawing.Size(290, 40);
			this.cmbGrupos.TabIndex = 11;
			this.cmbGrupos.SelectedIndexChanged += new System.EventHandler(this.cmbGrupos_SelectedIndexChanged);
			// 
			// cmbAgrupaciones
			// 
			this.cmbAgrupaciones.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbAgrupaciones.FormattingEnabled = true;
			this.cmbAgrupaciones.Location = new System.Drawing.Point(976, 128);
			this.cmbAgrupaciones.Name = "cmbAgrupaciones";
			this.cmbAgrupaciones.Size = new System.Drawing.Size(290, 40);
			this.cmbAgrupaciones.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(35)))));
			this.label5.Location = new System.Drawing.Point(810, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(146, 32);
			this.label5.TabIndex = 12;
			this.label5.Text = "Agrupaciones";
			// 
			// lblLoadGrupos
			// 
			this.lblLoadGrupos.AutoSize = true;
			this.lblLoadGrupos.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoadGrupos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
			this.lblLoadGrupos.Location = new System.Drawing.Point(993, 33);
			this.lblLoadGrupos.Name = "lblLoadGrupos";
			this.lblLoadGrupos.Size = new System.Drawing.Size(177, 32);
			this.lblLoadGrupos.TabIndex = 14;
			this.lblLoadGrupos.Text = "Cargando grupos";
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
			this.lblCantidad.Location = new System.Drawing.Point(400, 586);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(26, 32);
			this.lblCantidad.TabIndex = 15;
			this.lblCantidad.Text = "0";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1278, 28);
			this.menuStrip1.TabIndex = 16;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// configuracionToolStripMenuItem
			// 
			this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarServidorDeDestinoToolStripMenuItem});
			this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
			this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
			this.configuracionToolStripMenuItem.Text = "Configuracion";
			// 
			// configurarServidorDeDestinoToolStripMenuItem
			// 
			this.configurarServidorDeDestinoToolStripMenuItem.Name = "configurarServidorDeDestinoToolStripMenuItem";
			this.configurarServidorDeDestinoToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
			this.configurarServidorDeDestinoToolStripMenuItem.Text = "Configurar servidor de destino";
			this.configurarServidorDeDestinoToolStripMenuItem.Click += new System.EventHandler(this.configurarServidorDeDestinoToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
			this.ClientSize = new System.Drawing.Size(1278, 705);
			this.Controls.Add(this.gif);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.BtnBulk);
			this.Controls.Add(this.txtNombreHoja);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.BtnImportar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnConectar);
			this.Controls.Add(this.lblLoadGrupos);
			this.Controls.Add(this.cmbAgrupaciones);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbGrupos);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Importar productos a PacificSoft";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConectar;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BtnImportar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNombreHoja;
		private System.Windows.Forms.Button BtnBulk;
		private System.Windows.Forms.PictureBox gif;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbGrupos;
		private System.Windows.Forms.ComboBox cmbAgrupaciones;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblLoadGrupos;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configurarServidorDeDestinoToolStripMenuItem;
	}
}

