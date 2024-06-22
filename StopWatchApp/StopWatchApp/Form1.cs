using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection.Emit;

namespace StopWatchApp
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += timertick;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            timer.Start();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            timer.Stop();
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            timer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            timer.Stop();
            MessageBox.Show(label2.Text);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            label2.Text = "00:00:00";

        }

        private void timertick(object sender, EventArgs e)
        {
            TimeSpan Span = stopwatch.Elapsed;
            label2.Text = String.Format("{0:00}:{1:00}:{2:00}", Span.Hours, Span.Minutes, Span.Seconds);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
