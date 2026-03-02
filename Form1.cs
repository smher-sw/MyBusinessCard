namespace MyBusinessCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            // 0~255 사이의 R, G, B 값을 무작위로 생성하여 배경색에 적용
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/smher-sw/",
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 이미지 리소스를 추가한 후 다음과 같이 사용하세요:
            pictureBox1.Image = Properties.Resources.photo2;
        }

    }
}
