using System;

namespace recursive_extension_metotlar;

class Program
{
    static void Main(string[] args)
    {
        // Rekürsif - Özyinelemeli
        // 3^4 = 3*3*3*3

        int result = 1;
        for (int i = 1; i < 5; i++) 
            result *= 3; // 3 9 27  81
        Console.WriteLine(result);
        Islemler instance = new();
        Console.WriteLine(instance.Expo(3, 4));

        // Extension Metotlar
        string ifade = "Vahdet Savcı";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);
        if (sonuc)
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());

        int[] dizi = {9,3,6,2,1,5,0};
        dizi.SortArray();
        dizi.EkranaYaz();

        int sayi = 5;
        Console.WriteLine(sayi.IsEvenNumber());

        Console.WriteLine(ifade.GetFirstCharacter());
    }
}

class Islemler
{
    internal int Expo(int sayi, int üs)
    {
        if(üs<2)
            return sayi;
        return Expo(sayi, üs-1) * sayi;
    }
    /*
        Expo(3, 4) = 27 * 3 = 81 = 3*3*3*3 = 3^4
        Expo(3, 3) = 9 * 3 = 27
        Expo(3, 2) = 3 * 3 = 9
        Expo(3, 1) = 3
    */
}

static class Extension
{
    internal static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    internal static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);
    }

    internal static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }

    internal static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }

    internal static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    internal static void EkranaYaz(this int[] param)
    {
        foreach (int item in param)
            Console.WriteLine(item);
    }

    internal static bool IsEvenNumber(this int param)
    {
        return param % 2 == 0;
    }

    internal static string GetFirstCharacter(this string param)
    {
        return param.Substring(0, 1);
    }
}
