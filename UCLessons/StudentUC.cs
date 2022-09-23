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
    public partial class StudentUC : UserControl
    {
 
        public string Name
        {
            get { return nameLbl.Text; }
            set { nameLbl.Text=value; }
        }

        public int Age
        {
            get { return int.Parse(ageLbl.Text); }
            set { ageLbl.Text = value.ToString(); }
        }

        public StudentUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Student : {Name} : Age : {Age}");
        }
    }
}
