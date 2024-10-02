
using System.Collections.Generic;
string ans;
Console.WriteLine("Indtast på en linje en motivationsfaktor");
ans = Console.ReadLine();

if(CheckList(ans))
{
    Console.WriteLine("Faktor er i liste");
}
else
{
    Console.WriteLine("Faktor er ikke i liste");
}
static bool CheckList(string faktor)
{
    bool s;
    List<string> list = new List<string>() { "løn", "anerkendelse", "mål", "autonomi", "udvikling" };
    foreach (string f in list)
    {
        if (faktor.ToLower() == f)
        {
            return s = true;
        }
    }
    return s=false;
}

    
