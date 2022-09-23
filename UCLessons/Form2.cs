using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCLessons
{
    public partial class Form2 : Form
    {
        public List<Student> Students = new List<Student>
        {
            new Student
            {
                Name="Aysel",
                Age=25
            },
            new Student
            {
                Name="Leyla",
                Age=30
            },
            new Student
            {
                Name="Arif",
                Age=60
            },
        };
        public int Y { get; set; }
        public Form2()
        {
            InitializeComponent();

            foreach (var student in Students)
            {
                var usercontrol = new StudentUC
                {
                    Name = student.Name,
                    Age = student.Age,
                };
                usercontrol.Location = new Point(0, Y);
                Y += 100;
                this.Controls.Add(usercontrol);
            }

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
