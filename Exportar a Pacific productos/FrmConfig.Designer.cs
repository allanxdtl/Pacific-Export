namespace Exportar_a_Pacific_productos
{
	partial class FrmConfig
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.BtnSet = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(46, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(248, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Servidor (Nombre o IP)";
			// 
			// txtServer
			// 
			this.txtServer.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtServer.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtServer.Location = new System.Drawing.Point(42, 89);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(262, 29);
			this.txtServer.TabIndex = 1;
			// 
			// txtPort
			// 
			this.txtPort.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPort.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPort.Location = new System.Drawing.Point(371, 88);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(105, 29);
			this.txtPort.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(375, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 26);
			this.label2.TabIndex = 2;
			this.label2.Text = "Puerto";
			// 
			// txtUser
			// 
			this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUser.Location = new System.Drawing.Point(33, 190);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(262, 29);
			this.txtUser.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(79, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(166, 26);
			this.label3.TabIndex = 4;
			this.label3.Text = "Usuario MySQL";
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(331, 192);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(262, 29);
			this.txtPassword.TabIndex = 7;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(399, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 26);
			this.label4.TabIndex = 6;
			this.label4.Text = "Contraseña";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(469, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(124, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Mostrar Contraseña";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// BtnSet
			// 
			this.BtnSet.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BtnSet.Enabled = false;
			this.BtnSet.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSet.Location = new System.Drawing.Point(12, 337);
			this.BtnSet.Name = "BtnSet";
			this.BtnSet.Size = new System.Drawing.Size(430, 50);
			this.BtnSet.TabIndex = 9;
			this.BtnSet.Text = "Establecer parámetros";
			this.BtnSet.UseVisualStyleBackColor = true;
			this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(214, 244);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(152, 26);
			this.label6.TabIndex = 10;
			this.label6.Text = "Base de datos";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(183, 286);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(229, 31);
			this.comboBox1.TabIndex = 12;
			// 
			// FrmConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 399);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.BtnSet);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtServer);
			this.Controls.Add(this.label1);
			this.Name = "FrmConfig";
			this.Text = "Parametros de configuracion";
			this.Load += new System.EventHandler(this.FrmConfig_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button BtnSet;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}