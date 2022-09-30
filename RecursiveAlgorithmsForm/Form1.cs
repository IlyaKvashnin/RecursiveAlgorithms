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
            if (FractalTree.Paint == true)
            { 
                if (comboBox1.SelectedIndex == 0)
                {
                    FractalTree.DrawFractal(panel1.Width / 2, panel1.Height / 128, 220, 0, -15, 1000, e, panel1);
                } 
                else if(comboBox1.SelectedIndex == 1)
                {
                    FractalTree.DrawFractal(panel1.Width / 2, panel1.Height / 128, 220, 0, 50,1000, e, panel1);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    FractalTree.DrawFractal(panel1.Width / 2, panel1.Height / 128, 220, 0, 30, 20, e, panel1);
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    FractalTree.ExtendedDrawFractal(panel1.Width / 2, panel1.Height / 128, 220, 0, e, panel1);
                }
                             
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FractalTree.Paint = true;
            panel1.Invalidate();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            FractalTree.Paint = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }
    }
}