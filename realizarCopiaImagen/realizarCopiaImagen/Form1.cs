using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace realizarCopiaImagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Realizar Copia de Imagen";
            BuscarImagen.InitialDirectory = "C:\\";
            BuscarImagen.FileName = this.txtImagen.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                this.txtImagen.Text = BuscarImagen.FileName;
                this.pictureBox1.ImageLocation = txtImagen.Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String NombreArchivo;
            NombreArchivo = System.IO.Path.GetFileNameWithoutExtension(txtImagen.Text);
            Bitmap Picture = new Bitmap(txtImagen.Text);
            Picture.Save(@"C:\" + NombreArchivo + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("Se guardo la Copia correctamente en C:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String NombreArchivo;
            NombreArchivo = System.IO.Path.GetFileNameWithoutExtension(txtImagen.Text);
            Bitmap Picture = new Bitmap(txtImagen.Text);
            Picture.Save(@"C:\" + NombreArchivo + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            MessageBox.Show("Se guardo la Copia correctamente en C:");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String NombreArchivo;
            NombreArchivo = System.IO.Path.GetFileNameWithoutExtension(txtImagen.Text);
            Bitmap Picture = new Bitmap(txtImagen.Text);
            Picture.Save(@"C:\" + NombreArchivo + ".png", System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("Se guardo la Copia correctamente en C:");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String NombreArchivo;
            NombreArchivo = System.IO.Path.GetFileNameWithoutExtension(txtImagen.Text);
            Bitmap Picture = new Bitmap(txtImagen.Text);
            Picture.Save(@"C:\" + NombreArchivo + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
            MessageBox.Show("Se guardo la Copia correctamente en C:");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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