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
			MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
			{
				Database = comboBox1.Text,
				Server = txtServer.Text,
				Port = Convert.ToUInt32(txtPort.Text),
				UserID = txtUser.Text,
				Password = txtPassword.Text
			};
			string cadena = builder.ConnectionString;
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
			comboBox1.Text = config.AppSettings.Settings["remote"].Value.Split(';')[0].Split('=')[1];
			txtServer.Text = config.AppSettings.Settings["remote"].Value.Split(';')[1].Split('=')[1];
			txtPort.Text = config.AppSettings.Settings["remote"].Value.Split(';')[2].Split('=')[1];
			txtUser.Text = config.AppSettings.Settings["remote"].Value.Split(';')[3].Split('=')[1];
			txtPassword.Text = config.AppSettings.Settings["remote"].Value.Split(';')[4].Split('=')[1];
		}

		private async void txtPassword_TextChanged(object sender, EventArgs e)
		{
			comboBox1.Items.Clear();
			MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
			{
				Database = "sys",
				Server = txtServer.Text,
				Port = Convert.ToUInt32(txtPort.Text),
				UserID = txtUser.Text,
				Password = txtPassword.Text
			};
			string cadena = builder.ConnectionString;
			MySqlConnection con = new MySqlConnection();
			try
			{
				con.ConnectionString = cadena;
				await con.OpenAsync();
				MySqlCommand cmd = new MySqlCommand("show databases", con);

				var reader = await cmd.ExecuteReaderAsync();

				while (reader.Read())
				{
					comboBox1.Items.Add(reader.GetString(0));
				}

				BtnSet.Enabled = true;
			}
			catch (MySqlException)
			{
				BtnSet.Enabled = false;
				//La contraseña es incorrecta
			}
			finally
			{
				await con.CloseAsync();
			}
		}
	}
}
