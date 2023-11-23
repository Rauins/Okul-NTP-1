namespace FormBoyama
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
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(63, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 108);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Arka Plan Rengi";
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.ForeColor = Color.White;
            button4.Location = new Point(159, 61);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Gri";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.ForeColor = Color.White;
            button3.Location = new Point(18, 61);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Mavi";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(159, 32);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Yeşil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.ForeColor = Color.White;
            button1.Location = new Point(18, 32);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Kırmızı";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 159);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}