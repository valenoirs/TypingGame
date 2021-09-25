using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class MainForm : Form
    {
        #region Declaration
        int benar = 0, salah = 0, wordCount = 0, indexGlobal = 0;
        string[] word = new string[999];
        string paragraph;
        #endregion


        private void txbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                btnSpace();
            }
        }


        private void txbAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                txbAnswer.Clear();
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Load Text";
            openFile.InitialDirectory = "C:\\";
            openFile.Filter = "Text File (*.txt)|*.txt";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                rtbParagraph.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btnStart.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.Q)
            {
                btnLoad.PerformClick();
            }
        }

        private void btnSurrender_Click(object sender, EventArgs e)
        {
            MessageBox.Show("END\n\nYour Score : " + benar.ToString() + "/" + lblTotalWords.Text.Remove(0, 14));
            txbAnswer.Enabled = false;
            rtbParagraph.ReadOnly = false;
            btnStart.Enabled = true;
        }

        public MainForm()
        {
            InitializeComponent();
        }


        private void btnSet_Click(object sender, EventArgs e)
        {


            txbAnswer.Enabled = true;

            rtbParagraph.ReadOnly = true;

            btnStart.Enabled = false;

            benar = 0;

            salah = 0;

            wordCount = 0;

            indexGlobal = 0;

            rtbParagraph.Select(0, rtbParagraph.Text.Length);

            rtbParagraph.SelectionColor = Color.FromArgb(0, 0, 0);

            lblCorrect.Text = "Correct : 0";

            lblWrong.Text = "Wrong : 0";

            txbAnswer.Clear();

            rtbParagraph.Font = new Font("Cambria", 14);

            rtbParagraph.Text = Regex.Replace(rtbParagraph.Text, @"\t|\n|\r", " ");

            paragraph = rtbParagraph.Text;

            string[] words = paragraph.Split(' ');

            lblTotalWords.Text = "Total Words : " + (words.ToArray().Length).ToString();

            word[wordCount] = words[wordCount];

            int test = paragraph.IndexOf(word[wordCount]);

            indexGlobal = test;
        }

        private void btnSpace()
        {
            try
            {
                string[] words = rtbParagraph.Text.Split(' ');

                word[wordCount] = words[wordCount];

                int index = paragraph.IndexOf(word[wordCount]);

                int length = word[wordCount].Length;

                indexGlobal = indexGlobal + index;

                paragraph = rtbParagraph.Text.Remove(0, indexGlobal);

                rtbParagraph.Select(indexGlobal, length);

                if (txbAnswer.Text == word[wordCount])
                {
                    rtbParagraph.SelectionColor = Color.Green;
                    benar++;
                }
                else
                {
                    rtbParagraph.SelectionColor = Color.Red;
                    salah++;
                }

                lblCorrect.Text = "Correct : " + benar.ToString();

                lblWrong.Text = "Wrong : " + salah.ToString();

                wordCount++;
            }
            catch
            {
                MessageBox.Show("END\n\nYour Score : " + benar.ToString() + "/" + lblTotalWords.Text.Remove(0, 14));
                txbAnswer.Enabled = false;
                rtbParagraph.ReadOnly = false;
                btnStart.Enabled = true;
            }
        }
    }
}
