using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA3._9.GeneticAlgorithm
{
    public partial class FormMain : Form
    {
        Genetic gen = new Genetic(100, 20, 25);

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int it = 0;
            gen.Solution(out it);
            label1.Text = it.ToString();
        }
    }
}
