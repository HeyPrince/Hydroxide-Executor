using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oxygen;
using KrnlAPI;
using System.IO;

namespace Hydroxide_Executor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainAPI.Load();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void siticoneLabel2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Execution.Execute(fastColoredTextBox1.Text);
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    MainAPI.Execute(fastColoredTextBox1.Text);
                }
            }
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                API.Inject();
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    MainAPI.Inject();
                }
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
        }

        private void ScriptHub_Click(object sender, EventArgs e)
        {
            ScriptHub openform = new ScriptHub();
            openform.Show();
        }
    }
}
