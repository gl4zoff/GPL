using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace GsPL
{
    public partial class Form1 : Form
    {
        public string filePath;
        public string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (FileName.Text != "File name")
            {
                Code.Items.Clear();
                FolderBrowserDialog.ShowDialog();
                filePath = FolderBrowserDialog.SelectedPath + "\\";
                fileName = FileName.Text;

                using(StreamReader sr = new StreamReader(filePath + fileName + ".txt"))
                {
                    int i = -1;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        i++;
                        if(i == Library.lines.Length)
                        {
                            Library.AddValue(ref Library.lines, line);
                        }
                        else
                            Library.lines[i] = line;
                    }
                    Library.ints = new string[Library.lines.Length, 2];
                    Library.strings = new string[Library.lines.Length, 2];
                }
                for (int i = 0; i < Library.lines.Length; i++)
                {
                    if(Library.lines[i] != null)
                        Code.Items.Add(Library.lines[i]);
                }
            }
            else
                MessageBox.Show("Укажите имя файла");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            OutputForm of = new OutputForm();
            of.Show();
        }
    }
}