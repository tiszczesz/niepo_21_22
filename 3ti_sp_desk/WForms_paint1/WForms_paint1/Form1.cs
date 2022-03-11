namespace WForms_paint1
{
    public partial class Form1 : Form {
        private Graphics g;
        private int x = -1;
        private int y = -1;
        private bool moving = false;
        private Pen pen;
        public Form1()
        {
            InitializeComponent();

           

        }

        private void pictureBox4_Click(object sender, EventArgs e) {
            PictureBox pb = (PictureBox)sender;
            pen.Color = pb.BackColor;
        }

        private void panetToPaint_MouseDown(object sender, MouseEventArgs e) {
            moving = true;
            x = e.X;
            y = e.Y;
            panelToPaint.Cursor = Cursors.Cross;
        }

        private void panetToPaint_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
           
            panelToPaint.Cursor = Cursors.Default;
        }

        private void panetToPaint_MouseMove(object sender, MouseEventArgs e) {
            if (moving && x != -1 && y != -1) {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y= e.Y;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            //System.Drawing.Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            //panelToPaint.Width = workingArea.Width;
            //panelToPaint.Height = workingArea.Height;
        }

        private void panelToPaint_Paint(object sender, PaintEventArgs e)
        {
            g = panelToPaint.CreateGraphics();
           // g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
    }
}