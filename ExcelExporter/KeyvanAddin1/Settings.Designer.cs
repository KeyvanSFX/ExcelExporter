
namespace KeyvanAddin1
{
    partial class Settings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ColumnsSeparator = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndText = new System.Windows.Forms.TextBox();
            this.ColumnsContainer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentFileDirectory = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 324);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 257);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(767, 67);
            this.panel4.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 37);
            this.button3.TabIndex = 1;
            this.button3.Text = "Ok";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(0, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 142);
            this.panel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ColumnsSeparator);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.EndText);
            this.groupBox2.Controls.Add(this.ColumnsContainer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.StartText);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 119);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path";
            // 
            // ColumnsSeparator
            // 
            this.ColumnsSeparator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnsSeparator.FormattingEnabled = true;
            this.ColumnsSeparator.Items.AddRange(new object[] {
            "Colon (,)",
            "Semicolon (;)",
            "Space ( )",
            "Tab (\t)",
            "Pipeline (|)"});
            this.ColumnsSeparator.Location = new System.Drawing.Point(518, 70);
            this.ColumnsSeparator.Name = "ColumnsSeparator";
            this.ColumnsSeparator.Size = new System.Drawing.Size(195, 26);
            this.ColumnsSeparator.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Columns Separator:";
            // 
            // EndText
            // 
            this.EndText.Location = new System.Drawing.Point(465, 25);
            this.EndText.Name = "EndText";
            this.EndText.Size = new System.Drawing.Size(249, 26);
            this.EndText.TabIndex = 8;
            this.EndText.Text = ";";
            // 
            // ColumnsContainer
            // 
            this.ColumnsContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnsContainer.FormattingEnabled = true;
            this.ColumnsContainer.Items.AddRange(new object[] {
            "\"Sample\"",
            "\'Sample\'"});
            this.ColumnsContainer.Location = new System.Drawing.Point(157, 70);
            this.ColumnsContainer.Name = "ColumnsContainer";
            this.ColumnsContainer.Size = new System.Drawing.Size(195, 26);
            this.ColumnsContainer.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Columns Container:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Start Text:";
            // 
            // StartText
            // 
            this.StartText.Location = new System.Drawing.Point(103, 25);
            this.StartText.Name = "StartText";
            this.StartText.Size = new System.Drawing.Size(249, 26);
            this.StartText.TabIndex = 0;
            this.StartText.Text = "modify bus";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 119);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FileName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CurrentFileDirectory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Name:";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(119, 57);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(565, 26);
            this.FileName.TabIndex = 3;
            this.FileName.Text = "Export_Custom_Text.txt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Directory:";
            // 
            // CurrentFileDirectory
            // 
            this.CurrentFileDirectory.Location = new System.Drawing.Point(119, 25);
            this.CurrentFileDirectory.Name = "CurrentFileDirectory";
            this.CurrentFileDirectory.ReadOnly = true;
            this.CurrentFileDirectory.Size = new System.Drawing.Size(565, 26);
            this.CurrentFileDirectory.TabIndex = 0;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 324);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurrentFileDirectory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StartText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ColumnsSeparator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EndText;
        private System.Windows.Forms.ComboBox ColumnsContainer;
    }
}