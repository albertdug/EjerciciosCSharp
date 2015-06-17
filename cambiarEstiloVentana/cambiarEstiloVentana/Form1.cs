using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace cambiarEstiloVentana
{
    public partial class Form1 : Form
    {
        [DllImport("UxTheme")]
        private static extern void SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        [DllImport("UxTheme")]
        private static extern void SetWindowTheme(IntPtr hWnd, int pszSubAppName, int pszSubIdList); 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetWindowTheme(this.Handle, "", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetWindowTheme(this.Handle, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://github.com/albertdug/EjerciciosCSharp.git");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(sInfo);
        }
    }
}