using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GsPL
{
    public partial class OutputForm : Form
    {
        public OutputForm()
        {
            InitializeComponent();
        }

        private void OutputForm_Load(object sender, EventArgs e)
        {
            if (Library.lines[0].StartsWith("V:"))
            {
                Library.V = int.Parse(Library.lines[0].Remove(0, 3));
            }
            for (int i = 0; i < Library.V; i++)
            {
                if (Library.lines[i] == null)
                    continue;
                if (Library.lines[i].StartsWith("int"))
                {
                    string value = Library.lines[i].Remove(0, 4);
                    string Name = Library.lines[i].Remove(0, 4);
                    Name = Name.Replace(" = ", "");
                    Name = Name.Trim(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' });
                    value = value.Replace(Name, "");
                    value = value.Replace(" = ", "");

                    Library.ints[i, 0] = Name;
                    Library.ints[i, 1] = value;
                }
                else if (Library.lines[i].StartsWith("str"))
                {
                    int index = Library.lines[i].IndexOf("=");
                    string value = Library.lines[i].Remove(0, 4);
                    string Name = Library.lines[i].Remove(0, 4);
                    Name = Name.Substring(0, index - 5);
                    value = value.Replace(Name, "");
                    value = value.Replace(" = ", "");

                    Library.strings[i, 0] = Name;
                    Library.strings[i, 1] = value;
                }
                else if (Library.lines[i].StartsWith("write"))
                {
                    string value = Library.lines[i].Replace("write ", "");
                    if (value.StartsWith("'"))
                    {
                        value = value.Replace("'", "");
                        OutputTB.Text += value + "  ";
                    }
                    else
                    {
                        for (int j = 0; j < Library.V; j++)
                        {
                            if (value == Library.ints[j, 0])
                                OutputTB.Text += Library.ints[j, 1] + "  ";
                            else if (value == Library.strings[j, 0])
                                OutputTB.Text += Library.strings[j, 1] + "  ";
                            //Debug(value);
                        }
                    }
                }
                else
                {
                    for (int k = 0; k < Library.V; k++)
                    {
                        if (Library.ints[k, 0] != null && Library.lines[i].StartsWith(Library.ints[k, 0]))
                        {
                            string operatoin = Library.lines[i].Remove(0, Library.ints[k, 0].Length + 1);
                            string sNum = operatoin.Trim(new char[] { '+', '-', '*', '/', ' ', '=' });
                            Math(operatoin, k, sNum);
                            if (operatoin.StartsWith("="))
                            {
                                int fNum = int.Parse(Library.ints[k, 1]);
                                for (int x = 0; x < Library.V; x++)
                                {
                                    if (Library.ints[x, 0] != null && sNum.StartsWith(Library.ints[x, 0]))
                                    {
                                        Library.ints[k, 1] = Convert.ToString(fNum = int.Parse(Library.ints[x, 1]));
                                    }
                                    else
                                    {
                                        try
                                        {
                                            Library.ints[k, 1] = Convert.ToString(fNum = int.Parse(sNum));
                                            break;
                                        }
                                        catch
                                        {
                                            continue;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void Math(string s, int i, string sNum)
        {
            for (int x = 0; x < Library.V; x++)
            {
                //int fNum = int.Parse(Library.ints[x, 1]);
                if (Library.ints[x, 0] != null && sNum.StartsWith(Library.ints[x, 0]))
                {
                    if (s.StartsWith("+"))
                        Library.ints[i, 1] = Convert.ToString(int.Parse(Library.ints[i, 1]) + int.Parse(Library.ints[x, 1]));
                    else if (s.StartsWith("-"))
                        Library.ints[i, 1] = Convert.ToString(int.Parse(Library.ints[i, 1]) - int.Parse(Library.ints[x, 1]));
                    else if (s.StartsWith("*"))
                        Library.ints[i, 1] = Convert.ToString(int.Parse(Library.ints[i, 1]) * int.Parse(Library.ints[x, 1]));
                    else if (s.StartsWith("/"))
                        Library.ints[i, 1] = Convert.ToString(int.Parse(Library.ints[i, 1]) / int.Parse(Library.ints[x, 1]));
                    break;
                }
                else
                {
                    try
                    {
                        if (s.StartsWith("+"))
                            Library.ints[i, 1] = Convert.ToString(int.Parse(Library.ints[i, 1]) + int.Parse(sNum));
                        else if (s.StartsWith("-"))
                            Library.ints[i, 1] = Convert.ToString(int.Parse(Library.ints[i, 1]) - int.Parse(sNum));
                        else if (s.StartsWith("*"))
                            Library.ints[i, 1] = Convert.ToString(int.Parse(Library.ints[i, 1]) * int.Parse(sNum));
                        else if (s.StartsWith("/"))
                            Library.ints[i, 1] = Convert.ToString(int.Parse(Library.ints[i, 1]) / int.Parse(sNum));
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }
        private void Debug(string value)
        {
            if (value != null)
            {
                MessageBox.Show(value);
            }
            else
                MessageBox.Show("Значение не найдено");    
        }
    }
}
