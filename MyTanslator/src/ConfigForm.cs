using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTanslator
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add("Item");
                
            }
            listBox1.SelectedIndex = 0;
            

        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            groupBox_main.Text = listBox1.SelectedIndex.ToString();
        }
    }
}
