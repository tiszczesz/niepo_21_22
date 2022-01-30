namespace WinFormsPaint1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var g = panel2.CreateGraphics();
            Color black = Color.Black;
            Pen p1 = new Pen(black, 5);
            g.DrawLine(p1,10,10,50,100);
        }
    }
}