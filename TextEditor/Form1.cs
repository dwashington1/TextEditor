using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public SaveBeforeClose SBC = new SaveBeforeClose();
        public bool saved = false;
        public DataHolder contents;
        
        //public string contents;
        public Form1()
        {
            InitializeComponent();
            Name = "MainForm";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //only shows up if the file hasn't been saved
            if (!saved)
            {
                SBC.Visible = true;
                contents = new DataHolder(richTextBox1.Text);
                SBC.contents = contents;
                //contents = richTextBox1.Text;
                
                //TODO: Include popup window asking to save original file before closing
                richTextBox1.Text = "";
                
            }
        }

        public void Post_Click_NewCancelbutton()
        {
            if (SBC.clear == false)
            {
                richTextBox1.Text = contents.Hold;
            }
        }
    }
}
