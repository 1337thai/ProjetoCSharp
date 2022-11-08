using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PortariaApp
{
    public partial class frmTestarConexao : Form
    {
        public frmTestarConexao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost;Port=3306;Database=dbPortaria;Uid=root;Pwd=''";
            try
            {
                conn.Open();
                lblMostrarStatus.Text = "Banco de dados conectado";
            }catch (MySqlException)
            {
                lblMostrarStatus.Text = "Erro ao conectar";
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.Close();
            lblMostrarStatus.Text = "Banco de dados desconectado";
        }
    }
}
