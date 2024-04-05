using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DigitalClock
{
    public partial class digitalClock : Form
    {
        public digitalClock()
        {
            InitializeComponent();
            redButton.FlatStyle = FlatStyle.Flat;
            orangeButton.FlatStyle = FlatStyle.Flat;
            bluebutton.FlatStyle = FlatStyle.Flat;  
            greenButton.FlatStyle = FlatStyle.Flat;
            yellowButton.FlatStyle = FlatStyle.Flat;
            magentaButton2.FlatStyle = FlatStyle.Flat;
        }



        private void digitalClock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
            dateLabel.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Red;
            dateLabel.ForeColor = Color.Red;
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor= Color.Orange;
            dateLabel.ForeColor = Color.Orange;

        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor=(Color.Yellow);
            dateLabel.ForeColor = Color.Yellow;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor=(Color.Green);
            dateLabel.ForeColor = Color.Green;
        }

        private void bluebutton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor=((Color)Color.Blue);
            dateLabel.ForeColor=((Color)Color.Blue);
        }

        private void magentaButton2_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor =((Color)Color.Magenta); 
            dateLabel.ForeColor=(Color)Color.Magenta;
        }

        private void styleButton1_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Impact", 90, FontStyle.Regular);
        }

        private void styleButton2_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Harlow Solid", 90, FontStyle.Italic | FontStyle.Bold);
        }

        private void styleButton3_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Algerian", 90, FontStyle.Regular);
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }


        private void changeBackgroundButton_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(@"C:\Users\mjavih\Desktop\Codes\csharp project\DigitalClock\Background.png");
            this.BackgroundImage = b;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}
