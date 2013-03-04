using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyFF_Character_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sexes = Enum.GetNames(typeof(Character.Sex));
            foreach(string sex in sexes)
                SexBox.Items.Add(sex);
        }

        private void SexBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
