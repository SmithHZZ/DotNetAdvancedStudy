using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_thread._06_exception_handle
{
    public partial class ExceptionHandleWindow : Form
    {
        public ExceptionHandleWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExceptionHandleTest.Test01();
        }
    }
}
