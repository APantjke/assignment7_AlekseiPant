using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7_AlekseiPant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton(object sender, EventArgs e)
        {
            string[] correctAnswerArray = {"B","D","A","A","C",
                                           "A","B","A","C","D",
                                           "B","C","D","A","D",
                                           "C","C","B","D","A"};
            string[] myAnswerArray = new string[20];

            List<string> incorrectAnswerList = new List<string>();

            int count = 0, incorrectCount = 0, index = 0, questionNumber = 0;

            listBoxIncorrect.Items.Clear();

            try
            {
                string filename = fileName.Text;
                StreamReader inputFile = File.OpenText(filename);
                while (!inputFile.EndOfStream)
                {
                    myAnswerArray[index] = inputFile.ReadLine();

                    if (myAnswerArray[index] == correctAnswerArray[index])
                        count++;
                    else
                    {
                        questionNumber = index + 1;
                        incorrectAnswerList.Add(questionNumber.ToString());
                    }

                    index++;
                }

                inputFile.Close();

                if (count >= 15)
                {
                    testResultBox.Text = "You passed the test.";
                }
                else
                {
                    testResultBox.Text = "You failed the test.";
                }
                foreach (string str in incorrectAnswerList)
                {
                    listBoxIncorrect.Items.Add(str);
                }
                totalCorrect.Text = count.ToString();
                incorrectCount = 20 - count;
                totalIncorrect.Text = incorrectCount.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("File not found");
            }
        }

        private void clearButton(object sender, EventArgs e)
        {
            fileName.Text = "";
            testResultBox.Text = "";
            totalCorrect.Text = "";
            totalIncorrect.Text = "";
            listBoxIncorrect.Items.Clear();
        }

        private void exitButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
