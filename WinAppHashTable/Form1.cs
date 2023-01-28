using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppHashTable
{
    public partial class HashTableTest : Form
    {
        string filePath = string.Empty;
        string dictionaryFile = string.Empty;
        string targetFile = string.Empty;
        string missedWordsFile = string.Empty;
        public HashTableTest()
        {
            dictionaryFile = ConfigurationManager.AppSettings["dictionaryFile"];
            targetFile = ConfigurationManager.AppSettings["targetFile"];
            missedWordsFile = ConfigurationManager.AppSettings["missedWordsFile"];
            InitializeComponent();
            CheckSpellButton.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hashtableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hastable object declaration
            Hashtable englishHashDictionary = new Hashtable();
            // Read the file and add words to hashtable
            DateTime startDate = DateTime.Now;
            foreach (string line in System.IO.File.ReadLines(dictionaryFile))
            {
                if (!englishHashDictionary.ContainsKey(line))
                {
                    englishHashDictionary.Add(line, line);
                }
            }
            TimeSpan timeDiff = DateTime.Now - startDate;
            string result = string.Format("{0} add to Hashtable in {1} ms", dictionaryFile, timeDiff.TotalMilliseconds);
            Console.WriteLine(result);
            toolStripStatusHastable.Text = result;
            //Read target file to spell-check and put not fouded words in a list
            IList<string> missedWords = new List<string>();
            foreach (string line in System.IO.File.ReadLines(targetFile))
            {
                string[] words = line.Replace(",", "").Replace("!", "").Split(' ');
                foreach (string word in words)
                {
                    if (!englishHashDictionary.ContainsKey(word))
                    {
                        if (!missedWords.Contains(word))
                        {
                            missedWords.Add(word);
                        }
                    }
                }
            }
            if (missedWords.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, missedWords));
                System.IO.File.WriteAllLines(missedWordsFile, missedWords);
            }
            Console.WriteLine("File processed!!");
        }

        private void dictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dictionary object declaration
            Dictionary<string, string> englishHashDictionary = new Dictionary<string, string>();
            // Read the file and add words to Dictionary
            DateTime startDate = DateTime.Now;
            foreach (string line in System.IO.File.ReadLines(dictionaryFile))
            {
                if (!englishHashDictionary.ContainsKey(line))
                {
                    englishHashDictionary.Add(line, line);
                }
            }
            TimeSpan timeDiff = DateTime.Now - startDate;
            string result = string.Format("{0} add to Dictionary in {1} ms", dictionaryFile, timeDiff.TotalMilliseconds);
            Console.WriteLine(result);
            toolStripStatusDictionary.Text = result;
            //Read target file to spell-check and put not fouded words in a list
            IList<string> missedWords = new List<string>();
            foreach (string line in System.IO.File.ReadLines(targetFile))
            {
                string[] words = line.Replace(",", "").Replace("!", "").Split(' ');
                foreach (string word in words)
                {
                    if (!englishHashDictionary.ContainsKey(word))
                    {
                        if (!missedWords.Contains(word))
                        {
                            missedWords.Add(word);
                        }
                    }
                }
            }
            if (missedWords.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, missedWords));
                System.IO.File.WriteAllLines(missedWordsFile, missedWords);
            }
            Console.WriteLine("File processed!!");
        }

        private void sortedDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SortedDictionary object declaration
            SortedDictionary<string, string> englishHashDictionary = new SortedDictionary<string, string>();
            // Read the file and add words to SortedDictionary
            DateTime startDate = DateTime.Now;
            foreach (string line in System.IO.File.ReadLines(dictionaryFile))
            {
                if (!englishHashDictionary.ContainsKey(line))
                {
                    englishHashDictionary.Add(line, line);
                }
            }
            TimeSpan timeDiff = DateTime.Now - startDate;
            string result = string.Format("{0} add to Sorted Dictionary in {1} ms", dictionaryFile, timeDiff.TotalMilliseconds);
            Console.WriteLine(result);
            toolStripStatusSortedDictionary.Text = result;
            //Read target file to spell-check and put not fouded words in a list
            IList<string> missedWords = new List<string>();
            foreach (string line in System.IO.File.ReadLines(targetFile))
            {
                string[] words = line.Replace(",", "").Replace("!", "").Split(' ');
                foreach (string word in words)
                {
                    if (!englishHashDictionary.ContainsKey(word))
                    {
                        if (!missedWords.Contains(word))
                        {
                            missedWords.Add(word);
                        }
                    }
                }
            }
            if (missedWords.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, missedWords));
                System.IO.File.WriteAllLines(missedWordsFile, missedWords);
            }
            Console.WriteLine("File processed!!");
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    richTextBoxFileInitial.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                    CheckSpellButton.Enabled = true;
                }
            }
        }

        private void CheckSpell_Click(object sender, EventArgs e)
        {

            //SortedDictionary object declaration
            Dictionary<string, string> englishHashDictionary = new Dictionary<string, string>();
            // Read the file and add words to SortedDictionary
            foreach (string line in System.IO.File.ReadLines(dictionaryFile))
            {
                if (!englishHashDictionary.ContainsKey(line))
                {
                    englishHashDictionary.Add(line, line);
                }
            }
            //Read target file to spell-check and put not fouded words in a list
            foreach (string line in richTextBoxFileInitial.Lines)
            {
                string[] words = line.Split(' ');
                foreach (string word in words)
                {
                    if (!englishHashDictionary.ContainsKey(word))
                    {
                        richTextBoxCheckSpell.AppendText(word, Color.Red);
                        richTextBoxCheckSpell.AppendText(" ");
                    }
                    else
                    {
                        richTextBoxCheckSpell.AppendText(word + " ");
                    }
                }
                richTextBoxCheckSpell.AppendText(Environment.NewLine);
            }
        }
    }
}
