using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jiamiben;

namespace YPassword
{
    public partial class SearchDialog : Form
    {
        Form parent = null;
        TextBox rtext = null;
        public SearchDialog(Form p, TextBox r)
        {
            parent = p;
            rtext = r;
            InitializeComponent();
        }

        private void SearchDialog_Load(object sender, EventArgs e)
        {
            int x = parent.Left + parent.Width / 2 - this.Width / 2;
            int y = parent.Top + parent.Height / 2 - this.Height / 2;
            this.Location = new Point(x, y);
            this.Focus();
            txtSearchText.Focus();
        }
        int curIndex = -1;
        int searhStart = -1;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String searchText = txtSearchText.Text;
            String curText = rtext.Text;
            if (curText != "")
            {
                
                int index = -1;
                curIndex = KMP(curText, searchText, searhStart+1);
                if (curIndex != -1)
                {
                    rtext.SelectionStart = curIndex;
                    rtext.SelectionLength = searchText.Length;
                    parent.Focus();
                    searhStart = curIndex;
                    Console.WriteLine("从第{0}个字符开始匹配", index + 1);
                }
                else
                {
                    Console.WriteLine("{0}", "没有找到匹配");
                }
               
            }

        }

        void GetNext(string s, int[] next)
        {
            int m = 0;
            int n = -1;
            next[0] = -1;
            while (m + 1 < s.Length)
            {
                if (n == -1 || s[m] == s[n])
                {
                    ++m;
                    ++n;
                    if (s[m] != s[n])
                        next[m] = n;
                    else
                        next[m] = next[n];
                }
                else
                {
                    n = next[n];
                }
            }
        }

        int KMP(string sString, string dString, int pos)
        {
            int i = pos;
            int j = 0;
            int index = 0;
            int[] next = new int[dString.Length + 1];
            GetNext(dString, next);
            while (i < sString.Length && j < dString.Length)
            {
                if (sString[i] == dString[j])
                {
                    ++i;
                    ++j;
                }
                else
                {
                    index += j - next[j];
                    if (next[j] != -1)
                        j = next[j];
                    else
                    {
                        j = 0;
                        ++i;
                    }
                }
            }
            next = null;
            if (j == dString.Length)
                return index;
            else
                return -1;
        }

        private void SearchDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            DesViewer viewer = parent as DesViewer;
            viewer.search = null;
        }

    }

}
