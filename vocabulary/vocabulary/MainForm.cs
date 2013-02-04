using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace vocabulary
{
    public partial class MainForm : Form
    {
        public List<word> dictionary = new List<word>();
        public int answered = 0, corrected = 0;
        public int[] optionId = new int[4]{0,0,0,0};
        public int selectId = 0, rightedId = 0;
        public Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void loadData(string filename)
        {
            string[] lines = File.ReadAllLines(filename, Encoding.UTF8);
            if(lines.Length <= 0)
            {
                MessageBox.Show(@"It's an empty file!");
                return;
            }
            dictionary.Clear();

            int newWordCount = 0;
            foreach (string line in lines)
            {
                string[] tokens = line.Split(new char[] { '\t' });
                if (tokens.Length != 4 && tokens.Length != 2) 
                {
                    MessageBox.Show(@"Invalid input format!");
                    return;
                }

                if (tokens.Length == 4)
                {
                    word aword = new word();
                    aword.questioned = int.Parse(tokens[0]);
                    aword.righted = int.Parse(tokens[1]);
                    aword.english = tokens[2];
                    aword.chinese = tokens[3];
                    dictionary.Insert(dictionary.Count, aword);                    
                }
                else
                {
                    word aword = new word();
                    aword.righted = aword.questioned = 0;
                    aword.english = tokens[0];
                    aword.chinese = tokens[1];
                    dictionary.Insert(dictionary.Count, aword);
                    newWordCount++;
                }
            }

            MessageBox.Show(@"Total = " + dictionary.Count.ToString() + @", New Word = " + newWordCount.ToString());
            startbutton.Enabled = true;
        }

        private void dictionOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            loadData(dictionOpenFileDialog.FileName);
        }

        private void openbutton_Click(object sender, EventArgs e)
        {
            dictionOpenFileDialog.ShowDialog();
        }

        private void updateText()
        {
            problemText.Text = dictionary[selectId].english;
            option1.Text = dictionary[optionId[0]].chinese;
            option2.Text = dictionary[optionId[1]].chinese;
            option3.Text = dictionary[optionId[2]].chinese;
            option4.Text = dictionary[optionId[3]].chinese;
            statusLabel.Text = corrected.ToString() + @" / " + answered.ToString();
        }

        private void randNewProblem()
        {
            rightedId = rnd.Next(4);
            for (int i = 0; i < 4; ++i)
            {
                dictionary[optionId[i]].select = false;
                optionId[i] = -1;
            }
            optionId[rightedId] = selectId = rnd.Next(dictionary.Count);
            dictionary[selectId].select = true;
            for (int i = 0; i < 4; ++i)
            {
                if (optionId[i] < 0)
                {
                    while (true)
                    {
                        optionId[i] = rnd.Next(dictionary.Count);
                        if (dictionary[optionId[i]].select == false) 
                        {
                            dictionary[optionId[i]].select = true;
                            break;
                        }
                    }
                }
            }
            updateText();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            openbutton.Enabled = startbutton.Enabled = false;
            stopbutton.Enabled = problemText.Enabled = 
                option1.Enabled = option2.Enabled = 
                option3.Enabled = option4.Enabled = true;
            randNewProblem();
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            startbutton.Enabled = true;
            stopbutton.Enabled = problemText.Enabled =
                option1.Enabled = option2.Enabled =
                option3.Enabled = option4.Enabled = false;
        }

        private void option1_Click(object sender, EventArgs e)
        {
            answered++;
            dictionary[selectId].questioned++;
            if (rightedId == 0)
            {
                corrected++;
                dictionary[selectId].righted++;
            }
            randNewProblem();
        }

        private void option2_Click(object sender, EventArgs e)
        {
            answered++;
            dictionary[selectId].questioned++;
            if (rightedId == 1)
            {
                corrected++;
                dictionary[selectId].righted++;
            }
            randNewProblem();
        }

        private void option3_Click(object sender, EventArgs e)
        {
            answered++;
            dictionary[selectId].questioned++;
            if (rightedId == 2)
            {
                corrected++;
                dictionary[selectId].righted++;
            }
            randNewProblem();
        }

        private void option4_Click(object sender, EventArgs e)
        {
            answered++;
            dictionary[selectId].questioned++;
            if (rightedId == 3)
            {
                corrected++;
                dictionary[selectId].righted++;
            }
            randNewProblem();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dictionary.Count <= 0) return;

            string[] output = new string[dictionary.Count];
            for(int i = 0; i < dictionary.Count; ++i) 
            {
                word w = dictionary[i];
                output[i] = w.questioned.ToString() + "\t" + w.righted.ToString() + "\t"
                    + w.english + "\t" + w.chinese; 
            }

            File.WriteAllLines(dictionOpenFileDialog.FileName, output, Encoding.UTF8);
        }
    }

    public class word
    {
        public string english, chinese;
        public int questioned, righted;
        public bool select = false;
    }
}
