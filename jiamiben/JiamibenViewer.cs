using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Security.Cryptography;
using YPassword;

namespace Jiamiben
{
    public partial class DesViewer : Form
    {
        public DesViewer()
        {
            InitializeComponent();
        }
        public int nameIndex = 1;
        private String pwd = "";
        public SearchDialog search = null;
        public String Pwd
        {
            get { return pwd; }
            set
            {
                pwd = Common.MD5Encoding(value, "U&Y^T%").Substring(0, 8);
            }
        }
        public String path = "";
        public DesViewer(String filepath)
        {
            InitializeComponent();
            path = filepath;
        }

        private void DesViewer_Load(object sender, EventArgs e)
        {
            string strExtension = ".jmb";

            string strProject = "jiamiben";

            Registry.ClassesRoot.CreateSubKey(strExtension).SetValue("", strProject, RegistryValueKind.String);

            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(strProject))
            {
                string strExePath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
                strExePath = Path.GetDirectoryName(strExePath);
                strExePath += "\\jiamiben.exe";
                key.CreateSubKey(@"Shell\Open\Command").SetValue("", strExePath + " \"%1\"", RegistryValueKind.ExpandString);
            }
        }

        private void 打开加密文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "加密文件(*.jmb)|*.jmb";

            ofd.ShowDialog();
            String fileName = ofd.FileName;
            if (fileName != "")
            {
                ShowPwdInputDialog(fileName);
            }

        }

        public void ShowPwdInputDialog(String fileName)
        {
            PwdInput input = new PwdInput(this);
            DialogResult dr = input.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                String PwdText = File.ReadAllText(fileName, Encoding.UTF8);
                FileInfo fileInfo = new FileInfo(fileName);
                TabPage page = new TabPage(fileInfo.Name.Replace(fileInfo.Extension,""));
                page.Tag = "1|" + Pwd;
                page.ToolTipText = fileName;
                TextBox txtPwd = new TextBox();
                Font font = new System.Drawing.Font("微软雅黑", 11, FontStyle.Regular);
                txtPwd.Font = font;
                txtPwd.Multiline = true;
                txtPwd.ScrollBars = ScrollBars.Vertical;
                txtPwd.Dock = DockStyle.Fill;
                try
                {
                    txtPwd.Text = Common.DESDecrypt(PwdText, pwd);
                    page.Controls.Add(txtPwd);
                    tabs.TabPages.Add(page);
                    tabs.SelectedTab = page;
                }
                catch (Exception)
                {
                    DialogResult ddr = MessageBox.Show("打开失败！密码错误或文件格式不对。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ddr == System.Windows.Forms.DialogResult.OK)
                    {
                        ShowPwdInputDialog(fileName);
                    }
                }

            }
        }

        void page_DoubleClick(object sender, EventArgs e)
        {
            TabPage curPage = sender as TabPage;
            tabs.TabPages.Remove(curPage);
        }

        private void DesViewer_Activated(object sender, EventArgs e)
        {

        }

        private void DesViewer_Shown(object sender, EventArgs e)
        {
            if (path != "")
            {
                PwdInput input = new PwdInput(this);
                DialogResult dr = input.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    String PwdText = File.ReadAllText(path, Encoding.UTF8);
                    FileInfo fileInfo = new FileInfo(path);
                    TabPage page = new TabPage(fileInfo.Name);
                    page.Tag = "1" + "|" + pwd;
                    page.ToolTipText = path;
                    TextBox txtPwd = new TextBox();
                    Font font = new System.Drawing.Font("微软雅黑", 11, FontStyle.Regular);
                    txtPwd.Font = font;
                    txtPwd.Multiline = true;
                    txtPwd.ScrollBars = ScrollBars.Vertical;
                    txtPwd.Dock = DockStyle.Fill;
                    try
                    {
                        txtPwd.Text = Common.DESDecrypt(PwdText, pwd);
                        page.Controls.Add(txtPwd);
                        tabs.TabPages.Add(page);
                        tabs.SelectedTab = page;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("打开失败！密码错误或文件格式不对。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                TabPage page = new TabPage("加密本" + nameIndex);
                page.Tag = "0" + "|";
                page.ToolTipText = "";
                TextBox txtPwd = new TextBox();
                Font font = new System.Drawing.Font("微软雅黑", 11, FontStyle.Regular);
                txtPwd.Font = font;
                txtPwd.Multiline = true;
                txtPwd.ScrollBars = ScrollBars.Vertical;
                txtPwd.Dock = DockStyle.Fill;
                page.Controls.Add(txtPwd);
                tabs.TabPages.Add(page);
                tabs.SelectedTab = page;
                nameIndex++;
            }
        }

        private void 新建文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage("加密本" + nameIndex + ".jmb");
            TextBox txtPwd = new TextBox();
            Font font = new System.Drawing.Font("微软雅黑", 11, FontStyle.Regular);
            txtPwd.Font = font;
            txtPwd.Multiline = true;
            txtPwd.ScrollBars = ScrollBars.Vertical;
            txtPwd.Dock = DockStyle.Fill;


            page.Controls.Add(txtPwd);
            page.Tag = "0" + "|";
            page.ToolTipText = "";

            tabs.TabPages.Add(page);
            tabs.SelectedTab = page;
            nameIndex++;
        }

        private void 保存文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage curPage = tabs.SelectedTab;
            String tag = "";
            if (curPage != null)
            {
                TextBox curTextBox = curPage.Controls[0] as TextBox;
                if (curTextBox.Text == "")
                {
                    return;
                }
                tag = curPage.Tag.ToString();
                //打开的文件
                if (tag.StartsWith("1|"))
                {
                    FileInfo fileInfo = new FileInfo(curPage.ToolTipText);
                    try
                    {
                        String txt = Common.DESEncrypt(curTextBox.Text, tag.Remove(0, 2));
                        File.WriteAllText(curPage.ToolTipText, txt);
                    }
                    catch (Exception ex)
                    {
                        Common.WriteLog("保存已创建的文件：" + ex.Message);
                        MessageBox.Show("保存失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //新建的文件
                else if (tag.StartsWith("0|"))
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "加密文件(*.jmb)|*.jmb";
                    sfd.Title = "保存加密文件";
                    sfd.FileName = curPage.Text + "";
                    DialogResult dr = sfd.ShowDialog();
                    if (dr == System.Windows.Forms.DialogResult.OK)
                    {
                        PwdInput input = new PwdInput(this);
                        DialogResult drr = input.ShowDialog();
                        if (drr == System.Windows.Forms.DialogResult.OK)
                        {
                            try
                            {
                                String txt = Common.DESEncrypt(curTextBox.Text, Pwd);
                                File.WriteAllText(sfd.FileName, txt);
                            }
                            catch (Exception ex)
                            {
                                Common.WriteLog("保存新建的文件：" + ex.Message);
                                MessageBox.Show("保存失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            FileInfo fileInfo = new FileInfo(sfd.FileName);
                            curPage.Text = fileInfo.Name;
                            curPage.Tag = "1|" + Pwd;
                            curPage.ToolTipText = sfd.FileName;
                        }
                    }

                }


            }
        }

        private void 另存为RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage curPage = tabs.SelectedTab;
            String tag = "";
            if (curPage != null)
            {
                TextBox curTextBox = curPage.Controls[0] as TextBox;
                if (curTextBox.Text == "")
                {
                    return;
                }
                tag = curPage.Tag.ToString();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "保存加密文件";
                sfd.Filter = "加密文件(*.jmb)|*.jmb";
                sfd.FileName = curPage.Text + "";
                DialogResult dr = sfd.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    PwdInput input = new PwdInput(this);
                    DialogResult drr = input.ShowDialog();
                    if (drr == System.Windows.Forms.DialogResult.OK)
                    {
                        try
                        {
                            String txt = Common.DESEncrypt(curTextBox.Text, Pwd);
                            File.WriteAllText(sfd.FileName, txt);
                        }
                        catch (Exception ex)
                        {
                            Common.WriteLog("另存文件：" + ex.Message);
                            MessageBox.Show("保存失败！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        FileInfo fileInfo = new FileInfo(sfd.FileName);
                        curPage.Text = fileInfo.Name;
                        curPage.Tag = "1|" + Pwd;
                        curPage.ToolTipText = sfd.FileName;
                    }
                }
            }
        }

        private void DesViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tabs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (tabs.TabPages.Count > 1)
                {
                    TabPage curPage = tabs.SelectedTab;
                    if (curPage.Tag.ToString().StartsWith("0|"))
                    {
                        DialogResult dr = MessageBox.Show("\"" + curPage.Text + "\"需要保存吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == System.Windows.Forms.DialogResult.Yes)
                        {
                            保存文件ToolStripMenuItem_Click(curPage, null);
                        }
                        else
                        {
                            int x = e.X, y = e.Y;
                            //计算关闭区域     
                            Rectangle myTabRect = tabs.GetTabRect(tabs.SelectedIndex);
                            //如果鼠标在区域内就关闭选项卡     
                            bool isClose = myTabRect.Contains(new Point(e.X, e.Y));
                            if (isClose)
                            {
                                tabs.TabPages.Remove(tabs.SelectedTab);
                            }
                        }
                    }
                    else
                    {
                        int x = e.X, y = e.Y;
                        //计算关闭区域     
                        Rectangle myTabRect = tabs.GetTabRect(tabs.SelectedIndex);
                        //如果鼠标在区域内就关闭选项卡     
                        bool isClose = myTabRect.Contains(new Point(e.X, e.Y));
                        if (isClose)
                        {
                            tabs.TabPages.Remove(tabs.SelectedTab);
                        }
                    }
                }
            }
        }
        private void tabs_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control && e.KeyCode == Keys.F) || e.KeyCode == Keys.F3)
            {
                if (filterPanel.Visible)
                {
                    filterPanel.Visible = false;
                }
                else
                {
                    filterPanel.Visible = true;
                    txtSearch.Focus();
                }
            }
            if ((e.Modifiers == Keys.Control && e.KeyCode == Keys.A))
            {
                TabPage tab = tabs.SelectedTab;
                TextBox rtext = tab.Controls[0] as TextBox;
                rtext.SelectAll();
            }
        }


        int curIndex = -1;
        int curIndexSubfix = 0;
        List<int> indexList = new List<int>();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            TabPage tab = tabs.SelectedTab;
            TextBox rtext = tab.Controls[0] as TextBox;
            String searchText = txtSearch.Text;
            String curText = rtext.Text;
            String btnText = btnSearch.Text;
            if (btnText.Equals("查找"))
            {
                indexList = getAllIndex(curText, searchText);
                lblMatch.Text = indexList.Count + "个匹配项";
                // 选中第一项
                if (indexList.Count > 0)
                {
                    rtext.SelectionStart = indexList[0];
                    curIndex = indexList[0];
                    curIndexSubfix = 0;
                    rtext.SelectionLength = searchText.Length;
                    rtext.Focus();
                    rtext.ScrollToCaret();
                    if (indexList.Count > 1)
                    {
                        btnSearch.Text = "下一个";
                        btnPre.Visible = true;
                    }
                }
            }
            else if (btnText.Equals("下一个"))
            {
                if (indexList.Count > 0)
                {
                    curIndexSubfix++;
                    if (curIndexSubfix >= indexList.Count)
                    {
                        curIndex = indexList[0];
                        curIndexSubfix = 0;
                    }
                    else
                    {
                        curIndex = indexList[curIndexSubfix];
                    }
                    rtext.SelectionStart = curIndex;
                    rtext.SelectionLength = searchText.Length;
                    rtext.Focus();
                    rtext.ScrollToCaret();
                }
            }
        }


        public List<int> getAllIndex(String sourceStr, String key)
        {
            if (chbIgnoreCase.Checked)
            {
                sourceStr = sourceStr.ToLower();
                key = key.ToLower();
            }
            List<int> indexList = new List<int>();

            int index = -1;
            int cutlen = 0;
            while (sourceStr.IndexOf(key) != -1)
            {
                index = sourceStr.IndexOf(key);
                indexList.Add(index + cutlen);
                cutlen = cutlen + index + key.Length;
                sourceStr = sourceStr.Substring(index + key.Length);
            }
            return indexList;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Text = "查找";
            lblMatch.Text = "";
            btnPre.Visible = false;
            indexList.Clear();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            filterPanel.Visible = false;
        }

        private void chbIgnoreCase_CheckedChanged(object sender, EventArgs e)
        {
            btnSearch.Text = "查找";
            lblMatch.Text = "";
            indexList.Clear();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            TabPage tab = tabs.SelectedTab;
            TextBox rtext = tab.Controls[0] as TextBox;
            String searchText = txtSearch.Text;
            if (indexList.Count > 0)
            {
                curIndexSubfix--;
                if (curIndexSubfix <= 0)
                {
                    curIndex = indexList[0];
                    curIndexSubfix = 0;
                }
                else
                {
                    curIndex = indexList[curIndexSubfix];
                }
                rtext.SelectionStart = curIndex;
                rtext.SelectionLength = searchText.Length;
                rtext.Focus();
                rtext.ScrollToCaret();
            }
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            filterPanel.Height = 28;
            filterPanel.Location = new Point(0, this.Height - 98);
        }


    }
}
