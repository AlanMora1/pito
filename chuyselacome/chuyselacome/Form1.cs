using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuyselacome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
                if (joto.Text == "juancho")
                {
                    if (joto2.Text == "123tamarindo")
                        MessageBox.Show("Hola Juancho");
                    else
                        MessageBox.Show("TU PUTA contraseña es incorrecta");
                }
                else
                    MessageBox.Show("PON BIEN TU USUARIO PENDEJO");
            }
        }
    }
