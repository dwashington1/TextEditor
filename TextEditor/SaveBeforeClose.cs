using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class SaveBeforeClose : Form
    {
        public SaveBeforeClose()
        {
            InitializeComponent();
        }

        public bool clear = false;
        public DataHolder contents;
        private void button3_Click(object sender, EventArgs e)
        {
            clear = false;
            Visible = false;
            
            Form1 temp = new Form1();
            temp.contents = contents;
            temp.Post_Click_NewCancelbutton();
            temp.Visible = true;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            clear = true;
            //Form1 temp = new Form1();
            //temp.contents = contents;
            //temp.Post_Click_NewCancelbutton();
            //components = null;
        }
    }
}
