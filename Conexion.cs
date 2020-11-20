using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Proyecto_Ayuda_Comunitaria
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Ayuda_Comunitaria;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");


            }

            catch(Exception ex)
            {

                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());

            }



        }

        public string insertarproductos(string Nombrep, int id, int cantidad)
        {

            string salida = "Se se inserto";

            try
            {
                cmd = new SqlCommand("Insert into Productos(Nombre_Producto,ID_Producto,Cantidad_Producto) values('"+Nombrep+"','"+id+"',"+cantidad+" )",cn);
                cmd.ExecuteNonQuery();
            }
            
            catch(Exception ex)
            {
                salida = " No se conecto: " + ex.ToString();
            }

            return salida;
        
        }

        public int productosregistrado(int id)
        {

            int contador = 0;

            try
            {
                cmd = new SqlCommand("Select * from Productos where ID_Producto="+id+" ", cn);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se puedo consultar bien: " + ex.ToString());
            }

            return contador;

        }

        public void cargarProductos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Productos", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch(Exception ex)
            {

                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
        }






    }
}
