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

namespace Firewall_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
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
            int count = 1;
            Constants.currentCount = 1;
            Constants.maxCount = checkedListBox1.Items.Count;
            progressBar1.Maximum = Constants.maxCount;

            if (!textBoxPrefix.Text.Trim().Equals(""))
            {
                Constants.prefix = textBoxPrefix.Text.Trim();
            }
            

            
            if (Constants.DualMode)
            {
                flipDirection();

                Constants.maxCount += Constants.maxCount;
                progressBar1.Maximum = Constants.maxCount;

                foreach (string item in checkedListBox1.CheckedItems)
                {

                    string countText = "";
                    if (count < 10)
                    {
                        countText = "0";
                    }
                    countText += count.ToString();
                    runCommand(item, countText);

                    Constants.currentCount++;
                    updateProgressBar();

                    count++;
                }

                flipDirection();
                count = 1;
            }
            
            foreach (string item in checkedListBox1.CheckedItems)
            {
                
                string countText = "";
                if (count < 10)
                {
                    countText = "0";
                }
                countText += count.ToString();
                runCommand(item, countText);

                Constants.currentCount++;
                updateProgressBar();

                count++;
            }

        }

        private void updateProgressBar()
        {
            progressBar1.Value = Constants.currentCount;
            float percent = Constants.currentCount / Constants.maxCount;
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
    }
}
