namespace İndirimliÜrün
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(30, 49);
            button1.Name = "button1";
            button1.Size = new Size(81, 68);
            button1.TabIndex = 0;
            button1.Text = "Yüzde 10 İndirim";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Salmon;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(137, 49);
            button2.Name = "button2";
            button2.Size = new Size(81, 68);
            button2.TabIndex = 0;
            button2.Text = "Yüzde 25 İndirim";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(255, 49);
            button3.Name = "button3";
            button3.Size = new Size(81, 68);
            button3.TabIndex = 1;
            button3.Text = "Yüzde 50 İndirim";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(386, 49);
            button4.Name = "button4";
            button4.Size = new Size(81, 68);
            button4.TabIndex = 2;
            button4.Text = "Yüzde 75 İndirim";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 4;
            label1.Text = "Etiket Fiyatı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 5;
            label2.Text = "İndirimli Fiyatı : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 141);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 6;
            label3.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 165);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}