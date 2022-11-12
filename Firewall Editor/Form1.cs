using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Firewall_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (checkedListBox1.Items.Count < 1)
            {
                textDragNotif.Visible = true;
            }
            else
            {
                textDragNotif.Visible = false;
            }
            labelProgress.BackColor = System.Drawing.Color.Transparent;
        }

        private void checkedListBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] dnd = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var original_folders = new List<string>();
            var completed_folders = new List<string>();
            foreach (var str in dnd)
            {
                if ((File.GetAttributes(str) & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    original_folders.Add(str);
                }  
            }

            // Get all folders
            //MessageBox.Show("Starting");
            while (true)
            {
                var str = original_folders[0];
                completed_folders.Add(str);
                string[] fa = Directory.GetDirectories(str);
                original_folders.AddRange(fa);
                original_folders.RemoveAt(0);
                if (!original_folders.Any())
                    break;
            }

            //MessageBox.Show(string.Join("\n", completed_folders));
            
            // Get all files in all folders
            var completed_files = new List<string>();
            foreach (string folder in completed_folders)
            {
                string[] f = Directory.GetFiles(folder);
                completed_files.AddRange(f);
            }
            //MessageBox.Show(string.Join("\n", completed_files));

            foreach (string file in completed_files)
            {
                if (file.ToLower().Contains(".exe"))
                {
                    checkedListBox1.Items.Add(file);

                }
            }

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }

            if (checkedListBox1.Items.Count < 1)
            {
                textDragNotif.Visible = true;
            }
            else
            {
                textDragNotif.Visible = false;
            }
        }

        private void checkedListBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlock.Checked)
            {
                Constants.Mode = "Block";
            }
            else
            {
                Constants.Mode = "Allow";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox s = sender as CheckBox;
           
            if (s.Checked){
                Constants.DualMode = true;
                radioButtonInbound.Enabled = false;
                radioButtonOutbound.Enabled = false;
            }
            else
            {
                Constants.DualMode = false;
                radioButtonInbound.Enabled = true;
                radioButtonOutbound.Enabled = true;
            }
        }

        private void radioButtonDirection_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInbound.Checked)
            {
                Constants.Direction = "Inbound";
            }
            else
            {
                Constants.Direction = "Outbound";
            }
        }


        private void flipDirection()
        {
            if (Constants.Direction.Equals("Inbound"))
            {
                Constants.Direction = "Outbound";
            }
            else
            {
                Constants.Direction = "Inbound";
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            // Current item & Max items & progress bar max
            int count = 1;
            int max_count = checkedListBox1.CheckedItems.Count;
            int prog_bar_count = 1;
            int prog_bar_max = max_count;

            // Trim prefix
            if (!textBoxPrefix.Text.Trim().Equals(""))
            {
                Constants.prefix = textBoxPrefix.Text.Trim();
            }

            // If both inbound and outbound
            if (Constants.DualMode)
            {
                prog_bar_max = max_count * 2;
                progressBar1.Maximum = prog_bar_max;

                foreach (string item in checkedListBox1.CheckedItems)
                {
                    string countText = "";
                    countText = count.ToString();
                    runCommand(item, countText);
                    updateProgressBar(prog_bar_count, prog_bar_max);

                    count++;
                    prog_bar_count++;
                }

                flipDirection();
                count = 0;
            }
            else
            {
                prog_bar_max = max_count * 1;
                progressBar1.Maximum = prog_bar_max;
            }
            
            foreach (string item in checkedListBox1.CheckedItems)
            {
                string countText = "";
                countText = count.ToString();
                runCommand(item, countText);
                updateProgressBar(prog_bar_count, prog_bar_max);

                count++;
                prog_bar_count++;
            }

        }

        private void updateProgressBar(int count, int max_count)
        {
            progressBar1.Value = count;
            float percent = count / max_count;
            percent *= 100;
            labelProgress.Text = percent.ToString() + "%";
        }

        private void runCommand(string item, string count)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "powershell.exe";
            startInfo.Arguments = "New-NetFirewallRule -DisplayName '" + Constants.prefix + count + "' -Direction " + Constants.Direction + " -Program '" + item + "' -Action " + Constants.Mode;
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void textBoxPrefix_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textDragNotif_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            textDragNotif.Visible = true;
        }
    }
}
