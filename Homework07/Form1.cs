using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Homework07
{
    public partial class Form1 : Form
    {
        private int count = 100; // Initialize the count variable with a value of 100
        private Timer timer = new Timer();  // Declare a Timer variable


        public Form1()
        {
            InitializeComponent();
            timer = new Timer(); // Create a new instance of Timer
            timer.Interval = 1000; // Set the interval of the timer to 1000 milliseconds (1 second)
            timer.Tick += timer1_Tick; // Attach the timer_Tick event handler to the Tick event of the timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--; // Decrement the count variable by 1
            label1.Text = count.ToString(); // Update the text of the label with the current count value
            if (count <= 0)
            {
                timer.Stop(); // Stop the timer
                MessageBox.Show("時間到!"); // Display a message box indicating that time is up
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start(); // Start the timer
            timer.Interval = 1000;
        }

        
    }
}
