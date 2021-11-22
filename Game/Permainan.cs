using System;

namespace Game
{
    public class Permainan
    {
        public Permainan()
        {
            while(true)
            {
                    Console.WriteLine("apa yang kamu lakukan?");
                    Console.WriteLine("1. lihat hantu itu \n 2. serang hantu \n 3. lihat nyawa hantu \n ");
                    int pilihanmenu= Convert.ToInt32(Console.ReadLine());
                    if (pilihanmenu==1)
                    {
                         Console.WriteLine("mereka adalah Vampir,Valak,Zombie\ndan kamu mempunyai (5) nyawa");
                    }

                    if (pilihanmenu==2)
                    {
                        Hantu Hantu = new Hantu(" Valak", "Vampir", "Zombie");   
                    }

                    if (pilihanmenu==3)
                    {
                         Hantu Hantu = new Hantu(" Valak", "Vampir", "Zombie");    
                    }

            
            }


        }
    }
}