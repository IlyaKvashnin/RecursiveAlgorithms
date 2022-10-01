﻿using HanoiTowers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using RecursiveAlgorithmsForm.Fractals;

namespace RecursiveAlgorithmsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            if (FractalTree.Paint == true)
            { 
                if (comboBox1.SelectedIndex == 0)
                {
                    FractalTree.DrawFractal(panel1.Width / 2, panel1.Height / 128, 220,0, -15, 1000, e, panel1);
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
                else
                {
                    string str = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    double v = double.Parse(str);
                    FractalTree.DrawFractal(panel1.Width / 2, panel1.Height / 128, 220, 0, v, 1000, e, panel1);

                }

            }
        }

        private void btnStartFractal_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Solver s = new Solver();
        Random rnd = new Random();
        int moveIndex = 0;
        List<Move> solutionMoves = new List<HanoiTowers.Move>();
        List<Button> Pole1 = new List<Button>();
        List<Button> Pole2 = new List<Button>();
        List<Button> Pole3 = new List<Button>();
        List<Button> btnstoDelete = new List<Button>();


        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SolveFor(3);
            init(3);
        }

        private void SolveFor(int diskSize)
        {
            solutionMoves = s.SolveHanoi(diskSize);
            int i = 1;
            listBox1.Items.Clear();
            foreach (Move m in solutionMoves)
            {
                listBox1.Items.Add(i + ". " + m.poleFrom + "→ " + m.poleTo);
                i++;
            }
            
        }

        private void init(int diskSize)
        {
            Pole1.Clear();
            Pole2.Clear();
            Pole3.Clear();
            button3.Enabled = true;
            
            foreach (Control c in this.Controls)
            {
                Button b = c as Button;
                if (null != b)
                { btnstoDelete.Add(b); }
            }
            foreach (Button b in btnstoDelete)
            {
                b.Dispose();
            }
            Button btn = new Button();
            for (int i = 0; i < diskSize; i++)
            {
                btn = new Button();
                btn.Location = new Point(342 + (i * 5), 306 - (i * 20));
                btn.Size = new Size(132 - (i * 10), 20);
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = RandomColor();
                btn.BringToFront();
                this.Controls.Add(btn);
                this.Controls.SetChildIndex(btn, 100);
                btn.BringToFront();
                Pole1.Add(btn);
            }
            pictureBox1.SendToBack();
        }

        private Color RandomColor()
        {
            return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            string input = "";
            ShowInputDialog(ref input);
            int n;
            if (!int.TryParse(input, out n) || n > 15 || input == "")//More than 15 is solveable. But the button heights arent responsible. So it doesnt fit in the screen :)
            {
                MessageBox.Show("Введите число от 3 до 10");
                //txtDurum.Text = "Please enter numeric between 3-15";
            }
            else
            {
                SolveFor(Convert.ToInt16(input));
                init(Convert.ToInt16(input));
            }
        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            //Nothing to do here. 
            //Copy-Paste code from stackoverflow to show an inputdialog!
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            inputBox.ClientSize = size;
            inputBox.Text = "Введите число от 3 до 10";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void btnStartHanoiTowers_Click(object sender, EventArgs e)
        {
            moveIndex = 0;
            timer2.Start();
            button3.Enabled = false;
        }
        private void makeMove(Move m)
        {

            Button btntoMove = new Button(); //Get the last element of a pole which is on the top.

            switch (m.poleTo)
            {
                case 1:
                    switch (m.poleFrom)
                    {
                        case 2:
                            btntoMove = Pole2.Last();
                            moveButton(btntoMove, 1);
                            Pole1.Add(btntoMove);
                            Pole2.RemoveAt(Pole2.Count - 1);
                            break;
                        case 3:
                            btntoMove = Pole3.Last();
                            moveButton(btntoMove, 1);
                            Pole1.Add(btntoMove);
                            Pole3.RemoveAt(Pole3.Count - 1);
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (m.poleFrom)
                    {
                        case 1:
                            btntoMove = Pole1.Last();
                            moveButton(btntoMove, 2);
                            Pole2.Add(btntoMove);
                            Pole1.RemoveAt(Pole1.Count - 1);
                            break;
                        case 3:
                            btntoMove = Pole3.Last();
                            moveButton(btntoMove, 2);
                            Pole2.Add(btntoMove);
                            Pole3.RemoveAt(Pole3.Count - 1);
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    switch (m.poleFrom)
                    {
                        case 2:
                            btntoMove = Pole2.Last();
                            moveButton(btntoMove, 3);
                            Pole3.Add(btntoMove);
                            Pole2.RemoveAt(Pole2.Count - 1);
                            break;
                        case 1:
                            btntoMove = Pole1.Last();
                            moveButton(btntoMove, 3);
                            Pole3.Add(btntoMove);
                            Pole1.RemoveAt(Pole1.Count - 1);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }


        }
        private void moveButton(Button toMove, int PoleIndex)
        {
            Point startPoint = toMove.Location;
            Point endPoint = new Point();
            switch (PoleIndex)
            {
                case 1:
                    endPoint = new Point(342 + ((132 - toMove.Size.Width) / 2), 306 - ((Pole1.Count()) * 20));
                    break;
                case 2:
                    endPoint = new Point(482 + ((132 - toMove.Size.Width) / 2), 306 - ((Pole2.Count()) * 20));
                    break;
                case 3:
                    endPoint = new Point(622 + ((132 - toMove.Size.Width) / 2), 306 - ((Pole3.Count()) * 20));
                    break;
                default:
                    break;
            }

            for (int i = 0; i <= 5; i++)
            {
                toMove.Location = new Point(startPoint.X + Convert.ToInt16((Convert.ToDecimal(endPoint.X) - startPoint.X) / 5 * i), startPoint.Y + (endPoint.Y - startPoint.Y) / 5 * i); // Converts are for decimal divides
                toMove.BringToFront();
                this.Refresh();
                Thread.Sleep(20);
            }
        }
        private void cmbHiz_IndexChanged(object sender, EventArgs e)
        {
            switch (cmbHiz.SelectedIndex)
            {
                case 0: timer2.Interval = 2000; break;
                case 1: timer2.Interval = 1000; break;
                case 2: timer2.Interval = 500; break;
                case 3: timer2.Interval = 250; break;
                case 4: timer2.Interval = 200; break;
                default: break;
            }
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

            switch (e.TabPageIndex)
            {
                case 0:
                    init(3);
                    break;
                case 1:
                    foreach (Control c in this.Controls)
                    {
                        Button b = c as Button;
                        if (null != b)
                        { btnstoDelete.Add(b); }
                    }
                    foreach (Button b in btnstoDelete)
                    {
                        b.Dispose();
                    }
                    break;
                default:
                    MessageBox.Show("Шойтан, как ты суда попал?");
                    break;
            }
            
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (moveIndex < solutionMoves.Count)
            {
                Move m = solutionMoves.ElementAt(moveIndex);
                makeMove(m);
                moveIndex++;
                listBox1.SelectedIndex = moveIndex - 1;
            }
            else
            {
                timer2.Stop();
                button3.Enabled = false;
            }
        }
    }
}