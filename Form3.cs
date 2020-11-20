using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Ayuda_Comunitaria
{
    public partial class Form3 : Form
    {
        Conexion c = new Conexion();
     
        public Form3()
        {
            InitializeComponent();        
                 
           
        }

        private List<Personas> Personas = new List<Personas>();
        private int edit_indice = -1;

        private void btnsalirp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void actualizargrid()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Personas;
        }
        private void reseteo()
        {
            txtnombres.Clear();
            txtapellidos.Clear();
            txtcasa.Clear();
            txtidp.Clear();
            txtintegrantes.Clear();
            
        }


        private void btnregistrarp_Click(object sender, EventArgs e)
        {
            if (c.personaregistrada ( Convert.ToInt32(txtidp.Text)) == 0)
            {
                Personas persona = new Personas();
                persona.Nombres = txtnombres.Text;
                persona.Apellidos = txtapellidos.Text;
                persona.Casa = decimal.Parse(txtcasa.Text);
                persona.IdPersona = Int32.Parse(txtidp.Text);
                persona.Integrantes = int.Parse(txtintegrantes.Text);
                persona.Fecha = Convert.ToDateTime(dTP1.Text);

                if (edit_indice > -1)
                {
                    Personas[edit_indice] = persona;
                    edit_indice = -1;
                }
                else
                {
                    Personas.Add(persona);
                }
                actualizargrid();
                reseteo();
                MessageBox.Show("Se inserto");
            }

            else
            {
                MessageBox.Show("El regsitro ya existe");
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            c.cargarPersona(dataGridView2);
        }



        


    }
}
