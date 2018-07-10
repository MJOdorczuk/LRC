using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LRCform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DummyButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            DummyWindowControler.DisplayFallingBalls(formGraphics, 10, 10, 600, 600);
            formGraphics.Dispose();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            

        }
    }
}
