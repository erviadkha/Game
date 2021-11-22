using System;

namespace Game
{
     class Hantu : serangan
    {
        public string Valak { get; set;}
        public string Vampir { get; set;}
        public string  Zombie { get; set;}
        public Hantu(string vampir, string valak, string zombie )
        {
            Vampir = vampir;
            Valak = valak;
            Zombie = zombie;
            int Nyawa = 3;
            int Nyawa2 = 5; 
            int Nyawa3= 5;

            while(Nyawa>0 | Nyawa2>0 | Nyawa3>0)
            {
                Console.WriteLine($"1.{Vampir} ({Nyawa}) \n 2. { Valak } ({Nyawa2}\n { Zombie} ({Nyawa3}");
                int pilih=Convert.ToInt32(Console.ReadLine());
                
                if (pilih == 1)
                {
                    Nyawa -= Critical;
                    Console.WriteLine($"Nyawa { Valak} masih {Nyawa}");
                }
                    if (Nyawa == 0)
                    {
                        Console.WriteLine($"{Valak} menghilang");
                    }

                if(pilih == 2)
                {
                    Nyawa2 -= Critical;
                    Console.WriteLine($"Nyawa { Vampir } masih {Nyawa}");
                    if (Nyawa2 == 0)
                    {
                        Console.WriteLine($"{Vampir} menghilang");
                    }
                }

                if(pilih == 3)
                {
                    Nyawa3 -= Critical;
                    Console.WriteLine($"Nyawa {Zombie} masih {Nyawa}");
                    if (Nyawa3 ==0)
                    {
                        Console.WriteLine($"{Zombie} menghilang");
                    }
                }
            }


        }
    }
}