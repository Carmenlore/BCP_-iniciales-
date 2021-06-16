using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPERACION__iniciales_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
		//instancia
			SqlConnection cn = new SqlConnection(
				ConfigurationManager.ConnectionStrings["CTRANS"].ConnectionString
				);
			string query= "INSERT INTO CUENTA (NRO_CUENTA, NOMBRE) VALUES (@NRO_CUENTA, @NOMBRE)";
			
			SqlCommand command = new SqlCommand(query, cn);
			command.Parameters.AddWithValue("@NRO_CUENTA", textBox1.Text);
			command.Parameters.AddWithValue("@NOMBRE", textBox2.Text);
			cn.Open();
			MessageBox.Show("conexion exitosa");
			//cn.Close();
			command.ExecuteNonQuery();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
