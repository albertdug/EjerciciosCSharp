using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;

namespace miniReproductorVideo
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        string ruta;
        string comandoMCI;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Liberar si ya se encontraba cargado un video
            mciSendString("stop miVideo", null, 0, IntPtr.Zero);
            mciSendString("close miVideo", null, 0, IntPtr.Zero);

            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.Filter = "Archivos de video|*.avi;*.mpeg;";
            abrirArchivo.ShowDialog();

            ruta = abrirArchivo.FileName;

            //Abrir el dispositivo MCI
            comandoMCI = string.Format("open \"{0}\" type mpegvideo alias miVideo wait", ruta);
            long respuesta = mciSendString(comandoMCI, null, 0, IntPtr.Zero);
            comandoMCI = "window miVideo handle " + this.pictureBox1.Handle.ToString();
            mciSendString(comandoMCI, null, 0, IntPtr.Zero);
            comandoMCI = "put miVideo destination at 0 0 " + this.pictureBox1.Width.ToString() + " " + this.pictureBox1.Height.ToString() + " wait";
            mciSendString(comandoMCI, null, 0, IntPtr.Zero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comandoMCI = string.Format("play miVideo");
            mciSendString(comandoMCI, new StringBuilder(), 0, IntPtr.Zero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comandoMCI = string.Format("pause miVideo");
            mciSendString(comandoMCI, new StringBuilder(), 0, IntPtr.Zero);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comandoMCI = "seek miVideo to start";
            mciSendString(comandoMCI, null, 0, IntPtr.Zero);
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(sInfo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://github.com/albertdug/EjerciciosCSharp");
        }
    }
}