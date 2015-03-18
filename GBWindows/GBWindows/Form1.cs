using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GBWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            list.Add(new UCItemSaveLandP15());
            list.Add(new UCItemSaveLandL15());
            list.Add(new UCItemSaveLand14());
            list.Add(new UCItemSaveLand13());
            list.Add(new UCItemSaveLand12());
            list.Add(new UCItemSaveLandP11());
            list.Add(new UCItemSaveLandL11());
            list.Add(new UCItemSaveLand10());
        }

        private void Form1_Load(object sender, EventArgs ee)
        {
            panel1.Controls.Add(list[index]);
        }

        public List<UserControl> list = new List<UserControl>();
        private int index = 0;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                panel1.Controls.Clear();
                panel1.Controls.Add(list[index]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index < list.Count - 1)
            {
                index++;
                panel1.Controls.Clear();
                panel1.Controls.Add(list[index]);
            }
        }

    }
}
