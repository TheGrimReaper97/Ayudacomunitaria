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
    public partial class Form4 : Form
    {
        Conexion c = new Conexion();
       
                   

        public Form4()
        {
            InitializeComponent();                    
          
         
        }

        private void btnsalirpr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnregistrarpr_Click(object sender, EventArgs e)
        {
             if(c.productosregistrado(Convert.ToInt32(txtidproducto.Text))==0)
            {
                
                MessageBox.Show(c.insertarproductos(txtnombreproducto.Text, Convert.ToInt32(txtidproducto.Text), Convert.ToInt32(txtnUP2.Text)));
                c.cargarProductos(dataGridView1);

            }
             else
            {
                MessageBox.Show("Imposible de registrar, El registro ya existe");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            c.cargarProductos(dataGridView1);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtidproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombreproducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
