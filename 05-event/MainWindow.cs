using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_event
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            Load += button1_Click;

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Console.WriteLine("MainWindow_Load");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button1_Click");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
