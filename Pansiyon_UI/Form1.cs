using Pansiyon_UI.UI_Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            MusterilerForm musterilerForm = new MusterilerForm();
            musterilerForm.Show();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            OdalarForm odalarForm = new OdalarForm();
            odalarForm.Show();
        }
    }
}
