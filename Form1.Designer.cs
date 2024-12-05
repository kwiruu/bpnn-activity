namespace bnn_activity
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            outputBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            epochTextBox = new TextBox();
            label1 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 16F);
            textBox1.Location = new Point(159, 72);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 38);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 16F);
            textBox2.Location = new Point(159, 165);
            textBox2.Margin = new Padding(6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(340, 38);
            textBox2.TabIndex = 1;
            // 
            // outputBox
            // 
            outputBox.Font = new Font("Microsoft Sans Serif", 16F);
            outputBox.Location = new Point(707, 209);
            outputBox.Margin = new Padding(6);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(430, 38);
            outputBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(159, 461);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(220, 91);
            button1.TabIndex = 3;
            button1.Text = "create bpnn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(398, 461);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(220, 91);
            button2.TabIndex = 4;
            button2.Text = "train neural network";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(640, 461);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(220, 91);
            button3.TabIndex = 5;
            button3.Text = "test";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 16F);
            textBox4.Location = new Point(159, 349);
            textBox4.Margin = new Padding(6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(340, 38);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 16F);
            textBox3.Location = new Point(159, 256);
            textBox3.Margin = new Padding(6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(340, 38);
            textBox3.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(398, 617);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(220, 91);
            button4.TabIndex = 8;
            button4.Text = "find min epoch";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // epochTextBox
            // 
            epochTextBox.Font = new Font("Microsoft Sans Serif", 16F);
            epochTextBox.Location = new Point(677, 670);
            epochTextBox.Margin = new Padding(6);
            epochTextBox.Name = "epochTextBox";
            epochTextBox.Size = new Size(340, 38);
            epochTextBox.TabIndex = 9;
            epochTextBox.Text = "100";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(671, 617);
            label1.Name = "label1";
            label1.Size = new Size(246, 31);
            label1.TabIndex = 10;
            label1.Text = "epoch to train data:";
            // 
            // button5
            // 
            button5.Location = new Point(150, 617);
            button5.Margin = new Padding(6);
            button5.Name = "button5";
            button5.Size = new Size(220, 91);
            button5.TabIndex = 11;
            button5.Text = "get estimated error";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 745);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(epochTextBox);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(outputBox);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Microsoft Sans Serif", 16F);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox epochTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}
