namespace Dijkstra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.importExcelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.FibonacciHeapRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.durationLabel = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.importExcelButton.BackColor = System.Drawing.Color.LimeGreen;
            this.importExcelButton.Location = new System.Drawing.Point(664, 124);
            this.importExcelButton.Name = "button1";
            this.importExcelButton.Size = new System.Drawing.Size(145, 54);
            this.importExcelButton.TabIndex = 0;
            this.importExcelButton.Text = "Import Excel File";
            this.importExcelButton.UseVisualStyleBackColor = false;
            this.importExcelButton.Click += new System.EventHandler(this.importExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Finding Shortest Path using Dijkstra with Priority Queue";
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.runButton.Location = new System.Drawing.Point(474, 504);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(118, 61);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(100, 296);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 28);
            this.resultLabel.TabIndex = 3;
            // 
            // FibonacciHeapRadioButton
            // 
            this.FibonacciHeapRadioButton.AutoSize = true;
            this.FibonacciHeapRadioButton.Checked = true;
            this.FibonacciHeapRadioButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FibonacciHeapRadioButton.Location = new System.Drawing.Point(29, 33);
            this.FibonacciHeapRadioButton.Name = "FibonacciHeapRadioButton";
            this.FibonacciHeapRadioButton.Size = new System.Drawing.Size(151, 28);
            this.FibonacciHeapRadioButton.TabIndex = 4;
            this.FibonacciHeapRadioButton.TabStop = true;
            this.FibonacciHeapRadioButton.Text = "Fibonacci Heap";
            this.FibonacciHeapRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.FibonacciHeapRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(679, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Priority Queue Type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(29, 101);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(203, 28);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Unordered Linked List";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(29, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(159, 28);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Binary Min Heap";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.durationLabel.Location = new System.Drawing.Point(180, 450);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(0, 24);
            this.durationLabel.TabIndex = 7;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(251, 138);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(401, 27);
            this.filePathTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 704);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.importExcelButton);
            this.Name = "Form1";
            this.Text = "Dijkstra with Priority Queue";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button importExcelButton;
        private Label label1;
        private Button runButton;
        private Label resultLabel;
        private RadioButton FibonacciHeapRadioButton;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Label durationLabel;
        private TextBox filePathTextBox;
    }
}