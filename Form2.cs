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
    public partial class Form2 : Form
    {
        List<string> myItems = new List<string>();
        List<string> mySavingsFile = new List<string>();
        List<string> mySpendingsFile = new List<string>();
        string fileWanted, fileWanted2;
        double sumSavings = 0;
        double sumSpendings = 0;
        string[] contentOfFile;
        string[] contentOfFile2;
        public Form2()
        {
            InitializeComponent();
        }

        private void savingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 myForm3 = new Form3();
            myForm3.ShowDialog();
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

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listSavings.Items.Clear();
            listSpendings.Items.Clear();
            sumSavings = 0;
            sumSpendings = 0;
            if (comboBox1.SelectedItem != null)
            {  
                int positionOfValueWanted = myItems.IndexOf(comboBox1.SelectedItem.ToString());
                for (int i = 0; i < mySavingsFile.Count; i++)
                {
                    if (positionOfValueWanted == i)
                    {
                        fileWanted = mySavingsFile[i];
                        fileWanted2 = mySpendingsFile[i];
                    }
                }

                contentOfFile = File.ReadAllLines(fileWanted);
                contentOfFile2 = File.ReadAllLines(fileWanted2);

                if (contentOfFile.Length == 0 && contentOfFile2.Length == 0)
                {
                    MessageBox.Show("You first need to enter some savings and spendings before having a balance for this currency", "No data available",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    if (contentOfFile.Length >= 1)
                    {
                        foreach (string content in contentOfFile)
                        {
                            listSavings.Items.Add(content);
                        }
                        for (int i = 0; i < contentOfFile.Length; i = i + 4)
                        {
                            string[] separate = contentOfFile[i].Split(' ');
                            sumSavings = sumSavings + double.Parse(separate[1]);
                        }
                        label2.Text = "Savings: " + sumSavings.ToString() + " " + comboBox1.SelectedItem.ToString();
                    }
                    if (contentOfFile2.Length >= 1)
                    {
                        foreach (string content in contentOfFile2)
                        {
                            listSpendings.Items.Add(content);
                        }
                        for (int i = 0; i < contentOfFile2.Length; i = i + 4)
                        {
                            string[] separate = contentOfFile2[i].Split(' ');
                            sumSpendings = sumSpendings + double.Parse(separate[1]);
                        }
                        label3.Text = "Spendings: " + sumSpendings.ToString() + " " + comboBox1.SelectedItem.ToString();
                    }
                    if (listSavings.Items.Count == 0 && listSpendings.Items.Count != 0)
                    {
                        label4.Text = "BALANCE: " + "-" + sumSpendings.ToString() + " " + comboBox1.SelectedItem.ToString();
                    } else if (listSavings.Items.Count != 0 && listSpendings.Items.Count == 0)
                    {
                        label4.Text = "BALANCE: " + "+" + sumSavings.ToString() + " " + comboBox1.SelectedItem.ToString();
                    } else
                    {
                        double difference = sumSavings - sumSpendings;
                        label4.Text = "BALANCE: " + difference.ToString() + " " + comboBox1.SelectedItem.ToString();
                    }

                }
            } else
            {
                MessageBox.Show("Select a currency or enter a new currency in Settings!", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label2.Text = "Total Savings:";
                label3.Text = "Total Spendings:";
                label4.Text = "BALANCE:";
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] myCurrencies = File.ReadAllLines("currency1.txt");
            foreach (string line in myCurrencies)
            {
                string[] content = line.Split(';');
                myItems.Add(content[0]);
                mySavingsFile.Add(content[1]);
                mySpendingsFile.Add(content[2]);
            }

            foreach (string item in myItems)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
