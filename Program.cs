internal class Program
{
    private static void Main(string[] args)
    {
        string degisken="Dersimiz C#";
        string degisken2="dersimiz C#";
        //Length
        Console.WriteLine(degisken.Length);
        //ToUpper, ToLower
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());
        //Concatenation
        Console.WriteLine(String.Concat(degisken, " ,merhaba"));
        //Compare, CompareTo
        Console.WriteLine(degisken.CompareTo("degisken2")); //0,1,-1
        Console.WriteLine(String.Compare(degisken,degisken2,true));
        Console.WriteLine(String.Compare(degisken,degisken2,false));
        //Contains
        Console.WriteLine(degisken.Contains(degisken2));
        //EndsWith
        Console.WriteLine(degisken.EndsWith("C#"));
        //StartsWith
        Console.WriteLine(degisken.StartsWith("Dersimiz"));
        //IndexOf
        Console.WriteLine(degisken.IndexOf("C#"));
        //Insert
        Console.WriteLine(degisken.Insert(0,"Merhaba"));
        //LastIndexOf
        Console.WriteLine(degisken.LastIndexOf("i"));
        //PadLeft, PadRight
        Console.WriteLine(degisken + degisken2.PadLeft(30,'!'));
        Console.WriteLine(degisken.PadRight(30,'*') + degisken2);
        //Remove
        Console.WriteLine(degisken.Remove(5));
        Console.WriteLine(degisken.Remove(5,3));
        Console.WriteLine(degisken.Remove(0,1));
        //Replace
        Console.WriteLine(degisken.Replace("C#","CSharp"));
        //Split
        Console.WriteLine(degisken.Split(" ")[1]);
        //Substring
        Console.WriteLine(degisken.Substring(4));
        Console.WriteLine(degisken.Substring(4,6));
    }
}