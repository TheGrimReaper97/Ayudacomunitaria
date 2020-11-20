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

        private List<Productos>  Productos = new List<Productos>();
        private int edit_indice1= -1;
         
        

        private void btnsalirpr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void actualizargrid1()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Productos;
        }
        private void reseteo()
        {
            txtnombreproducto.Clear();
            txtidproducto.Clear();
            txtcant.Clear();
        }
        private void btnregistrarpr_Click(object sender, EventArgs e)
        {
            if (c.productoregistrado(Convert.ToInt32(txtidproducto.Text))== 0)
            {
                Productos producto = new Productos();
                producto.Producto  = txtnombreproducto.Text;
                producto.IdProducto = Int32.Parse(txtidproducto.Text);
                producto.Cantidad = Int32.Parse(txtcant.Text);
                

                if (edit_indice1 > -1)
                {
                    Productos[edit_indice1] = producto;
                    edit_indice1 = -1;
                }
                else
                {
                    Productos.Add(producto);
                }
                actualizargrid1();
                reseteo();
                MessageBox.Show("Se inserto");
            }
            else
            {
                MessageBox.Show("El regsitro ya existe");
            }


            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            c.cargarProductos(dataGridView1);
        }

      
    }
}
