using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SpreadsheetLight;
using System.IO;
using System.Threading.Tasks;

namespace Exportar_a_Pacific_productos
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

		private void BtnConectar_Click(object sender, EventArgs e)
		{
			//Este es un codigo de prueba para ver si responde el servidor MySQL
			listBox1.Items.Clear();
			GenerarPeticionAServidor();
		}

		private void BtnImportar_Click(object sender, EventArgs e)
		{
			//Abrimos el archivo excel donde venga la informacion a importar
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
			SLDocument import = null;
			if (open.ShowDialog() == DialogResult.OK)
			{
				try
				{
					import = new SLDocument(open.FileName);
					if (!import.SelectWorksheet(txtNombreHoja.Text))
					{
						MessageBox.Show("Esa hoja que escribiste no existen en el documento", "OJO",
							MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}
				catch (IOException ex)
				{
					MessageBox.Show(ex.Message);
					return;
				}

			}
			else
				return;

			datos = new DataTable();
			datos.Columns.Add("Codigo", typeof(string));
			datos.Columns.Add("Nombre", typeof(string));
			datos.Columns.Add("IVA", typeof(int));
			datos.Columns.Add("Precio", typeof(double));
			datos.Columns.Add("Unidad de medida", typeof(string));
			datos.Columns.Add("CodigoSat", typeof(string));

			int renglon = 2;
			while (!string.IsNullOrEmpty(import.GetCellValueAsString(renglon, 1)))
			{
				datos.Rows.Add(import.GetCellValueAsString(renglon, 1), import.GetCellValueAsString(renglon, 2),
					import.GetCellValueAsInt32(renglon, 3), import.GetCellValueAsDouble(renglon, 4),
					import.GetCellValueAsString(renglon, 5), import.GetCellValueAsString(renglon, 6));
				renglon++;
			}

			dataGridView1.DataSource = datos;
			import.CloseWithoutSaving();

			lblCantidad.Text = "Cantidad de registros encontrados: " + datos.Rows.Count;
		}


		DataTable datos;

		private async void BtnBulk_Click(object sender, EventArgs e)
		{
			//Nos aseguramos de que esten selccionados la categoria y la subcategoria
			if (cmbGrupos.SelectedIndex == -1 || cmbAgrupaciones.SelectedIndex == -1)
			{
				MessageBox.Show("Asegurate de seleccionar un grupo y una agrupacion", "Olvidaste seleccionar el grupo y agrupacion",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			//Hacemos una insercion de cada registro en las tablas correspondientes
			MySqlConnection con = new MySqlConnection(config.AppSettings.Settings["remote"].Value);
			try
			{
				gif.Visible = true;
				await con.OpenAsync();
				MySqlCommand cmd = new MySqlCommand
				{
					Connection = con
				};
				for (int i = 0; i < datos.Rows.Count; i++)
				{
					//esta es la consulta para insertar en el catalogo de productos
					cmd.CommandText = "INSERT INTO `tblcatarticulos` " +
						$"VALUES ('{datos.Rows[i]["Codigo"]}', '{datos.Rows[i]["Nombre"]}', '', '1', '0.0000', '{datos.Rows[i][2]}', '0', '0.0000', " +
						$"'', '0', '{DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day}', '{DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day}', " +
						$"'{DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day}', '{DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day}', " +
						$"'1', '0', '0', '0', '1', '0', '0', '1', '0.0000', '0.0000', '{datos.Rows[i]["CodigoSat"]}', " +
						$"'0', '{DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day} {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}', '', '0', '');";

					//aqui se asigna el grupo y la agrupacion al articulo
					cmd.CommandText += $"insert into `tblgpoarticulos` values ('{datos.Rows[i]["Codigo"]}', " +
						$"'{grupos.Rows[cmbGrupos.SelectedIndex][0]}', '{agrupaciones.Rows[cmbAgrupaciones.SelectedIndex][0]}');";

					//aqui se asignan los precios, antes de impuestos y despues de impuestos
					//cmd.CommandText += $"insert into `la_bajadita`.`tblprecios` values ('{datos.Rows[i]["Codigo"]}'," +
					//	$"1, {(datos.Rows[i][2].ToString() == "2" ? (float.Parse(datos.Rows[i][3].ToString()) /1.08).ToString() : datos.Rows[i][3].ToString())}," +
					//	$"{datos.Rows[i][3]}, 0.0000, '{datos.Rows[i][4]}', '', '', 1, '', 0.0000)";

					await cmd.ExecuteNonQueryAsync();

				}
				MessageBox.Show("Se han cargado todos los datos en la base de datos," +
					" verifica en Pacific todos los Productos para asignarlos precio y unidad", "Proceso exitoso",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				dataGridView1.DataSource = null;
				cmbAgrupaciones.Text = null;
				cmbGrupos.Text = null;
				txtNombreHoja.Text = null;
			}
			catch (Exception ex)
			{
				if (ex.Message.Contains("CFDI"))
					MessageBox.Show("Verifica que el codigo del sat en el documento de excel no tenga espacios en blanco por favor", "Error en la longitud de la cadena del codigo del sat",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(ex.Message);
			}
			finally
			{
				await con.CloseAsync();
				gif.Visible = false;
			}
		}

		//Método de prueba
		public async void GenerarPeticionAServidor()
		{
			MySqlConnection con = new MySqlConnection();//= new MySqlConnection(ConfigurationManager.ConnectionStrings["remote"].ToString());

			try
			{
				con = new MySqlConnection(config.AppSettings.Settings["remote"].Value);
				MySqlCommand cmd = new MySqlCommand("show databases")
				{
					Connection = con
				};
				label1.Text = "Conectando a servidor";
				btnConectar.Enabled = false;
				await con.OpenAsync();
				label1.Text = "Buscando bases de datos";
				var reader = await cmd.ExecuteReaderAsync();

				while (reader.Read())
				{
					listBox1.Items.Add(reader.GetString(0));
				}

				label1.Text = null;
				btnConectar.Enabled = true;
			}
			catch (MySqlException)
			{
				MessageBox.Show("Ocurrio un error durante la conexion al servidor");
			}
			finally
			{
				con.Close();
			}
		}

		DataTable grupos;
		DataTable agrupaciones;

		//Aqui hacemos una consulta al servidor con todos los grupos existentes en la base de datos
		public void CargarGrupos()
		{
			Invoke(new Action(async () =>
			{
				cmbGrupos.Items.Clear();
				lblLoadGrupos.Text = "Cargando grupos";
				cmbAgrupaciones.Enabled = false;
				grupos = new DataTable();
				MySqlConnection con = new MySqlConnection(); //= new MySqlConnection(ConfigurationManager.ConnectionStrings["remote"].ToString()); ;
				try
				{
					con.ConnectionString = config.AppSettings.Settings["remote"].Value;
					await con.OpenAsync();
					MySqlDataAdapter ad = new MySqlDataAdapter(new MySqlCommand("select * from tblagrupacionart", con));
					await ad.FillAsync(grupos);

					for (int i = 0; i < grupos.Rows.Count; i++)
					{
						cmbGrupos.Items.Add(grupos.Rows[i][1]);
					}


					cmbAgrupaciones.Enabled = true;
				}
				catch (MySqlException ex)
				{
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (NullReferenceException)
				{
					//Aqui es donde salta el supuesto error
					MessageBox.Show("Agregando nuevo perfil para la conexion al servidor de la base de datos");

					config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
					config.AppSettings.Settings.Add("remote", "Database=la_bajadita; server=pc-pruebas; Port=3306; User Id=remote; password=nomanches;");
					config.Save(ConfigurationSaveMode.Modified);
					config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
					Task.Run(() => CargarGrupos());
				}
				finally
				{
					await con.CloseAsync();
					lblLoadGrupos.Visible = false;
				}
			}));

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CargarGrupos();
		}

		//Aqui cuando se seleccione un grupo del combo se cargaran todos los subgrupos correspondientes al seleccionado
		private async void cmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblLoadGrupos.Text = "Cargando agrupaciones";
			lblLoadGrupos.Visible = true;
			cmbAgrupaciones.Items.Clear();
			MySqlConnection con = new MySqlConnection(); /*= new MySqlConnection(ConfigurationManager.ConnectionStrings["remote"].ToString());*/
			agrupaciones = new DataTable();

			try
			{
				con.ConnectionString = config.AppSettings.Settings["remote"].Value;
				await con.OpenAsync();
				MySqlDataAdapter ad = new MySqlDataAdapter(new MySqlCommand("select cod_agr, des_agr, cod_gpo from tblcatagrupacionart " +
					$"where cod_gpo={grupos.Rows[cmbGrupos.SelectedIndex][0]}", con));
				await ad.FillAsync(agrupaciones);

				for (int i = 0; i < agrupaciones.Rows.Count; i++)
				{
					cmbAgrupaciones.Items.Add(agrupaciones.Rows[i][1]);
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				await con.CloseAsync();
				lblLoadGrupos.Visible = false;
			}
		}

		private void configurarServidorDeDestinoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new FrmConfig().ShowDialog();
			config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			CargarGrupos();
		}
	}
}
