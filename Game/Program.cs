// See https://aka.ms/new-console-template for more information


Console.WriteLine("Welcome to Game");
Console.WriteLine(" Siapa namamu? ");
var name = Console.ReadLine();
Console.WriteLine("Welcome" +name);
Console.WriteLine("hantu: Saat ini kamu ada di dalam rumah hantu");
Console.WriteLine(name + ": Suara siapa itu?");
Console.WriteLine("hantu : kamu tidak perlu tau siapa saya");
Console.WriteLine("hantu : saat ini kamu sedang di datangi vampir,valak,zombie");
Console.WriteLine("apa yang kamu lakukan?");
Console.WriteLine("1. lihat hantu itu \n 2. serang hantu \n 3. lihat nyawa hantu \n 4. serang hantu");
while(true)
{
    int pilihanmenu= Convert.ToInt32(Console.ReadLine());
    if (pilihanmenu==1)
    {
        Console.WriteLine("mereka adalah vampir,valak,zombie\ndan kamu mempunyai 3 nyawa");
    }

    if (pilihanmenu==2)
    {
        Console.WriteLine("pilih salah satu:\n 1.vampir \n 2. valak \n 3. zombie");
        Console.WriteLine("kamu mengenainya");
        int serangmusuh = Convert.ToInt32(Console.ReadLine());
        if(serangmusuh == 1)
        {
            Console.WriteLine("vampir diserang !!!");
        }

        if (serangmusuh == 2)
        {
            Console.WriteLine(" Valak diserang !!!");
        }

        if (serangmusuh == 3)
        {
            Console.WriteLine(" zombie sedang diserang ");
        }
    }

    if (pilihanmenu==3)
    {
        Console.WriteLine("nyawa 3");
    }
    
}




