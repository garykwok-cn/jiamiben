using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jiamiben
{
    public partial class PwdInput : Form
    {
        public PwdInput()
        {
            InitializeComponent();
        }
        DesViewer viewer = null;
        public PwdInput(DesViewer parent)
        {
            InitializeComponent();
            viewer = parent;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text.Length==0)
            {
                return;                
            }
            viewer.Pwd = txtPwd.Text;
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void PwdInput_Load(object sender, EventArgs e)
        {
            txtPwd.Select();
        }

        private void PwdInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }
    }
}
