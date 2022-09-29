using RecursiveAlgorithmsForm.Fractals;

namespace RecursiveAlgorithmsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            FractalTree.DrawFractal(panel1.Width / 2, panel1.Height / 2, 80, 0, e, panel1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}