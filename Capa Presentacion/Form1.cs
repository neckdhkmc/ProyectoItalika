using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
namespace Capa_Presentacion
{
    public partial class Form1 : Form
    {
        CN_Usuarios objeto = new CN_Usuarios();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //MostrarUsuarios();
        }
        private void MostrarUsuarios()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dataGridView1.DataSource = objeto.MostrarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarRegistros();
        }
        public void GuardarRegistros()
        {
            try
            {
                string i = "I";

                objeto.AgregarProc(txt1.Text, i, txt2.Text, txt3.Text, txt4.Text);
                MessageBox.Show("Se inserto correctamente");
                MostrarUsuarios();
                txt1.Text = " ";
                txt2.Text = " ";
                txt3.Text = " ";
                txt4.Text = " ";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizo la insercion");
            }
           
        }

        private void insertarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gb1.Visible = true;
            txt1.Visible = false;
           
            btnEditar.Enabled = false;
            button1.Enabled = false;
            txt2.Enabled = true;
            txt3.Enabled = true;
            txt4.Enabled = true;
            btnGuardar.Enabled = true;
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Convert.ToInt32(dataGridView1.Rows[1].Cells["id"].Value.ToString());
            txt2.Text = id.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int id;
            id = dataGridView1.CurrentRow.Index;
            txt1.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            txt2.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            txt3.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            txt4.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            txt1.Enabled = false;
        }

        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("selecciona una fila de la Tabla y edita los campos");
            gb1.Visible = true;
            txt1.Visible = true;
            label1.Visible = true;
            dataGridView1.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            button1.Enabled = false;
            MostrarUsuarios();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarRegistro();
        }
        public void EditarRegistro()
        {
            try
            {
                string i = "U";

                objeto.AgregarProc(txt1.Text, i, txt2.Text, txt3.Text, txt4.Text);
                MessageBox.Show("Se editó correctamente");
                MostrarUsuarios();
                txt1.Text = " ";
                txt2.Text = " ";
                txt3.Text = " ";
                txt4.Text = " ";

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizo la insercion");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }
        public void EliminarRegistro()
        {
            try
            {
                string i = "D";

                objeto.AgregarProc(txt1.Text, i, txt2.Text, txt3.Text, txt4.Text);
                MessageBox.Show("Se Eliminó correctamente");
                MostrarUsuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizo la Actualizadion de los datos");
            }

        }

        private void eliminarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("selecciona una fila de la Tabla y Elimina el registro");
            gb1.Visible = true;
            txt1.Visible = true;
            txt1.Enabled = false;
            label1.Visible = true;
            button1.Enabled = true;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt4.Enabled = false;
            MostrarUsuarios();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarUsuarios();
            gb1.Visible = false;
        }

        private void consultarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gb1.Visible = false;
            MostrarUsuarios();

        }
    }
}
