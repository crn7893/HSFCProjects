using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewOneArmedBanditProject.Properties;

namespace NewOneArmedBanditProject
{
    public partial class Form1 : Form
    {
        private Image[] slotWheelImages = { Resources.Pikachu_Win, Resources.Strawberry_Image, Resources.raspberry_Image, };


        int num = '0';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            slotBox1.Image = Resources.Strawberry_Image;
            slotBoxMiddle.Image = Resources.Pikachu_Win;
            slotBoxLast.Image = Resources.raspberry_Image;
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
