using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _OLC2_Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.addToPage();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ejecutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void albunDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addToPage();
        }

        private void addToPage()
        {
            int page = this.tabControl.TabPages.Count;
            String title = "Pagina " + page.ToString();

            TabPage tbPage = new TabPage(title);
            tbPage.Name = page.ToString();
            RichTextBox rcText = new RichTextBox();

            rcText.Width = tabControl.Width - 10;
            rcText.Height = tabControl.Height;
            rcText.ScrollToCaret();

            tbPage.Controls.Add(rcText);
            this.tabControl.TabPages.Add(tbPage);
        }

        private void ejecutarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int page = this.tabControl.SelectedIndex;

            foreach (TabPage t in tabControl.TabPages)
            {
                if (page.ToString().Equals( t.Name))
                {
                    foreach (Control c in t.Controls)
                    {
                        if (c is RichTextBox)
                        {
                            this.initGramatica(c.Text);
                        }
                    }
                }
            }
        }

        public void initGramatica(String texto)
        {
            Console.WriteLine(texto);
        }
    }
}
