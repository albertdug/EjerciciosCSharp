using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace darFormatoTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = color.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.Font = richTextBox1.Font;
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }
        }
    }
}
