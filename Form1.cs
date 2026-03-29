using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garcia_IT202NS_ASSIGNMENT1_MIDTERM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PreASS1.Clear();
            PreASS2.Clear();
            PreSW1.Clear();
            PreSW2.Clear();
            PreRECI1.Clear();
            PreRECI2.Clear();
            PreLAB1.Clear();
            PreLAB2.Clear();
            PreLAB3.Clear();
            PreLAB4.Clear();
            PreQUIZ1.Clear();
            PreQUIZ2.Clear();
            PreQUIZ3.Clear();
            PreLABEXAM1.Clear();
            PreLABEXAM2.Clear();
            Preliminary1.Clear();

            MidASS1.Clear();
            MidASS2.Clear();
            MidSW1.Clear();
            MidSW2.Clear();
            MidRECI1.Clear();
            MidRECI2.Clear();
            MidLAB1.Clear();
            MidLAB2.Clear();
            MidLAB3.Clear();
            MidLAB4.Clear();
            MidQUIZ1.Clear();
            MidQUIZ2.Clear();
            MidQUIZ3.Clear();
            MidLABEXAM1.Clear();
            MidLABEXAM2.Clear();
            Midterm1.Clear();

            FinASS1.Clear();
            FinASS2.Clear();
            FinSW1.Clear();
            FinSW2.Clear();
            FinRECI1.Clear();
            FinRECI2.Clear();
            FinLAB1.Clear();
            FinLAB2.Clear();
            FinLAB3.Clear();
            FinLAB4.Clear();
            FinQUIZ1.Clear();
            FinQUIZ2.Clear();
            FinQUIZ3.Clear();
            Presentation1.Clear();
            Manuscript1.Clear();
            Final1.Clear();
            FinalGrade1.Clear();


        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                // ---------- PRELIM ----------
                double[] prelimClass = {
            double.Parse(PreASS1.Text),
            double.Parse(PreASS2.Text),
            double.Parse(PreSW1.Text),
            double.Parse(PreSW2.Text),
            double.Parse(PreRECI1.Text),
            double.Parse(PreRECI2.Text)
        };

                double prelimClassPerf = GetAverage(prelimClass);

                double prelimLab = GetAverage(new double[] {
            double.Parse(PreLAB1.Text),
            double.Parse(PreLAB2.Text),
            double.Parse(PreLAB3.Text),
            double.Parse(PreLAB4.Text)
        });

                double prelimQuiz = GetAverage(new double[] {
            double.Parse(PreQUIZ1.Text),
            double.Parse(PreQUIZ2.Text),
            double.Parse(PreQUIZ3.Text)
        });

                double prelimLabExam = GetAverage(new double[] {
            double.Parse(PreLABEXAM1.Text),
            double.Parse(PreLABEXAM2.Text)
        });

                double prelimWritten = double.Parse(Preliminary1.Text);

                double prelim =
                    (prelimClassPerf * 0.10) +
                    (prelimLab * 0.10) +
                    (prelimQuiz * 0.20) +
                    (prelimLabExam * 0.20) +
                    (prelimWritten * 0.40);

                Preliminary1.Text = prelim.ToString("F2");


                // ---------- MIDTERM ----------
                double midtermClassPerf = GetAverage(new double[] {
                double.Parse(MidASS1.Text),
                double.Parse(MidASS2.Text),
                double.Parse(MidSW1.Text),
                double.Parse(MidSW2.Text),
                double.Parse(MidRECI1.Text),
                double.Parse(MidRECI2.Text)
        });

                double midtermLab = GetAverage(new double[] {
                double.Parse(MidLAB1.Text),
                double.Parse(MidLAB2.Text),
                double.Parse(MidLAB3.Text),
                double.Parse(MidLAB4.Text)
        });

                double midtermQuiz = GetAverage(new double[] {
                double.Parse(MidQUIZ1.Text),
                double.Parse(MidQUIZ2.Text),
                double.Parse(MidQUIZ3.Text)
        });

                double midtermLabExam = GetAverage(new double[] {
                double.Parse(MidLABEXAM1.Text),
                double.Parse(MidLABEXAM2.Text)
        });

                double midtermWritten = double.Parse(Midterm1.Text);

                double midterm =
                    (midtermClassPerf * 0.10) +
                    (midtermLab * 0.10) +
                    (midtermQuiz * 0.20) +
                    (midtermLabExam * 0.20) +
                    (midtermWritten * 0.40);

                Midterm1.Text = midterm.ToString("F2");



                // ---------- FINALS ----------
                double finalsClassPerf = GetAverage(new double[] {
            double.Parse(FinASS1.Text),
            double.Parse(FinASS2.Text),
            double.Parse(FinSW1.Text),
            double.Parse(FinSW2.Text),
            double.Parse(FinRECI1.Text),
            double.Parse(FinRECI2.Text)
        });

                double finalsLab = GetAverage(new double[] {
            double.Parse(FinLAB1.Text),
            double.Parse(FinLAB2.Text),
            double.Parse(FinLAB3.Text),
            double.Parse(FinLAB4.Text)
        });

                double finalsQuiz = GetAverage(new double[] {
            double.Parse(FinQUIZ1.Text),
            double.Parse(FinQUIZ2.Text),
            double.Parse(FinQUIZ3.Text)
        });

                double finalsProject = GetAverage(new double[] {
            double.Parse(Presentation1.Text),
            double.Parse(Manuscript1.Text)
        });

                double finalsWritten = double.Parse(Final1.Text);

                double finals =
                    (finalsClassPerf * 0.05) +
                    (finalsLab * 0.10) +
                    (finalsQuiz * 0.20) +
                    (finalsProject * 0.25) +
                    (finalsWritten * 0.40);

                Final1.Text = finals.ToString("F2");


                // ---------- FINAL GRADE ----------
                double finalGrade =
                    (prelim * 0.33) +
                    (midterm * 0.33) +
                    (finals * 0.33);

                FinalGrade1.Text = finalGrade.ToString("F2");


                // ---------- NESTED IF ----------
                if (finalGrade >= 75)
                {
                    if (finalGrade >= 90)
                        MessageBox.Show("Excellent");
                    else
                        MessageBox.Show("Passed");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }

            double GetAverage(double[] scores)
            {
                double total = 0;

                for (int i = 0; i < scores.Length; i++)
                {
                    //  VALIDATION 
                    if (scores[i] < 0 || scores[i] > 100)
                    {
                        MessageBox.Show("Invalid input! (0-100 only)");
                        return 0;
                    }

                    total += scores[i];
                }

                return total / scores.Length;
            }
        }
    }
    }

