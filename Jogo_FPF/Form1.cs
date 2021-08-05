using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_FPF
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


        private void bt_ranking_Click(object sender, EventArgs e)
        {
            Jogo OutroFrom = new Jogo();
            OutroFrom.ShowDialog();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            Jogo OutroFrom = new Jogo();
            OutroFrom.ShowDialog();
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            Home OutroForm = new Home();
            OutroForm.ShowDialog();
        }
    }
}
