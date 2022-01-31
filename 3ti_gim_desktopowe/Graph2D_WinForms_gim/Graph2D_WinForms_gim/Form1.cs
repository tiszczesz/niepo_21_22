namespace Graph2D_WinForms_gim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

            Pen p = new Pen(Color.Red, 2);
            e.Graphics.DrawLine(p,10,10,200,150);
            e.Graphics.DrawLine(p, 110, 40, 200, 150);
        }
    }
}