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
    public partial class Form3 : Form
    {
        List<string> myItems = new List<string>();
        List<string> myItemsFile = new List<string>();
        List<int> positionsOfCommaSeparator = new List<int>();
        string fileWanted;
        string amount;
        bool valid, valid2, valid3, validity;
        int positionOfPoint, occurenceOfPoint;
        public Form3()
        {
            InitializeComponent();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 myForm2 = new Form2();
            myForm2.ShowDialog();
        }

        private void spendingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 myForm4 = new Form4();
            myForm4.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 myForm1 = new Form1();
            myForm1.ShowDialog();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button1.Enabled = false;
            }

            /*string currency = comboBox1.SelectedItem.ToString();
            string[] getValues = File.ReadAllLines(currency + ".txt");
            foreach (string item in getValues)
            {
                listBox1.Items.Add(item);
            }*/
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                label3.Text = comboBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please choose a currency first!");
                textBox1.Clear();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;

            string[] myCurrencies = File.ReadAllLines("currency1.txt");
            foreach (string line in myCurrencies)
            {
                string[] content = line.Split(';');
                myItems.Add(content[0]);
                myItemsFile.Add(content[1]);
            }

            foreach (string item in myItems)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && textBox2.Text != null)
            {
                bool myValidity = validateNumber();
                if (myValidity == true)
                {
                    int positionOfValueWanted = myItems.IndexOf(comboBox1.SelectedItem.ToString());
                    for (int i = 0; i < myItemsFile.Count; i++)
                    {
                        if (positionOfValueWanted == i)
                        {
                            fileWanted = myItemsFile[i];
                        }
                    }
                    DateTime now = DateTime.Now;

                    string[] valuesToAdd = { "Amount: " + textBox1.Text + " " + comboBox1.SelectedItem.ToString(), "Description: " + textBox2.Text, "Date: " + now, "-------------------------------" };
                    foreach (string item in valuesToAdd)
                    {
                        listBox1.Items.Add(item);
                    }
                    File.AppendAllLines(fileWanted, valuesToAdd);
                    textBox1.Clear();
                    textBox2.Clear();
                    comboBox1.SelectedItem = null;
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

        public bool validateNumber()
        {
            validity = false;
            valid = false;
            valid2 = false;
            amount = textBox1.Text;
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
                textBox1.Clear();
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
                    textBox1.Clear();
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
                        textBox1.Clear();
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
