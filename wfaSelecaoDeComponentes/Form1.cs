using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSelecaoDeComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                MessageBox.Show("Voçê escolheu um monitor Flat");
                listView1.Items.Add(this.radioButton1.Text);
            }
            if (this.radioButton2.Checked)
            {
                MessageBox.Show("Voçê escolheu um monitor normal");
                listView1.Items.Add(this.radioButton2.Text);
            }

            
        }

        private void btnComponentes_Click(object sender, EventArgs e)
        {
            if(cb1.SelectedIndex != -1)
            {
                listView1.Items.Add(this.cb1.SelectedItem.ToString());
            }
            if (cb2.SelectedIndex != -1)
            {
                listView1.Items.Add(this.cb2.SelectedItem.ToString());
            }
            if (cb3.SelectedIndex != -1)
            {
                listView1.Items.Add(this.cb3.SelectedItem.ToString());
            }
            if (cb4.SelectedIndex != -1)
            {
                listView1.Items.Add(this.cb4.SelectedItem.ToString());
            }
        }

        private void btnMultimidia_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                if (this.checkedListBox1.GetSelected(i))
                {
                    listView1.Items.Add(this.checkedListBox1.SelectedItem.ToString());
                }
            }
        }

        private void btnMulti2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                textBox1.Text = listView1.Items[i].ToString();
            }
        }
    }
}
