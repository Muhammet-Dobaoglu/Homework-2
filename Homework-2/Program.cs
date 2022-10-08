#region Asal Sayı

Console.Write("Sayıyı giriniz:");

int sayi = int.Parse(Console.ReadLine());
bool asaldegil = false;  

if (sayi <= 0) 
    Console.WriteLine("Asal sayılar sıfırdan küçük olmaz...");


else
{
    for (int i = 2; i < sayi; i++)
    { 
        if (sayi % i == 0)
        {
            asaldegil = true;     
        }
    }

    if (asaldegil==true)  
        Console.WriteLine(sayi + " Asal Sayı Değildir..."); 
    else
        Console.WriteLine("Asal Sayıdır...");    
}

Console.ReadLine();

#endregion