using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackQueueProject
{

    public partial class Form1 : Form
    {

        Queue queue1 = new Queue();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            queue1.add(Convert.ToInt32(InputTextBox.Text));
            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            queue1.remove(Convert.ToInt32(InputTextBox));
        }

        private void ModeSwitchButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
