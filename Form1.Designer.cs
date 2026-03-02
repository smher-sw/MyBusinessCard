namespace MyBusinessCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 293);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(356, 19);
            label1.Name = "label1";
            label1.Size = new Size(172, 65);
            label1.TabIndex = 1;
            label1.Text = "허성민";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("한컴 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(383, 112);
            label2.Name = "label2";
            label2.Size = new Size(218, 46);
            label2.TabIndex = 2;
            label2.Text = "컴퓨터공학과";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("한컴 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(384, 171);
            label3.Name = "label3";
            label3.Size = new Size(367, 46);
            label3.TabIndex = 3;
            label3.Text = "smher68@gmail.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.FromArgb(0, 192, 0);
            label4.Location = new Point(384, 230);
            label4.Name = "label4";
            label4.Size = new Size(217, 40);
            label4.TabIndex = 4;
            label4.Text = "010-8950-9350";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Font = new Font("바탕체", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(490, 377);
            button1.Name = "button1";
            button1.Size = new Size(260, 61);
            button1.TabIndex = 5;
            button1.Text = "배경색상 변경";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Font = new Font("나눔고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.ForeColor = Color.Fuchsia;
            button2.Location = new Point(108, 361);
            button2.Name = "button2";
            button2.Size = new Size(161, 49);
            button2.TabIndex = 6;
            button2.Text = "사진 변경";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.Font = new Font("나눔고딕", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.ForeColor = Color.Blue;
            button3.Location = new Point(384, 292);
            button3.Name = "button3";
            button3.Size = new Size(161, 49);
            button3.TabIndex = 7;
            button3.Text = "GitHub";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
