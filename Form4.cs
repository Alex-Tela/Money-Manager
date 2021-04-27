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
    public partial class Form4 : Form
    {
        List<string> myItems = new List<string>();
        List<string> myItemsFile = new List<string>();
        List<int> positionsOfCommaSeparator = new List<int>();
        string fileWanted;
        string amount;
        bool valid, valid2, valid3, validity;
        int positionOfPoint, occurenceOfPoint;
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label5.Text = comboBox2.SelectedItem.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string[] myCurrencies = File.ReadAllLines("currency1.txt");
            foreach (string line in myCurrencies)
            {
                string[] content = line.Split(';');
                myItems.Add(content[0]);
                myItemsFile.Add(content[2]);
            }

            foreach (string item in myItems)
            {
                comboBox2.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && textBox2.Text != null)
            {
                bool myValidity = validateNumber();
                if (myValidity == true)
                {
                    int positionOfValueWanted = myItems.IndexOf(comboBox2.SelectedItem.ToString());
                    for (int i = 0; i < myItemsFile.Count; i++)
                    {
                        if (positionOfValueWanted == i)
                        {
                            fileWanted = myItemsFile[i];
                        }
                    }
                    DateTime now = DateTime.Now;

                    string[] valuesToAdd = { "Amount: " + textBox3.Text + " " + comboBox2.SelectedItem.ToString(), "Description: " + textBox2.Text, "Date: " + now, "-------------------------------" };
                    foreach (string item in valuesToAdd)
                    {
                        listBox1.Items.Add(item);
                    }
                    File.AppendAllLines(fileWanted, valuesToAdd);
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox2.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Please select a valid currency and add a description. Also, enter the amount in the form ###,###.##", "Wrong input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid currency and add a description. Also, enter the amount in the form ###,###.##", "Wrong input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 myForm2 = new Form2();
            myForm2.ShowDialog();
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

        private void deleteARecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 myForm8 = new Form8();
            myForm8.ShowDialog();
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

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public bool validateNumber()
        {
            validity = false;
            valid = false;
            valid2 = false;
            amount = textBox3.Text;
            for (int i = 0; i < amount.Length; i++)
            {
                switch (amount[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '.':
                    case ',':
                        valid = true;
                        break;
                    default:
                        valid = false;
                        break;
                }
            }

            if (valid == false)
            {
                MessageBox.Show("Please enter only numbers!", "Wrong data type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Clear();
                validity = false;
            }
            else
            {
                occurenceOfPoint = 0;
                for (int i = 0; i < amount.Length; i++)
                {
                    if (amount[i] == '.')
                    {
                        occurenceOfPoint = occurenceOfPoint + 1;
                    }
                }

                if (occurenceOfPoint > 1)
                {
                    valid2 = false;
                }
                else
                {
                    if (amount[amount.Length - 3] == '.')
                    {
                        valid2 = true;
                        positionOfPoint = amount.Length - 3;
                    }
                    else
                    {
                        valid2 = false;
                    }
                }

                if (valid2 == false)
                {
                    MessageBox.Show("Please enter a number of the form ###,###.##", "Wrong input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Clear();
                    validity = false;
                }
                else
                {
                    if (amount.Length > 6)
                    {
                        for (int i = amount.Length - 3; i >= 0; i--)
                        {
                            if (amount[i] == ',')
                            {
                                positionsOfCommaSeparator.Add(i);
                            }
                        }
                        for (int i = 0; i < positionsOfCommaSeparator.Count; i++)
                        {
                            switch (positionOfPoint - positionsOfCommaSeparator[i])
                            {
                                case 4:
                                case 8:
                                case 12:
                                case 16:
                                    valid3 = true;
                                    break;
                                default:
                                    valid3 = false;
                                    break;
                            }
                        }

                    }
                    else
                    {
                        valid3 = true;
                        for (int i = 0; i < amount.Length; i++)
                        {
                            if (amount[i] == ',')
                            {
                                valid3 = false;
                            }
                        }
                    }

                    if (valid3 == false)
                    {
                        MessageBox.Show("Please enter a number of the form ###,###.##", "Wrong input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox3.Clear();
                        validity = false;
                    }
                    else
                    {
                        validity = true;
                    }
                }
            }
            return validity;
        }
    }
}
