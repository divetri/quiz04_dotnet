// See https://aka.ms/new-console-template for more information
bool testing = false;
while (!testing)
{
    Console.Write("Masukan No Soal:");
    int no = Convert.ToInt32(Console.ReadLine());
    switch (no)
    {
        case 1:
            quiz04_dotnet.Solution.Soal1();
            break;
        case 2:
            quiz04_dotnet.Solution.Soal2();
            break;
        case 3:
            quiz04_dotnet.Solution.Soal3();
            break;
        case 4:
            quiz04_dotnet.Solution.Soal4();
            break;
        case 5:
            quiz04_dotnet.Solution.Soal5();
            break;
        case 6:
            quiz04_dotnet.Solution.Soal6();
            break;
        case 7:
            quiz04_dotnet.Solution.Soal7();
            break;
        case 8:
            quiz04_dotnet.Solution.Soal8();
            break;
        case 9:
            quiz04_dotnet.Solution.Soal9();
            break;
        default:
            Console.WriteLine($"Tidak ada nomor soal {no}");
            break;
    }
option:
    Console.Write("Lanjut?(y/n)");
    string opt = Console.ReadLine();
    if (opt == "n")
    {
        Console.WriteLine("Terima Kasih");
        testing = true;
    }
    else if (opt == "y")
    {
        Console.Clear();
    }
    else
    {
        Console.Clear();
        goto option;
    }
};