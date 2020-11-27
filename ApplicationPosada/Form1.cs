using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationPosada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Asignamos al boton del formulario las funciones para que busque los datos requeridos 
        //segun sea el id del alumno
        private void button1_Click(object sender, EventArgs e)
        {
            ServiceAlumnos.Service1Client reques_data = new ServiceAlumnos.Service1Client();
            string[] info_alumno;
            info_alumno = reques_data.ver_alumno(textBox1.Text);
            textBox2.Text = info_alumno[0];
            textBox3.Text = info_alumno[1];
            textBox4.Text = info_alumno[2];
            textBox5.Text = info_alumno[3];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
