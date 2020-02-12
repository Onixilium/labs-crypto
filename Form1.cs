using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace codes1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCesCode_Click(object sender, EventArgs e)
        {
            coding_one.Caesar caesar = new coding_one.Caesar();
            txtCode.Text = caesar.code(txtOriginal.Text,Convert.ToInt32(txtKey.Text));
            txtDecode.Text = caesar.code(txtCode.Text,-Convert.ToInt32(txtKey.Text));

        }

        private void BtnLozung_Click(object sender, EventArgs e)
        {
            coding_one.slogan slogan = new coding_one.slogan();
            txtCode.Text = slogan.Code(txtKeyString.Text,txtOriginal.Text);
            
        }
    }
}
