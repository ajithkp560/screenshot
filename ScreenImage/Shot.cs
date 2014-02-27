using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenImage
{
    public partial class Shot : Form
    {
        Bitmap mm;
        public Shot()
        {
            InitializeComponent();
        }

        public Shot(Bitmap map)
        {
            InitializeComponent();
            mm = map;
            this.WindowState = FormWindowState.Maximized;
            this.pictureBox1.Width = map.Width;
            this.pictureBox1.Height = map.Height;
            this.pictureBox1.Image = map;
            //this.BackgroundImage = map;
        }

        void SaveFile(Bitmap map)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            map.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                            break;

                        case 2:
                            map.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                            break;

                        case 3:
                            map.Save(saveFileDialog1.FileName, ImageFormat.Gif);
                            break;
                        case 4:
                            map.Save(saveFileDialog1.FileName, ImageFormat.Png);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(mm);
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/ajithkp560");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
