namespace WinForms_gr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {
            Pen p1 = new Pen(Color.OrangeRed, 3);
            Brush b1 = new SolidBrush(Color.Bisque);
            
            e.Graphics.FillRectangle(b1,120,150,50,200);
            e.Graphics.DrawRectangle(p1,100,100,200,120);
            e.Graphics.DrawEllipse(p1,230,250,100,100);
            e.Graphics.DrawLine(p1,50,50,300,30);
        }
    }
}