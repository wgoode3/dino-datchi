using System;

namespace Dojodatchi.Models
{
    public class Datchi
    {
        public int meals;
        public int happiness;
        public int energy;
        public int fullness;
        public string image;
        public string message;
        public bool isActive;
        public Datchi()
        {
            meals=3;
            happiness = 20;
            fullness =20;
            energy=50;
            image="Dachi_default.gif";
            message="You just adopted a Dojodatchi!";
            isActive = true;
        }
        public void Feed()
        {
            this.image="Dachi_eating.gif";
            if (this.meals >0)
            {
                this.meals -=1;
                Random random = new Random();
                if (random.Next(4)==0)
                {
                    this.message="ops! the meal was not good!";
                }else{
                    this.fullness += random.Next(5,11);
                    this.message="wow! the food was good";
                }
            }else{
                this.message="ops! we don't have enogh meals! good bye";
            }
            
        }
        public void Play(){
            this.image="Dachi_playing.gif";
            this.energy-=5;
            Random random = new Random();
            if (random.Next(4)==0){
                this.message="Dojodachi is bored.";
            }
            else{
                this.happiness+= random.Next(5,11);
                this.message="Dojodachi had fun!";
            }
        }
        public void Sleep()
        {
            this.image="Dachi_multiplying.gif";
            this.energy+=15;
            this.fullness-=5;
            this.happiness-=5;
            this.message="Dojodachi woke up rested!";
        }
        public void Work()
        {
            this.image="Dachi_speaking.gif";
            this.energy-=5;
            Random random = new Random();
            this.meals+=random.Next(1,4);
            this.message="Work completed.";
        }
        public bool _CheckGameOver()
        {
            if(happiness==0 || energy==0 || fullness==0)
            {
                this.message="Game over!";
                this.image="Dachi_angry.gif";
                this.isActive = false;
                return true;
            }
            else if(happiness>99 && energy>99 && fullness>99)
            {
                this.message="You win!";
                this.image="Dachi_happy.gif";
                this.isActive = false;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}