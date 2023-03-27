using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenhVien.Forms;

namespace QuanLyBenhVien
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //TabMain.TabPages.Clear();

            // Đặt vị trí close button
            TabMain.Padding = new Point(15, 3);
            TabMain.SizeMode = TabSizeMode.Normal;
            TabMain.DrawMode = TabDrawMode.OwnerDrawFixed;


            fLogin fr = new fLogin();
            fr.ShowDialog();

        }

        private void TabMain_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                // Select tabpage vừa mở
                TabMain.SelectedIndex = TabMain.TabPages.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                goto TheEnd;
            }

            TheEnd:
            return;
        }

        private void TabMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            Bitmap bitmap = QuanLyBenhVien.Properties.Resources.closeTab;
            TabPage tabPage = TabMain.TabPages[e.Index];
            Rectangle tabRect = TabMain.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);

            Image closeImage = new Bitmap(bitmap);
            e.Graphics.DrawImage(closeImage,
                (tabRect.Right - closeImage.Width),
                tabRect.Top + (tabRect.Height - closeImage.Height) / 2);

            if (e.Index != TabMain.SelectedIndex)
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);

            if (e.Index == TabMain.SelectedIndex)
            {
                e.Graphics.DrawString(TabMain.TabPages[e.Index].Text,
                    new Font(TabMain.Font, FontStyle.Bold),
                    Brushes.Blue,
                    new PointF(e.Bounds.X + 3, e.Bounds.Y + 3));
            }
        }

        private void TabMain_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Point imgHitArea = new Point(15, 3);
                TabControl tabc = (TabControl)sender;
                Point point = e.Location;
                int tabWidth = TabMain.GetTabRect(tabc.SelectedIndex).Width - (imgHitArea.X);
                Rectangle rec = TabMain.GetTabRect(tabc.SelectedIndex);
                rec.Offset(tabWidth, imgHitArea.Y);
                rec.Width = 16;
                rec.Height = 16;

                if (tabc.SelectedIndex == 0)
                {
                    goto TheEnd;
                }

                bool containPoint = rec.Contains(point);
                if (containPoint != false)
                {
                    TabPage tabP = tabc.TabPages[tabc.SelectedIndex];
                    tabc.TabPages.Remove(tabP);
                    tabc.SelectedIndex = tabc.TabPages.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                goto TheEnd;
            }

            TheEnd:
            return;
        }

        /// <summary>
        /// <para>Add tabpage</para>
        /// </summary>
        /// <param name="name"></param>
        private void AddTabPageNew(string name, Form uc, int index)
        {
            foreach (TabPage tab in TabMain.TabPages)
            {
                if (tab.Text == name)
                {
                    TabMain.SelectedTab = tab;
                    goto TheEnd;
                }
            }

            AddTab(TabMain, name, uc, index);

            TheEnd:
            return;
        }

        public void AddTab(TabControl tabcontrol, string TabNameAdd, Form uc, int imgIndex)
        {
            // Khởi tạo 1 Tab Con
            TabPage tabAdd = new TabPage();
            // Đặt đại cái tên cho nó là TestTab
            tabAdd.Name = uc.Name;
            // Tên của nó là đối số như đã nói ở trên
            tabAdd.Text = TabNameAdd;
            // Add đối số UserControl vào Tab con vừa khởi tạo ở trên
            uc.TopLevel = false;
            uc.Visible = true;
            uc.FormBorderStyle = FormBorderStyle.None;
            uc.Dock = DockStyle.Fill;
            //tabControl1.TabPages[0].Controls.Add(frm);
            tabAdd.Controls.Add(uc);
            // Dock cho nó tràn hết TAb con đó
            uc.Dock = DockStyle.Fill;

            tabAdd.ImageIndex = imgIndex;

            // Quăng nó lên TAb Cha
            tabcontrol.TabPages.Add(tabAdd);
        }


        private void SetButtonColor(Button defaultBtn, Button changeBtn)
        {
            changeBtn.BackColor = Color.LightGray;
            changeBtn.ForeColor = Color.Black;

            defaultBtn.BackColor = Color.Gray;
            defaultBtn.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (Control btn in PnlLeft.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            //{
            //    if (btn is Button && btn.Name != button1.Name)
            //    {
            //        SetButtonColor((Button)btn, (sender as Button));
            //    }
            //}

            //Form1 form1 = new Form1();
            //form1.TopLevel = false;
            //AddTabPageNew("Mở form 1", form1, 0);           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //// Thay đổi màu background
            //foreach (Control btn in PnlLeft.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            //{
            //    if (btn is Button && btn.Name != button2.Name)
            //    {
            //        SetButtonColor((Button)btn, (sender as Button));
            //    }
            //}

            //Form2 form1 = new Form2();
            //form1.TopLevel = false;
            //AddTabPageNew("Mở form 2", form1, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //// Thay đổi màu background
            //foreach (Control btn in PnlLeft.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            //{
            //    if (btn is Button && btn.Name != button3.Name)
            //    {
            //        SetButtonColor((Button)btn, (sender as Button));
            //    }
            //}

            //Form3 form1 = new Form3();
            //form1.TopLevel = false;
            //AddTabPageNew("Mở form 3", form1, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //// Thay đổi màu background
            //foreach (Control btn in PnlLeft.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            //{
            //    if (btn is Button && btn.Name != button4.Name)
            //    {
            //        SetButtonColor((Button)btn, (sender as Button));
            //    }
            //}

            //Form4 form1 = new Form4();
            //form1.TopLevel = false;
            //AddTabPageNew("Mở form 4", form1, 0);
        }

        private void TsmiClose_Click(object sender, EventArgs e)
        {
            if (TabMain.SelectedIndex == 0)
            {
                goto TheEnd;
            }

            TabPage tabP = TabMain.TabPages[TabMain.SelectedIndex];
            TabMain.TabPages.Remove(tabP);
            TabMain.SelectedIndex = TabMain.TabPages.Count - 1;

            TheEnd:
            return;
        }

        private void TsmiCloseAll_Click(object sender, EventArgs e)
        {
            TabPage tabP = TabMain.TabPages[TabMain.SelectedIndex];
            string nameSelect = tabP.Name;

            for (int i = 1; i < TabMain.TabPages.Count; i++)
            {
                if (TabMain.TabPages[i].Name != nameSelect)
                {
                    TabMain.TabPages.RemoveAt(i);
                    i -= 1;
                }
            }
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fTiepNhan fr = new fTiepNhan();
            fr.TopLevel = false;
            AddTabPageNew(fr.Text, fr, 0);
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhamBenh fr = new fKhamBenh();
            fr.TopLevel = false;
            AddTabPageNew(fr.Text, fr, 0);
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass fr = new frmClass();
            fr.TopLevel = false;
            AddTabPageNew(fr.Text, fr, 0);
        }

        private void form3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fLoaiKham fr = new fLoaiKham();
            fr.TopLevel = false;
            AddTabPageNew(fr.Text, fr, 0);
        }

        private void phòngKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhongKham fr = new fPhongKham();
            fr.TopLevel = false;
            AddTabPageNew(fr.Text, fr, 0);
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDichVu fr = new fDichVu();
            fr.TopLevel = false;
            AddTabPageNew(fr.Text, fr, 0);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhanVien fr = new fNhanVien();
            fr.TopLevel = false;
            AddTabPageNew(fr.Text, fr, 0);

        }

        private void đơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDonViTinh fr = new fDonViTinh();
            fr.TopLevel = false;
            AddTabPageNew(fr.Text, fr, 0);
        }

        private void dânTộcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDanToc fr = new fDanToc();
            fr.TopLevel = false;
            AddTabPageNew(fr.Text, fr, 0);
        }

        private void quốcTịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuocTich fr = new fQuocTich();
            fr.TopLevel = false;
            AddTabPageNew(fr.Text, fr, 0);
        }

        private void việnPhíToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fVienPhi fr = new fVienPhi();
            fr.TopLevel = false;
            AddTabPageNew(fr.Text, fr, 0);
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapKho fr = new fNhapKho();
            fr.TopLevel = false;
            AddTabPageNew(fr.Text, fr, 0);
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXuatKho fr = new fXuatKho();
            fr.TopLevel = false;
            AddTabPageNew(fr.Text, fr, 0);
        }
    }
}
