using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForms_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want open Application", "Ask client", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)

                Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID.Text) || string.IsNullOrEmpty(txt_Name.Text) || string.IsNullOrEmpty(txt_Password.Text))

            {

                MessageBox.Show("You have not entered full information !!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else

            {

                // tạo mới một ListViewItem

                ListViewItem lstvItem = new ListViewItem();

                lstvItem.Text = txt_Name.Text;

                ListViewItem.ListViewSubItem lstvsub = new ListViewItem.ListViewSubItem(lstvItem, txt_Password.Text);

                ListViewItem.ListViewSubItem lstvsub1 = new ListViewItem.ListViewSubItem(lstvItem, txt_ID.Text);

                // thêm các thông tin vào các cột tương ứng trong ListView

                lstvItem.SubItems.Add(lstvsub);

                lstvItem.SubItems.Add(lstvsub1);

                listview_show.Items.Add(lstvItem);

                MessageBox.Show("You have successfuly added your account", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // sau khi thêm thông tin ta sẽ xóa các thông tin đã nhập ở các ô textbox để có thể nhập và thêm mới tài khoản khác.

                txt_ID.Clear();

                txt_Name.Clear();

                txt_Password.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listview_show.SelectedIndices.Count <= 0)

            {

                MessageBox.Show("You have not selected the item you want to delete", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (listview_show.SelectedIndices.Count > 0)

            {

                DialogResult dl = MessageBox.Show("Bạn muốn xóa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dl == DialogResult.OK)

                    listview_show.Items.Remove(listview_show.SelectedItems[0]);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
