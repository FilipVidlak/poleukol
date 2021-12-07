using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukolpole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                Random rnd = new Random();
                int n = int.Parse(textBox1.Text);
                int[] pole = new int[n];
                for (int i = 0; i < n; i++)
                {
                    int a = rnd.Next(1, 50);
                    listBox1.Items.Add(a);
                    pole[i] = a;

                }
                for (int i = 0; i < n; i++)
                {
                    if (radioButton1.Checked == true)
                    {
                        Array.Sort(pole);
                        Array.Reverse(pole);
                        listBox2.Items.Add(pole[i]);
                    }
                    else if (radioButton2.Checked == true)
                    {
                        Array.Sort(pole); 
                        listBox2.Items.Add(pole[i]);
                    }
                    
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false) 
                {
                    MessageBox.Show("Zadej, jestli chceš pole seřadit sestupně nebo vzestupně", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Zadal jsi špatnou hodnotu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
