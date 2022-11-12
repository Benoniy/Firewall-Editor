namespace Firewall_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.radioButtonAllow = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonBlock = new System.Windows.Forms.RadioButton();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonOutbound = new System.Windows.Forms.RadioButton();
            this.radioButtonInbound = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textDragNotif = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AllowDrop = true;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(531, 424);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.checkedListBox1_DragDrop);
            this.checkedListBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.checkedListBox1_DragEnter);
            // 
            // radioButtonAllow
            // 
            this.radioButtonAllow.AutoSize = true;
            this.radioButtonAllow.Location = new System.Drawing.Point(25, 19);
            this.radioButtonAllow.Name = "radioButtonAllow";
            this.radioButtonAllow.Size = new System.Drawing.Size(50, 17);
            this.radioButtonAllow.TabIndex = 1;
            this.radioButtonAllow.Text = "Allow";
            this.radioButtonAllow.UseVisualStyleBackColor = true;
            this.radioButtonAllow.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonBlock);
            this.groupBox1.Controls.Add(this.radioButtonAllow);
            this.groupBox1.Location = new System.Drawing.Point(627, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rule";
            // 
            // radioButtonBlock
            // 
            this.radioButtonBlock.AutoSize = true;
            this.radioButtonBlock.Checked = true;
            this.radioButtonBlock.Location = new System.Drawing.Point(25, 42);
            this.radioButtonBlock.Name = "radioButtonBlock";
            this.radioButtonBlock.Size = new System.Drawing.Size(52, 17);
            this.radioButtonBlock.TabIndex = 2;
            this.radioButtonBlock.TabStop = true;
            this.radioButtonBlock.Text = "Block";
            this.radioButtonBlock.UseVisualStyleBackColor = true;
            this.radioButtonBlock.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(638, 286);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Location = new System.Drawing.Point(603, 68);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(144, 20);
            this.textBoxPrefix.TabIndex = 4;
            this.textBoxPrefix.TextChanged += new System.EventHandler(this.textBoxPrefix_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naming Prefix:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonOutbound);
            this.groupBox2.Controls.Add(this.radioButtonInbound);
            this.groupBox2.Location = new System.Drawing.Point(627, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 74);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Direction";
            // 
            // radioButtonOutbound
            // 
            this.radioButtonOutbound.AutoSize = true;
            this.radioButtonOutbound.Location = new System.Drawing.Point(14, 42);
            this.radioButtonOutbound.Name = "radioButtonOutbound";
            this.radioButtonOutbound.Size = new System.Drawing.Size(72, 17);
            this.radioButtonOutbound.TabIndex = 2;
            this.radioButtonOutbound.Text = "Outbound";
            this.radioButtonOutbound.UseVisualStyleBackColor = true;
            this.radioButtonOutbound.CheckedChanged += new System.EventHandler(this.radioButtonDirection_CheckedChanged);
            // 
            // radioButtonInbound
            // 
            this.radioButtonInbound.AutoSize = true;
            this.radioButtonInbound.Checked = true;
            this.radioButtonInbound.Location = new System.Drawing.Point(14, 19);
            this.radioButtonInbound.Name = "radioButtonInbound";
            this.radioButtonInbound.Size = new System.Drawing.Size(64, 17);
            this.radioButtonInbound.TabIndex = 1;
            this.radioButtonInbound.TabStop = true;
            this.radioButtonInbound.Text = "Inbound";
            this.radioButtonInbound.UseVisualStyleBackColor = true;
            this.radioButtonInbound.CheckedChanged += new System.EventHandler(this.radioButtonDirection_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(576, 348);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(202, 27);
            this.progressBar1.TabIndex = 7;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelProgress.Location = new System.Drawing.Point(665, 355);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(21, 13);
            this.labelProgress.TabIndex = 8;
            this.labelProgress.Text = "0%";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(573, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Both";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textDragNotif
            // 
            this.textDragNotif.BackColor = System.Drawing.SystemColors.Window;
            this.textDragNotif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDragNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDragNotif.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textDragNotif.Location = new System.Drawing.Point(16, 201);
            this.textDragNotif.Margin = new System.Windows.Forms.Padding(0);
            this.textDragNotif.Multiline = true;
            this.textDragNotif.Name = "textDragNotif";
            this.textDragNotif.Size = new System.Drawing.Size(504, 51);
            this.textDragNotif.TabIndex = 9;
            this.textDragNotif.Text = "To add a program simply drag & drop here.\r\nIf you add a folder, .exe\'s will be se" +
    "arched for recursivly.";
            this.textDragNotif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDragNotif.TextChanged += new System.EventHandler(this.textDragNotif_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(638, 315);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.textDragNotif);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrefix);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Windows Firewall Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.checkedListBox1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.checkedListBox1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton radioButtonAllow;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonBlock;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonOutbound;
        private System.Windows.Forms.RadioButton radioButtonInbound;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textDragNotif;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button resetButton;
    }
}

