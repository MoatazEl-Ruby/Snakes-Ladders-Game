using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes_and_Ladders
{
    public partial class Form1 : Form
    {
      
        private bool flag2 = true; // Display Player  No. and which player will make move 
       
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int DiceNumber = rnd.Next(1, 7);
            textBox2.Text = DiceNumber.ToString();

            if (flag2 == true)
            {
                textBox1.Text = "1";
                flag2 = false;
            }
            else
            {
                textBox1.Text = "2";
                flag2 = true;
            }


            int x1 = this.pictureBox2.Location.X;
            int y1 = this.pictureBox2.Location.Y;
            int x2 = this.pictureBox3.Location.X;
            int y2 = this.pictureBox3.Location.Y;



            for (int i = 0; i < DiceNumber; i++)
            {
                
                
                
                    if (flag2 == false) // First If  Control Which Player will Play
                    {
                        if (Switch.flag == true) // Second if Control  direction of play
                        {

                            x1 += 35;
                            if (x1 > 572) // Third if control transition  from row to row 
                            {
                                x1 = 544;
                                y1 -= 36;
                                Switch.flag = false;
                            }
                        }
                        else if (Switch.flag == false)
                        {
                            x1 -= 35;
                            if (x1 < 220)
                            {


                                x1 = 226;
                                y1 -= 36;
                               Switch.flag = true;

                            }
                        }

                    }
                    else if (flag2 == true) // Flag2 = True
                    {
                        if (Switch.flag7 == false)
                        {
                            x2 -= 35;
                            if (x2 < 220)
                            {
                                x2 = 226;
                                y2 -= 36;
                                Switch.flag7 = true;
                            }
                        }
                        else if (Switch.flag7 == true)
                        {
                            x2 += 35;
                            if (x2 > 572)
                            {
                                x2 = 544;
                                y2 -= 36;
                                Switch.flag7 = false;
                            }
                        }
                    }
                

                if (textBox1.Text == "1")
                {
                    Switch.counter1++;
                }
                else if (textBox1.Text == "2")
                {
                    Switch.counter2++;
                }

                if (Switch.counter1 == 100) // Fourth if Display the Winner and Close the form
                {

                    this.pictureBox2.Location = new Point(x1 = 226, y1 = 44);
                    MessageBox.Show($"The Winner Is Player 1");
                    this.Close();

                }
                else if (Switch.counter2 == 100)
                {
                    this.pictureBox3.Location = new Point(x2 = 226, y2 = 44);

                    MessageBox.Show($"The Winner Is Player 2");
                    this.Close();
                }

            }
            if (textBox1.Text == "1")
            {
                Point p1 = new Point(x1, y1);
                this.pictureBox2.Location = Switch.SwitchPoint1(Switch.counter1, p1);
                this.textBox3.Text = (Switch.counter1).ToString();

            }
            else if (textBox1.Text == "2")
            {
                Point p2 = new Point(x2, y2);
                this.pictureBox3.Location = Switch.SwitchPoint2(Switch.counter2, p2);
                this.textBox4.Text = (Switch.counter2).ToString();


            }

        }
    }
}




