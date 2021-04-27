using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Alex_Gheorghita___Software_Programming_Project
{
    public partial class Form8 : Form
    {
        List<string> myItems = new List<string>();
        List<string> mySpendingsList = new List<string>();
        int position, currencyFilePos;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 myForm2 = new Form2();
            myForm2.ShowDialog();
        }

        private void savingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 myForm3 = new Form3();
            myForm3.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 myForm1 = new Form1();
            myForm1.ShowDialog();
        }

        private void spendingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 myForm4 = new Form4();
            myForm4.ShowDialog();
        }

        private void changeARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 myForm5 = new Form5();
            myForm5.ShowDialog();
        }

        private void deleteARecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 myForm6 = new Form6();
            myForm6.ShowDialog();
        }

        private void changeARecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 myForm7 = new Form7();
            myForm7.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < myItems.Count; i++)
            {
                if (myItems[i] == comboBox1.SelectedItem.ToString())
                {
                    currencyFilePos = i;
                    string[] records = File.ReadAllLines(mySpendingsList[currencyFilePos]);
                    foreach (string record in records)
                    {
                        listBox1.Items.Add(record);
                    }
                    button1.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.GetSelected(i) == true)
                {
                    position = i;
                }
            }
            if (listBox1.Items.Count != 0)
            {
                if (position % 2 == 0)
                {
                    if (listBox1.Items[position].ToString().StartsWith("Amount"))
                    {
                        /*listBox1.SetSelected(position, true);
                        listBox1.SetSelected(position + 1, true);
                        listBox1.SetSelected(position + 2, true);
                        listBox1.SetSelected(position + 3, true);*/
                        for (int count = position + 3; count >= position; count--)
                        {
                            listBox1.Items.RemoveAt(count);
                        }
                    }
                    else if (listBox1.Items[position].ToString().StartsWith("Date"))
                    {
                        /*listBox1.SetSelected(position - 2, true);
                        listBox1.SetSelected(position - 1, true);
                        listBox1.SetSelected(position, true);
                        listBox1.SetSelected(position + 1, true);*/
                        for (int count = position + 1; count >= position - 2; count--)
                        {
                            listBox1.Items.RemoveAt(count);
                        }
                    }
                }
                else if (position % 2 != 0)
                {
                    if (listBox1.Items[position].ToString().StartsWith("Description"))
                    {
                        /*listBox1.SetSelected(position - 1, true);
                        listBox1.SetSelected(position, true);
                        listBox1.SetSelected(position + 1, true);
                        listBox1.SetSelected(position + 2, true);*/
                        for (int count = position + 2; count >= position - 1; count--)
                        {
                            listBox1.Items.RemoveAt(count);
                        }
                    }
                    else if (listBox1.Items[position].ToString().StartsWith("-----------"))
                    {
                        /*listBox1.SetSelected(position - 3, true);
                        listBox1.SetSelected(position - 2, true);
                        listBox1.SetSelected(position - 1, true);
                        listBox1.SetSelected(position, true);*/
                        for (int count = position; count >= position - 3; count--)
                        {
                            listBox1.Items.RemoveAt(count);
                        }
                    }
                }

                string contents = "";
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    contents = contents + listBox1.Items[i] + Environment.NewLine;
                }

                File.WriteAllText(mySpendingsList[currencyFilePos], contents);
                MessageBox.Show($"Successfully deleted a record from {mySpendingsList[currencyFilePos]}");
            } else
            {
                MessageBox.Show("No record selected!");
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button1.Enabled = false;
            string[] myCurrencies = File.ReadAllLines("currency1.txt");
            foreach (string line in myCurrencies)
            {
                string[] values = line.Split(';');
                comboBox1.Items.Add(values[0]);
                myItems.Add(values[0]);
                mySpendingsList.Add(values[2]);
            }
        }
    }
}
