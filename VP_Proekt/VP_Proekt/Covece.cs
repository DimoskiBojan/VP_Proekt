using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Proekt.Properties;

namespace VP_Proekt
{
    public class Covece
    {
        public enum DIRECTION
        {
            UP,
            DOWN,
            LEFT,
            RIGHT

        }
        public Pomoshna pomoshna;
        public Image sad_smiley;
        public Image person;
        public int X { get; set; }
        public int Y { get; set; }
        public DIRECTION direction { get; set; }
        public int formWidth { get; set; }
        public int formHeight { get; set; }
        public bool lightColor { get; set; }

        public Covece()
        {
            
            person = Resources.Person1_Up;
            //Random X value for the person
            Random random = new Random();
            int i=random.Next(0, 9);
            X = i * person.Width;
            Y = 300;
            direction = DIRECTION.UP;
            sad_smiley = Resources.sad_smiley;
        }
        //Checks if the location of person is in between the start of Zebra and the end of Zebra
        public bool CheckLocation()
        {
            //Zebra Width=2 * person.Width
            //semaphore Width=90
            int startOfZebra = formWidth - 90 - 2 * person.Width - 20;
            int endOfZebra = startOfZebra + 2 * person.Width;

            if(X>=startOfZebra-10 && X+person.Width<=endOfZebra+10)
            {
                return true;
            }

            return false;
        }
        public void ChangeDirection(DIRECTION d)
        {
            direction = d;
        }
        public void Move ()
        {
            
            if(direction==DIRECTION.UP)
            {
                person = Resources.Person1_Up;
                if((Y-10)>0)
                {
                    Y -= 10;
                }
                //If the person goes UP and he is not in between the Zebra 
                if(!CheckLocation())
                {
                    pomoshna = new Pomoshna();
                    pomoshna.text1 = "Упс";
                    pomoshna.text2 = "Улицата се поминува само на пешачки премин";
                    pomoshna.text3 = "Обиди се повторно ";
                    pomoshna.buttonYes = "Да";
                    pomoshna.buttonNo = null;
                    pomoshna.smiley = sad_smiley;
                    pomoshna.Show();
                    Y += 10;
                }
                else
                {
                    //If the person goes UP and he is in between the Zebra but the trafic light is green
                    if (!lightColor && X<=formHeight/2)
                    {
                        pomoshna = new Pomoshna();
                        pomoshna.text1 = "На добар пат си да ја поминеш улицата";
                        pomoshna.text2 = "Тргна на зелено, но ти се уклучи црвено";
                        pomoshna.text3 = "Не се враќај продолжи до одиш";
                        pomoshna.buttonYes = "Продилжи со играта";
                        pomoshna.buttonNo = null;
                        pomoshna.smiley = Resources.smiley;
                        pomoshna.Show();
                        Y -= 10;
                    }
                    //If the person goes UP and he is in between the Zebra but the trafic light is red 
                    if (!lightColor && X > formHeight / 2)
                    {
                        Y = 300;
                        pomoshna = new Pomoshna();
                        pomoshna.text1 = "Немаш време да ја поминеш улицата";
                        pomoshna.text2 = "Врати се назад";
                        pomoshna.text3 =null;
                        pomoshna.buttonYes = "Продолжи со играта";
                        pomoshna.buttonNo = null;
                        pomoshna.smiley = sad_smiley;
                        pomoshna.Show();
                    }
                }
               


            }
            if (direction == DIRECTION.LEFT)
            {
                person = Resources.Person1_Left;
                if ((X - 10) > 0)
                {
                    X-= 10;
                }
                if(Y<300)
                {
                    //the person is on the Zebra and wants to go  Left
                    if (!CheckLocation())
                    {
                        pomoshna = new Pomoshna();
                        pomoshna.text1 = "Не Не";
                        pomoshna.text2 = "Движи се по пешачкиот премир, не оди лево и десно";
                        pomoshna.text3 = "Обиди се повторно ";
                        pomoshna.buttonYes = "Да";
                        pomoshna.buttonNo = null;
                        pomoshna.smiley = sad_smiley;
                        pomoshna.Show();
                        X += 10;
                    }
                }
                
                

            }
            if (direction == DIRECTION.RIGHT)
            {
                person = Resources.Person1_Right;
                if ((X + 10) < formWidth-person.Width)
                {
                    X += 10;
                }
                if (Y < 300)
                {
                    //the person is on the Zebra and wants to go Right 
                    if (!CheckLocation())
                    {
                        pomoshna = new Pomoshna();
                        pomoshna.text1 = "Не Не";
                        pomoshna.text2 = "Движи се по пешачкиот премир, не оди лево и десно";
                        pomoshna.text3 = "Обиди се повторно ";
                        pomoshna.buttonYes = "Да";
                        pomoshna.buttonNo = null;
                        pomoshna.smiley = sad_smiley;
                        pomoshna.Show();
                        X -= 10;
                    }
                }


            }
           

        }
         public void Draw(Graphics g)
        {
            g.DrawImage(person, X, Y, person.Width, person.Height);
        }




    }
}
