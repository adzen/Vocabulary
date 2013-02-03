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
                    aword.righted = int.Parse(tokens[0]);
                    aword.questioned = int.Parse(tokens[1]);
                    aword.english = tokens[2];
                    aword.chinese = tokens[3];
                    dictionary.Insert(0, aword);                    
                }
                else
                {
                    word aword = new word();
                    aword.righted = aword.questioned = 0;
                    aword.english = tokens[0];
                    aword.chinese = tokens[1];
                    dictionary.Insert(0, aword);
                    newWordCount++;
                }
            }

            MessageBox.Show(@"Total = " + dictionary.Count.ToString() + @", New Word = " + newWordCount.ToString());
        }

        private void dictionOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            loadData(dictionOpenFileDialog.FileName);
        }

        private void openbutton_Click(object sender, EventArgs e)
        {
            dictionOpenFileDialog.ShowDialog();
        }
    }

    public class word
    {
        public string english, chinese;
        public int questioned, righted;
    }
}
