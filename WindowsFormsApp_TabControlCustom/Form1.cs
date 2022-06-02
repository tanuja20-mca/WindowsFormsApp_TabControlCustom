using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_TabControlCustom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cnt = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            tabControlX1.AddTab("Tab " + cnt, null);
            cnt++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TabPanelControl tpc = new TabPanelControl();
            tpc.Dock = DockStyle.Fill;
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;
            tpc.Controls.Add(rtb);
            tabControlX1.AddTab("Tab " + cnt, tpc);
            cnt++;
        }

        private void tabControlX1_Load(object sender, EventArgs e)
        {

        }
    }
}
