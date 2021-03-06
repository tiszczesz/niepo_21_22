namespace Graph2D_WinForms_gim
{
    public partial class Form1 : Form {
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

            Pen p = new Pen(Color.Red, 2);
            
            Pen p2 = new Pen(Color.Blue, 2);
            Brush b1 = new SolidBrush(Color.Yellow);
            //prostokat
            //kolko
            
            e.Graphics.DrawRectangle(p2,300,200,300,200);
            e.Graphics.FillRectangle(b1,100,100,60,80);
            e.Graphics.DrawLine(p, 10, 10, 200, 150);
            e.Graphics.DrawLine(p, 110, 40, 200, 150);
        }

        private void button1_Click(object sender, EventArgs e) {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                var color = colorDialog1.Color;
                Pen p2 = new Pen(color);
                int size = Convert.ToInt32(numericUpDown1.Text);
                g.DrawEllipse(p2, 200, 200, size, size);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var color = colorDialog1.Color;
                Brush b1 = new SolidBrush(color);
                int size = Convert.ToInt32(numericUpDown1.Text);
                g.FillRectangle(b1, 300, 300, size, size);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var color = colorDialog1.Color;
                Pen p2 = new Pen(color);
                int size = Convert.ToInt32(numericUpDown1.Text);
                g.DrawRectangle(p2, 400, 400, size, size);
            }

        }
    }
}