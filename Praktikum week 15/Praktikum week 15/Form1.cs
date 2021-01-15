using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_week_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMakan.Checked == true)
            {
                CBMenu.Items.Add("Nasi Goreng");
                CBMenu.Items.Add("Nasi Goreng Special");
                CBMenu.Items.Add("Nasi Goreng Pete");
                CBMenu.Items.Add("Ayam Bakar");
                panel1.Hide();
            }
                if(radioButtonMakan.Checked == false)
            {
                  CBMenu.Items.Clear();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinuman.Checked == true)
            {
                CBMenu.Items.Add("Es Teh");
                CBMenu.Items.Add("Teh Hangat");
                CBMenu.Items.Add("NutriSari");
                CBMenu.Items.Add("Aqua");
                panel1.Visible = panel1.Enabled;
            }
            if (radioButtonMinuman.Checked == false)
            {
                CBMenu.Items.Clear();
            }
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBMenu.SelectedItem.ToString() == "Nasi Goreng")
            {
                labelharga.Text = "10000";
            }
            if (CBMenu.SelectedItem.ToString() == "Nasi Goreng Special")
            {
                labelharga.Text = "12000";
            }
            if (CBMenu.SelectedItem.ToString() == "Nasi Goreng Pete")
            {
                labelharga.Text = "15000";
            }
            if (CBMenu.SelectedItem.ToString() == "Ayam Bakar")
            {
                labelharga.Text = "15000";
            }
        }

        private void buttonpanggilform_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.Items.Count == 0)
            {
                MessageBox.Show("Beli Dulu Bos");
            }
            else
            {
                var formbaru = new Form2();
                formbaru.ShowDialog();
            }
        }

        private void radioButtonJumbo_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMenu.SelectedItem.ToString() == "Aqua" && radioButtonJumbo.Checked == true)
            {
                labelharga.Text = "5000";
            }
            if (CBMenu.SelectedItem.ToString() == "Teh Hangat" && radioButtonJumbo.Checked == true)
            {
                labelharga.Text = "5000";
            }
            if (CBMenu.SelectedItem.ToString() == "Es Teh" && radioButtonJumbo.Checked == true)
            {
                labelharga.Text = "7000";
            }
            if (CBMenu.SelectedItem.ToString() == "Nutrisari" && radioButtonJumbo.Checked == true)
            {
                labelharga.Text = "10000";
            }
        }

        private void radioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMenu.SelectedItem.ToString() == "Aqua" && radioButtonNormal.Checked == true)
            {
                labelharga.Text = "2000";
            }
            if (CBMenu.SelectedItem.ToString() == "Teh Hangat" && radioButtonNormal.Checked == true)
            {
                labelharga.Text = "3000";
            }
            if (CBMenu.SelectedItem.ToString() == "Es Teh" && radioButtonNormal.Checked == true)
            {
                labelharga.Text = "5000";
            }
            if (CBMenu.SelectedItem.ToString() == "Nutrisari" && radioButtonNormal.Checked == true)
            {
                labelharga.Text = "6000";
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            listBoxMenu.Items.Add(CBMenu.SelectedItem);
            if(CBMenu.SelectedItem.ToString() == "Nasi Goreng")
            {
                listBoxHarga.Items.Add("10000");
            }
            if (CBMenu.SelectedItem.ToString() == "Nasi Goreng Special")
            {
                listBoxHarga.Items.Add("12000");
            }
            if (CBMenu.SelectedItem.ToString() == "Nasi Goreng Pete")
            {
                listBoxHarga.Items.Add("15000");
            }
            if (CBMenu.SelectedItem.ToString() == "Ayam Bakar")
            {
                listBoxHarga.Items.Add("15000");
            }
            if (CBMenu.SelectedItem.ToString() == "Aqua" && radioButtonJumbo.Checked == true)
            {
                listBoxHarga.Items.Add("5000");
            }
            if (CBMenu.SelectedItem.ToString() == "Teh Hangat" && radioButtonJumbo.Checked == true)
            {
                listBoxHarga.Items.Add("5000");
            }
            if (CBMenu.SelectedItem.ToString() == "Es Teh" && radioButtonJumbo.Checked == true)
            {
                listBoxHarga.Items.Add("7000");
            }
            if (CBMenu.SelectedItem.ToString() == "Nutrisari" && radioButtonJumbo.Checked == true)
            {
                listBoxHarga.Items.Add("10000");
            }
            if (CBMenu.SelectedItem.ToString() == "Aqua" && radioButtonNormal.Checked == true)
            {
                listBoxHarga.Items.Add("2000");
            }
            if (CBMenu.SelectedItem.ToString() == "Teh Hangat" && radioButtonNormal.Checked == true)
            {
                listBoxHarga.Items.Add("3000");
            }
            if (CBMenu.SelectedItem.ToString() == "Es Teh" && radioButtonNormal.Checked == true)
            {
                listBoxHarga.Items.Add("5000");
            }
            if (CBMenu.SelectedItem.ToString() == "Nutrisari" && radioButtonNormal.Checked == true)
            {
                listBoxHarga.Items.Add("6000");
            }
            if (CBMenu.SelectedItem.ToString() == "Aqua" && radioButtonNormal.Checked == true)
            {
                listBoxHarga.Items.Add("2000");
            }
            cekbuttonDelete();
        }

        private void cekbuttonDelete()
        {
            if (listBoxMenu.Items.Count == 0)
            {
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonDelete.Enabled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBoxHarga.Items.RemoveAt(listBoxMenu.SelectedIndex);
            listBoxMenu.Items.RemoveAt(listBoxMenu.SelectedIndex);
            cekbuttonDelete();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
