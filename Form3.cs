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

        private void btnsalirp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnregistrarp_Click(object sender, EventArgs e)
        {
            if (c.personaregistrada(Convert.ToInt32(txtnombres.Text)) == 0)
            {

               MessageBox.Show(c.insertarpersona(txtnombres.Text, txtapellidos.Text, Convert.ToInt32(txtcasa.Text), Convert.ToInt32(txtidp), Convert.ToInt32(nUD1.Text), Convert.ToInt32(dTP1.Text)));
                c.cargarPersona(dataGridView2);

            }
            else
            {
                MessageBox.Show("Imposible de registrar, El registro ya existe");
            }
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            c.cargarPersona(dataGridView2);
        }


    }
}
