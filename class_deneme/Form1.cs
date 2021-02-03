using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_deneme
{
    public partial class Form1 : Form
    {
        Random rndm = new Random();
        int horseNum = 2;
        //bool firstClick = true;
        horse[] hors = new horse[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for(int i = 0; i<5;i++)
            {
                hors[i] = new horse();
            }
            hors[0].picture = picBox_horse1;
            hors[0].startLoc = picBox_horse1.Location;
            hors[1].picture = picBox_horse2;
            hors[1].startLoc = picBox_horse2.Location;
            hors[2].picture = picBox_horse3;
            hors[2].startLoc = picBox_horse3.Location;
            hors[3].picture = picBox_horse4;
            hors[3].startLoc = picBox_horse4.Location;
            hors[4].picture = picBox_horse5;
            hors[4].startLoc = picBox_horse5.Location;
            for (int i = 0; i < horseNum; i++)
            {
                hors[i].IsInRace = true;
            }
        }

        private void UpDown_horseNum_ValueChanged(object sender, EventArgs e)
        {
            horseNum = Convert.ToInt32(UpDown_horseNum.Value);
            for(int i = 0; i < 5; i++)
            {
                if(i<horseNum)
                {
                    hors[i].IsInRace = true;
                }
                else
                {
                    hors[i].IsInRace = false;
                }
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            //if(firstClick == true)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (hors[i].IsInRace)
            //        {
            //            hors[i].picture.Visible = true;
            //            hors[i].speed = rndm.Next(10, 40);
            //        }
            //        else
            //        {
            //            hors[i].picture.Visible = false;
            //        }

            //    }
            //    timer1.Start();
            //    firstClick = false;
            //}
            //else if(firstClick == false)
            //{

            //    for(int i = 0; i < 5; i++)
            //    {

            //        hors[i].picture.Visible = false;
            //        hors[i].picture.Location = hors[i].startLoc;
            //    }
            //    firstClick = true;
            //}
            for (int i = 0; i < 5; i++)
            {
                if (hors[i].IsInRace)
                {
                    hors[i].picture.Visible = true;
                    hors[i].speed = rndm.Next(10, 40);
                }
                else
                {
                    hors[i].picture.Visible = false;
                }

            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < horseNum; i++)
            {
                hors[i].picture.Left += hors[i].speed;
                if (hors[i].picture.Left + hors[i].picture.Width >= picBox_finishLine.Left)
                    timer1.Stop();
            }


        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                hors[i].picture.Visible = false;
                hors[i].picture.Location = hors[i].startLoc;
            }
        }
        
    }
}
