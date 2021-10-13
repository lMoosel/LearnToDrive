using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnToDrive
{
    public partial class Form1 : Form
    {
        Random gen = new Random();
        
        AI[] cars = new AI[50];
        PictureBox[] models = new PictureBox[50];
        bool forward,left1,right1, revers1;
        double veloX, veloY;
        double rotation;
        double bestLeftWeight, bestRightWeight, bestTooFastWeight, bestTooSlowWeight;
        double bestDistanceWeight, bestRotationWeight, bestSpeedWeight;
        double bestTurningDistanceWeight, bestTurningRotationWeight, bestTurningSpeedWeight;
        int topScore = 1, last1Score, last2Score, last3score;
        int topBound = 25, bottomBound = 400;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //can I put a break point here
        }

        int count;

        public Form1()
        {
            InitializeComponent();
            rotation = 1;           
            tmrUpdate.Start();
            for (int i = 0; i <= 49; i++)
            {
                models[i] = new PictureBox();
                models[i].Image = LearnToDrive.Properties.Resources.Car;
                models[i].Location = new Point(5*i,200);
                models[i].Width = 50; models[i].Height = 25;
                models[i].Visible = true;
                this.Controls.Add(models[i]);
                cars[i] = new AI(200);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.W)
            {
                forward = false;
            }
            if (e.KeyData == Keys.D)
            {
               left1 = false;
            }
            if (e.KeyData == Keys.A)
            {
               right1 = false;
            }
            if (e.KeyData == Keys.S)
            {
                revers1 = false;
            }
        }

        private void picCar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyData == Keys.W)
            {
                forward = true;
            }
            if (e.KeyData == Keys.D)
            {
               left1 = true;
            }
            if (e.KeyData == Keys.A)
            {
               right1 = true;
            }
            if (e.KeyData == Keys.S)
            {
                revers1 = true;
            }
            
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            /*
            if (forward)
            {
                veloX += .75 * (110 - veloX)/110;
            }
            else if (revers1 && veloX > -6)
            {
                veloX -= 3;
            }
            else if (veloX > 1)
            {
                veloX -= 1;
            }
            else if (veloX < -1)
            {
                veloX += 1;
            }
            else
            {
                veloX = 0;
            }
           */

            veloX += .75 * (100 - veloX) / 100;
            picTop1.Left -= (int)veloX;
            picTop2.Left -= (int)veloX;
            picTop3.Left -= (int)veloX;
            picBottom1.Left -= (int)veloX;
            picBottom2.Left -= (int)veloX;
            picBottom3.Left -= (int)veloX;

            if (picTop1.Right < 1)
            {
                picTop1.Left = picTop3.Right;
                
                foreach(AI car in cars)
                {
                    car.score += 1;
                }
            }
            if (picTop2.Right < 1)
            {
                picTop2.Left = picTop1.Right;
               
                foreach (AI car in cars)
                {
                    car.score += 1;
                }
            }
            if (picTop3.Right < 1)
            {
                picTop3.Left = picTop2.Right;
                
                foreach (AI car in cars)
                {
                    car.score += 1;
                }
            }
            if (picBottom1.Right < 1)
            {
                picBottom1.Left = picBottom3.Right;
                
            }
            if (picBottom2.Right < 1)
            {
                picBottom2.Left = picBottom1.Right;
                
            }
            if (picBottom3.Right < 1)
            {
                picBottom3.Left = picBottom2.Right;
                
            }

            if (picTop1.Left > 400)
            {
                picTop1.Left = picTop2.Left - 200;
            }
            if (picTop2.Left > 400)
            {
                picTop2.Left = picTop3.Left - 200;
            }
            if (picTop3.Left > 400)
            {
                picTop3.Left = picTop1.Left - 200;
            }
            if (picBottom1.Left > 400)
            {
                picBottom1.Left = picBottom2.Left - 200;
            }
            if (picBottom2.Left > 400)
            {
                picBottom2.Left = picBottom3.Left - 200;
            }
            if (picBottom3.Left > 400)
            {
                picBottom3.Left = picBottom1.Left - 200;
            }
            int carNum = 0;
            count += 1;
            foreach (AI car in cars)
            {
                if (car.hasCrashed)
                {
                    Reset(car);
                }

                
                    if (count % 30 == 0)
                    {
                        car.changeRotation(gen.NextDouble() * (car.score/10) - (car.score/20));
                    }
                

                car.updateVariables(-(picTop1.Bottom - models[carNum].Top), -(models[carNum].Bottom - picBottom1.Top), rotation, (int)veloX, topBound, bottomBound);
                models[carNum].Top = car.drive();
                carNum++;
            }


            
            lblSpeed.Text = "Current Speed: " + veloX;
            
            

            
           
        }

        int x = 1, y, resets, resetsSinceRecord;
        double average;
        private void Reset(AI car)
        {
            average = ((average * resets) + car.score) / (resets + 1);
            resets += 1;
            resetsSinceRecord += 1;
            

            if (average < car.score)
            {
                x = 1;
            }
            else
            {
                x = -1;
            }

            car.Reset();

            last3score = last2Score;
            last2Score = last1Score;
            last1Score = car.score;

            

            if (car.score > topScore)
            {
                topScore = car.score;
                bestLeftWeight = car.getLeftWeight();
                bestRightWeight = car.getRightWeight();
                bestTooFastWeight = car.getTooFastWeight();
                bestDistanceWeight = car.getDistanceWeight();
                bestRotationWeight = car.getRotationWeight();
                bestSpeedWeight = car.getSpeedWeight();
                bestTurningDistanceWeight = car.getTurningDistanceWeight();
                bestTurningRotationWeight = car.getTurningRotationWeight();
                bestTurningSpeedWeight = car.getTurningSpeedWeight();
                resetsSinceRecord = 0;
            }
            
           

            

            lblBestScore.Text = "Best Score: " + topScore;
            lblLastScore.Text = "Last Score: " + car.score;
            lblLast3Average.Text = "Average (Last 3): " + (last1Score + last2Score + last3score) / 3;
            lblAverage.Text = "Average: " + (int)average;

            
                
            
            car.changeWeights(bestLeftWeight, bestRightWeight, bestTooFastWeight, bestTooSlowWeight, bestDistanceWeight, bestRotationWeight, bestSpeedWeight, bestTurningDistanceWeight, bestTurningRotationWeight, bestTurningSpeedWeight, topScore, resetsSinceRecord);
            

            count = 1;

        }

    }
}
