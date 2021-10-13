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
    class AI
    {
        public int score;
        int distanceToTop;
        int distanceToBottom;
        double rotation;
        int speed;
        double turnLeft, turnRight, speedUp, tooSlow;
        double distanceWeight, rotationWeight, speedWeight;
        double turningDistanceWeight, turningRotationWeight, turningSpeedWeight;
        double veloY;
        int topBound = 25, bottomBound = 400;
        Random gen = new Random();

        public bool hasCrashed;
        int Ypos;

        
        public AI(int y)
        {
            turnLeft = gen.NextDouble()*55 + 50;
            turnRight = gen.NextDouble()*55 + 50;
            speedUp = gen.NextDouble()*10;
            tooSlow = gen.NextDouble();

            distanceWeight = gen.NextDouble();
            rotationWeight = gen.NextDouble();
            speedWeight = gen.NextDouble();

            turningDistanceWeight = gen.NextDouble();
            turningRotationWeight = gen.NextDouble();
            turningSpeedWeight = gen.NextDouble();

            Ypos = y;

            rotation = gen.NextDouble() * 5;
        }


        public void updateVariables(int d2t, int d2b, double r, int s, int top, int bottom)
        {
            distanceToTop = d2t;
            distanceToBottom = d2b;
            //rotation = r;
            speed = s;
            topBound = top;
            bottomBound = bottom;
        }

        public int drive()
        {
            if (makeTurnDecision() == 1 && rotation < 15)
            {
                rotation += (turningRotationWeight*rotation) + (turningSpeedWeight * (100-speed));
            }
            else if (makeTurnDecision() == 2 && rotation > -15)
            {
                rotation -= (turningRotationWeight * rotation) + (turningSpeedWeight * (100-speed));
            }

            

            veloY = (int)(Math.Sin((rotation / 180) * (Math.PI)) * speed);

            Ypos += (int)veloY;

            checkCollision();

            return Ypos;
        }


        public int makeTurnDecision()
        {
            //0 - do nothing, 1 - turn left, 2 - turn right
            double dangerTop = ((300-distanceToTop) * distanceWeight) + (rotation * rotationWeight) + (speed * speedWeight);
            double dangerBottom = ((300-distanceToBottom) * distanceWeight) + (-rotation * rotationWeight) + (speed * speedWeight);

            if (dangerTop > dangerBottom)
            {
                if (dangerTop > turnLeft)
                {
                    return 1;
                }
                else if (dangerBottom > turnRight)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
            else if(dangerBottom > dangerTop)
            {
                if (dangerBottom > turnRight)
                {
                    return 2;
                }
                else if (dangerTop > turnLeft)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }
        public int makeSpeedDecision()
        {
            //0 - hold speed, 1 - speedUp, 2 - break
            double speedDanger = (speed/50) * Math.Abs(rotation);
            if(speedDanger > speedUp)
            {
                return 2;
            }
            else if (speedDanger < tooSlow)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public double getLeftWeight()
        {
            return turnLeft;
        }
        public double getRightWeight()
        {
            return turnRight;
        }
        public double getTooFastWeight()
        {
            return speedUp;
        }
        public double getTooSlowWeight()
        {
            return tooSlow;
        }
        public double getDistanceWeight()
        {
            return distanceWeight;
        }
        public double getRotationWeight()
        {
            return rotationWeight;
        }
        public double getSpeedWeight()
        {
            return speedWeight;
        }
        public double getTurningDistanceWeight()
        {
            return turningDistanceWeight;
        }
        public double getTurningRotationWeight()
        {
            return turningRotationWeight;
        }
        public double getTurningSpeedWeight()
        {
            return turningSpeedWeight;
        }





        public void changeWeights(double TurnLeftWeigth, double TurnRightWeight, double SpeedUpWeight, double tooSlowWeight, double Dweight, double Rweight, double Sweight, double turningDweight, double turningRweight, double turningSweight, int top, int multiplier)
        {
            score = 0;
            speed = 0;
            Ypos = 175;
           
                turnLeft = TurnLeftWeigth + ((gen.NextDouble()*(200/top)+3) - (200/(top*2)));
                turnRight = TurnRightWeight + ((gen.NextDouble() * (200 / top) + 3) - (200 / (top * 2)));
                //speedUp = SpeedUpWeight + gen.NextDouble();
                //tooSlow = tooSlowWeight + gen.NextDouble();
                distanceWeight = Math.Abs(Dweight + ((gen.NextDouble() * (200 / top) + 3) - (200 / (top * 2))));
                rotationWeight = Math.Abs(Rweight + ((gen.NextDouble() * (200 / top) + 3) - (200 / (top * 2))));
                speedWeight = Math.Abs(Sweight + ((gen.NextDouble() * (200 / top) + 3) - (200 / (top * 2))));

                turningDistanceWeight = turningDweight + (gen.NextDouble()-.5);
                turningRotationWeight = turningDweight + (gen.NextDouble() -.5);
                turningSpeedWeight = turningDweight + (gen.NextDouble() -.5);

            /* 
             if (tooSlow <= 0)
             {
                 tooSlow = gen.NextDouble();
             }
            */

            hasCrashed = false;
        }

        private void checkCollision()
        {
            if (Ypos < 125 || Ypos + 25 > 275)
            {
                hasCrashed = true;
            }
        }

        public void Reset()
        {
            rotation = 0;
            speed = 0;
        }

        public void changeRotation(double x)
        {
            rotation += x;
        }
    }
}
