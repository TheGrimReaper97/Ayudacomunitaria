﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=localhost ; database=Ayuda_Comunitaria; integrated security = true");

        public void logear(string usuario, string contrasena)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre,Tipo_usuario FROM usuarios WHERE Usuario = @usuario AND Password = @pas", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Bienvenido");
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecto");
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                con.Close();

            }

        }






        private void btningresaru_Click(object sender, EventArgs e)
        {
            logear(this.txtusurio.Text, this.txtcontraseña.Text);

        }

        private void btnsaliru_Click(object sender, EventArgs e)
        {
            Application.Exit();

            Application.ExitThread();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //CODIGO PARA MOVER VENTANA--------------------------------------
        int posY = 0;
        int posX = 0;
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
        //---------------------------------------------------------------------



        private void txtusurio_MouseClick(object sender, MouseEventArgs e)
        {
            txtusurio.Clear();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtusurio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_MouseClick(object sender, MouseEventArgs e)
        {
            txtcontraseña.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuarios f2 = new RegistroUsuarios();
            f2.Show();
        }
    }


   
}
