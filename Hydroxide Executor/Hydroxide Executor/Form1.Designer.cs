namespace Hydroxide_Executor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ScriptHub = new Siticone.UI.WinForms.SiticoneButton();
            this.Refresh = new Siticone.UI.WinForms.SiticoneButton();
            this.Minimize = new Siticone.UI.WinForms.SiticoneButton();
            this.Close = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Execute = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.SaveFile = new Siticone.UI.WinForms.SiticoneButton();
            this.OpenFile = new Siticone.UI.WinForms.SiticoneButton();
            this.Inject = new Siticone.UI.WinForms.SiticoneButton();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.siticoneLabel2);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.ScriptHub);
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.siticoneLabel1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 33);
            this.panel1.TabIndex = 0;
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Segoe UI Variable Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel2.Location = new System.Drawing.Point(94, 10);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(27, 17);
            this.siticoneLabel2.TabIndex = 9;
            this.siticoneLabel2.Text = "v 2.0";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(261, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 19);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "KrnlApi";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(165, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 19);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "OxygenApi";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ScriptHub
            // 
            this.ScriptHub.BorderRadius = 5;
            this.ScriptHub.CheckedState.Parent = this.ScriptHub;
            this.ScriptHub.CustomImages.Parent = this.ScriptHub;
            this.ScriptHub.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ScriptHub.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptHub.ForeColor = System.Drawing.Color.White;
            this.ScriptHub.HoveredState.Parent = this.ScriptHub;
            this.ScriptHub.Location = new System.Drawing.Point(378, 2);
            this.ScriptHub.Name = "ScriptHub";
            this.ScriptHub.ShadowDecoration.Parent = this.ScriptHub;
            this.ScriptHub.Size = new System.Drawing.Size(101, 33);
            this.ScriptHub.TabIndex = 7;
            this.ScriptHub.Text = "Script Hub";
            this.ScriptHub.Click += new System.EventHandler(this.ScriptHub_Click);
            // 
            // Refresh
            // 
            this.Refresh.BorderRadius = 5;
            this.Refresh.CheckedState.Parent = this.Refresh;
            this.Refresh.CustomImages.Parent = this.Refresh;
            this.Refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Refresh.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.HoveredState.Parent = this.Refresh;
            this.Refresh.Location = new System.Drawing.Point(478, 2);
            this.Refresh.Name = "Refresh";
            this.Refresh.ShadowDecoration.Parent = this.Refresh;
            this.Refresh.Size = new System.Drawing.Size(101, 33);
            this.Refresh.TabIndex = 7;
            this.Refresh.Text = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Minimize.BorderRadius = 5;
            this.Minimize.CheckedState.Parent = this.Minimize;
            this.Minimize.CustomImages.Parent = this.Minimize;
            this.Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoveredState.Parent = this.Minimize;
            this.Minimize.Location = new System.Drawing.Point(593, 1);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(34, 33);
            this.Minimize.TabIndex = 2;
            this.Minimize.Text = "➖";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.BorderRadius = 5;
            this.Close.CheckedState.Parent = this.Close;
            this.Close.CustomImages.Parent = this.Close;
            this.Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.HoveredState.Parent = this.Close;
            this.Close.Location = new System.Drawing.Point(627, 1);
            this.Close.Name = "Close";
            this.Close.ShadowDecoration.Parent = this.Close;
            this.Close.Size = new System.Drawing.Size(34, 33);
            this.Close.TabIndex = 1;
            this.Close.Text = "❌";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel1.Location = new System.Drawing.Point(15, 6);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(78, 22);
            this.siticoneLabel1.TabIndex = 1;
            this.siticoneLabel1.Text = "Hydroxide";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Execute
            // 
            this.Execute.BorderRadius = 5;
            this.Execute.CheckedState.Parent = this.Execute;
            this.Execute.CustomImages.Parent = this.Execute;
            this.Execute.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Execute.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.ForeColor = System.Drawing.Color.White;
            this.Execute.HoveredState.Parent = this.Execute;
            this.Execute.Location = new System.Drawing.Point(12, 283);
            this.Execute.Name = "Execute";
            this.Execute.ShadowDecoration.Parent = this.Execute;
            this.Execute.Size = new System.Drawing.Size(101, 33);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "Execute";
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderRadius = 5;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(120, 283);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(101, 33);
            this.siticoneButton1.TabIndex = 3;
            this.siticoneButton1.Text = "Clear";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.BorderRadius = 5;
            this.SaveFile.CheckedState.Parent = this.SaveFile;
            this.SaveFile.CustomImages.Parent = this.SaveFile;
            this.SaveFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.SaveFile.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFile.ForeColor = System.Drawing.Color.White;
            this.SaveFile.HoveredState.Parent = this.SaveFile;
            this.SaveFile.Location = new System.Drawing.Point(227, 283);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.ShadowDecoration.Parent = this.SaveFile;
            this.SaveFile.Size = new System.Drawing.Size(101, 33);
            this.SaveFile.TabIndex = 4;
            this.SaveFile.Text = "Save File";
            this.SaveFile.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BorderRadius = 5;
            this.OpenFile.CheckedState.Parent = this.OpenFile;
            this.OpenFile.CustomImages.Parent = this.OpenFile;
            this.OpenFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.OpenFile.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile.ForeColor = System.Drawing.Color.White;
            this.OpenFile.HoveredState.Parent = this.OpenFile;
            this.OpenFile.Location = new System.Drawing.Point(334, 283);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.ShadowDecoration.Parent = this.OpenFile;
            this.OpenFile.Size = new System.Drawing.Size(101, 33);
            this.OpenFile.TabIndex = 5;
            this.OpenFile.Text = "Open File";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Inject
            // 
            this.Inject.BorderRadius = 5;
            this.Inject.CheckedState.Parent = this.Inject;
            this.Inject.CustomImages.Parent = this.Inject;
            this.Inject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Inject.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inject.ForeColor = System.Drawing.Color.White;
            this.Inject.HoveredState.Parent = this.Inject;
            this.Inject.Location = new System.Drawing.Point(554, 283);
            this.Inject.Name = "Inject";
            this.Inject.ShadowDecoration.Parent = this.Inject;
            this.Inject.Size = new System.Drawing.Size(101, 33);
            this.Inject.TabIndex = 6;
            this.Inject.Text = "Inject";
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(307, 56);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(12, 38);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(525, 239);
            this.fastColoredTextBox1.TabIndex = 7;
            this.fastColoredTextBox1.Text = "-- Hydroxide Executor\r\n-- Thank You For Using\r\n-- Enjoy Exploiting \r\n-- Made by: " +
    "Prince Cruz in Peysbook";
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(548, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(106, 221);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.panel1;
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.TargetControl = this.siticoneLabel1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(667, 324);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.Inject);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hydroxide Executor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneButton Minimize;
        private Siticone.UI.WinForms.SiticoneButton Close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Siticone.UI.WinForms.SiticoneButton Execute;
        private Siticone.UI.WinForms.SiticoneButton ScriptHub;
        private Siticone.UI.WinForms.SiticoneButton Refresh;
        private Siticone.UI.WinForms.SiticoneButton Inject;
        private Siticone.UI.WinForms.SiticoneButton OpenFile;
        private Siticone.UI.WinForms.SiticoneButton SaveFile;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
    }
}

