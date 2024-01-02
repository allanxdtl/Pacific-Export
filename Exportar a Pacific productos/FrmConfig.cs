using System;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Exportar_a_Pacific_productos
{
	public partial class FrmConfig : Form
	{
		public FrmConfig()
		{
			InitializeComponent();
			txtPassword.UseSystemPasswordChar = true;
		}

		private void label5_Click(object sender, EventArgs e)
		{
			Label label = (Label)sender;

			if (label.Text == "Mostrar Contraseña")
			{
				txtPassword.UseSystemPasswordChar = false;
				label5.Text = "Ocultar Contraseña";
			}
			else if (label.Text == "Ocultar Contraseña")
			{
				txtPassword.UseSystemPasswordChar = true;
				label5.Text = "Mostrar Contraseña";
			}
		}

		private async void BtnSet_Click(object sender, EventArgs e)
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			string cadena = $"Database={txtBd.Text}; server={txtServer.Text}; Port={txtPort.Text}; User Id={txtUser.Text}; password={txtPassword.Text};";
			config.AppSettings.Settings["remote"].Value = cadena;
			config.Save(ConfigurationSaveMode.Modified);

			MySqlConnection con = new MySqlConnection();
			try
			{
				con.ConnectionString = config.AppSettings.Settings["remote"].Value;
				await con.OpenAsync();
				MessageBox.Show("Se ha probado la conexion exitosamente", "Conexion exitosa",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show("Se han establecido todos los parametros para la conexion", "Configuracion guardada", 
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
			catch (MySqlException)
			{
				MessageBox.Show("Ocurrio un error, revisa los parametros y la disponibilidad del servidor MySQL");
			}
			finally
			{
				await con.CloseAsync();
			}
		}

		private void FrmConfig_Load(object sender, EventArgs e)
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			txtBd.Text = config.AppSettings.Settings["remote"].Value.Split(';')[0].Split('=')[1];
			txtServer.Text = config.AppSettings.Settings["remote"].Value.Split(';')[1].Split('=')[1];
			txtPort.Text = config.AppSettings.Settings["remote"].Value.Split(';')[2].Split('=')[1];
			txtUser.Text = config.AppSettings.Settings["remote"].Value.Split(';')[3].Split('=')[1];
			txtPassword.Text = config.AppSettings.Settings["remote"].Value.Split(';')[4].Split('=')[1];
		}
	}
}
