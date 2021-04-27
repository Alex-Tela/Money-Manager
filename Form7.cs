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
    public partial class Form7 : Form
    {
        List<string> myItems = new List<string>();
        List<string> mySpendingsList = new List<string>();
        List<string> temporaryContainer = new List<string>();
        List<int> positionsOfCommaSeparator = new List<int>();
        int position;
        string fileWanted;
        string amount;
        bool valid, valid2, valid3, validity;
        int positionOfPoint, occurenceOfPoint;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < myItems.Count; i++)
            {
                if (comboBox1.SelectedItem.ToString() == myItems[i])
                {
                    string[] readMyValues = File.ReadAllLines(mySpendingsList[i]);
                    foreach (string myitem in readMyValues)
                    {
                        listBox1.Items.Add(myitem);
                    }
                    button1.Enabled = true;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                }
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
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
                        listBox1.SetSelected(position, true);
                        listBox1.SetSelected(position + 1, true);
                        listBox1.SetSelected(position + 2, true);
                        textBox1.Text = listBox1.Items[position].ToString().Substring(8);
                        textBox2.Text = listBox1.Items[position + 1].ToString().Substring(13);
                        textBox3.Text = listBox1.Items[position + 2].ToString().Substring(6);
                    }
                    if (listBox1.Items[position].ToString().StartsWith("Date"))
                    {
                        listBox1.SetSelected(position, true);
                        listBox1.SetSelected(position - 1, true);
                        listBox1.SetSelected(position - 2, true);
                        textBox1.Text = listBox1.Items[position - 2].ToString().Substring(8);
                        textBox2.Text = listBox1.Items[position - 1].ToString().Substring(13);
                        textBox3.Text = listBox1.Items[position].ToString().Substring(6);
                    }
                }
                else if (position % 2 != 0)
                {
                    if (listBox1.Items[position].ToString().StartsWith("Description"))
                    {
                        listBox1.SetSelected(position, true);
                        listBox1.SetSelected(position - 1, true);
                        listBox1.SetSelected(position + 1, true);
                        textBox1.Text = listBox1.Items[position - 1].ToString().Substring(8);
                        textBox2.Text = listBox1.Items[position].ToString().Substring(13);
                        textBox3.Text = listBox1.Items[position + 1].ToString().Substring(6);
                    }
                    if (listBox1.Items[position].ToString().StartsWith("-----------"))
                    {
                        listBox1.SetSelected(position - 3, true);
                        listBox1.SetSelected(position - 1, true);
                        listBox1.SetSelected(position - 2, true);
                        textBox1.Text = listBox1.Items[position - 3].ToString().Substring(8);
                        textBox2.Text = listBox1.Items[position - 2].ToString().Substring(13);
                        textBox3.Text = listBox1.Items[position - 1].ToString().Substring(6);
                    }
                }
            } else
            {
                MessageBox.Show("No record selected!");
            }
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
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

        private void spendingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 myForm4 = new Form4();
            myForm4.ShowDialog();
        }

        private void deleteARecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 myForm8 = new Form8();
            myForm8.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 myForm1 = new Form1();
            myForm1.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button1.Enabled = false;
            textBox2.Enabled = false;
            textBox1.Enabled = false;
            string[] myCurrencies = File.ReadAllLines("currency1.txt");
            foreach (string line in myCurrencies)
            {
                string[] values = line.Split(';');
                comboBox1.Items.Add(values[0]);
                myItems.Add(values[0]);
                mySpendingsList.Add(values[2]);
            }
        }

        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                DateTime datetime = DateTime.Now;
                textBox3.Text = datetime.ToString();
                bool myValidity = validateNumber();
                if (myValidity == true)
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (position == i)
                        {
                            if (position % 2 == 0)
                            {
                                if (listBox1.Items[position].ToString().StartsWith("Amount"))
                                {
                                    listBox1.Items[position] = "Amount: " + textBox1.Text + " " + comboBox1.SelectedItem.ToString();
                                    listBox1.Items[position + 1] = "Description: " + textBox2.Text;
                                    listBox1.Items[position + 2] = "Last changed: " + textBox3.Text;
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    textBox3.Text = "";
                                    textBox1.Enabled = false;
                                    textBox2.Enabled = false;
                                    textBox3.Enabled = false;
                                    for (int x = 0; x < myItems.Count; x++)
                                    {
                                        if (myItems[x] == comboBox1.SelectedItem.ToString())
                                        {
                                            string myContents = "";
                                            for (int y = 0; y < listBox1.Items.Count; y++)
                                            {
                                                myContents = myContents + listBox1.Items[y].ToString() + Environment.NewLine;
                                            }
                                            File.WriteAllText(mySpendingsList[x], myContents);
                                        }
                                    }
                                }
                                else if (listBox1.Items[position].ToString().StartsWith("Date"))
                                {
                                    listBox1.Items[position - 2] = "Amount: " + textBox1.Text + " " + comboBox1.SelectedItem.ToString();
                                    listBox1.Items[position - 1] = "Description: " + textBox2.Text;
                                    listBox1.Items[position] = "Last changed: " + textBox3.Text;
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    textBox3.Text = "";
                                    textBox1.Enabled = false;
                                    textBox2.Enabled = false;
                                    textBox3.Enabled = false;
                                    for (int x = 0; x < myItems.Count; x++)
                                    {
                                        if (myItems[x] == comboBox1.SelectedItem.ToString())
                                        {
                                            string myContents = "";
                                            for (int y = 0; y < listBox1.Items.Count; y++)
                                            {
                                                myContents = myContents + listBox1.Items[y].ToString() + Environment.NewLine;
                                            }
                                            File.WriteAllText(mySpendingsList[x], myContents);
                                        }
                                    }
                                }
                            }
                            else if (position % 2 != 0)
                            {
                                if (listBox1.Items[position].ToString().StartsWith("Description"))
                                {
                                    listBox1.Items[position - 1] = "Amount: " + textBox1.Text + " " + comboBox1.SelectedItem.ToString();
                                    listBox1.Items[position] = "Description: " + textBox2.Text;
                                    listBox1.Items[position + 1] = "Last changed: " + textBox3.Text;
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    textBox3.Text = "";
                                    textBox1.Enabled = false;
                                    textBox2.Enabled = false;
                                    textBox3.Enabled = false;
                                    for (int x = 0; x < myItems.Count; x++)
                                    {
                                        if (myItems[x] == comboBox1.SelectedItem.ToString())
                                        {
                                            string myContents = "";
                                            for (int y = 0; y < listBox1.Items.Count; y++)
                                            {
                                                myContents = myContents + listBox1.Items[y].ToString() + Environment.NewLine;
                                            }
                                            File.WriteAllText(mySpendingsList[x], myContents);
                                        }
                                    }
                                }
                                else if (listBox1.Items[position].ToString().StartsWith("-----------"))
                                {
                                    listBox1.Items[position - 3] = "Amount: " + textBox1.Text + " " + comboBox1.SelectedItem.ToString();
                                    listBox1.Items[position - 2] = "Description: " + textBox2.Text;
                                    listBox1.Items[position - 1] = "Last changed: " + textBox3.Text;
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    textBox3.Text = "";
                                    textBox1.Enabled = false;
                                    textBox2.Enabled = false;
                                    textBox3.Enabled = false;
                                    for (int x = 0; x < myItems.Count; x++)
                                    {
                                        if (myItems[x] == comboBox1.SelectedItem.ToString())
                                        {
                                            string myContents = "";
                                            for (int y = 0; y < listBox1.Items.Count; y++)
                                            {
                                                myContents = myContents + listBox1.Items[y].ToString() + Environment.NewLine;
                                            }
                                            File.WriteAllText(mySpendingsList[x], myContents);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
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
