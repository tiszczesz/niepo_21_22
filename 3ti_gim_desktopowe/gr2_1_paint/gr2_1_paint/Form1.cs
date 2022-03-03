namespace gr2_1_paint
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private int x = -1;
        private int y = -1;
        private bool moving = false;
        private Pen pen;

        public Form1() {
            
            InitializeComponent();
            g = panel2.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void pictureBox4_Click(object sender, EventArgs e) {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e) {
            moving = true;
            x = e.X;
            y = e.Y;
            panel2.Cursor = Cursors.Cross;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1) {
                g.DrawLine(pen,new Point(x,y),e.Location);
                x=e.X;
                y=e.Y;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e) {
            moving = false;
            x = -1;
            y = -1;

        }
    }
}