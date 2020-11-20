using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ayuda_Comunitaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresaru_Click(object sender, EventArgs e)
        {
            this.Hide();
             Form2 f2 = new Form2();
               f2.Show();

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
    }


   
}
