using Codewars;
using System;
using System.Linq;
using System.Net;


internal class Program
{
    static void Main(string[] args)
    {
        /*(int, int)[] intervals = { (-471413978, -463571688), (-678963390, -677909033), (462445097, 465434127), (-594863864, -588805391),
        (418193319, 427427489), (956756581, 962015432), (-20180177, -16927051), (-15170384, -12012128), (-211539181, -202326373),
        (-440249575, -433008148), (450184908, 453139387), (95204587, 96767679), (-738853493, -737617075), (637177320, 644319559), 
        (-977191394, -967328519), (-746826779, -738233367), (141519170, 147435261), (317970366, 326163482), (937830416, 943238433),
        (-183578913, -179188388), (-325123195, -317494491), (-985378249, -978222209), (-514757283, -508926468), (-1088566, 4341794), (185457790, 188594441) };

        Console.WriteLine(SumOfInterv.SumInt(intervals));*/

        /*uint s = 2149583361;
        var ip = new IPAddress(s);*/
        string str = "";

        //bool res = SimpleF.HappyG(str);

        
        bool result = false;
        int res = 0;
        int r = str.Length;

        for(int i = 0; i < str.Length; i++) 
        {
            if(str[i] == 'g') 
            {
                res++;
            }
            if (str[i] != 'g' &&  res > 1)
            {
                str = str.Remove(i - res , res);
                i = i - res;
                res = 0;
            }
            if (str[i] != 'g')
                res = 0;
            if(i == str.Length - 1 && res > 1)
                str = str.Remove(i - res + 1, res);

        }
        
        if ((str.IndexOf("g")!= -1))
            result = false;
        else
            result = true;

        Console.WriteLine(str.IndexOf("g"));

        if (result == true)
            Console.WriteLine("yes");
        else if(result == false)
            Console.WriteLine("no");

        /*Console.WriteLine(ip);*/
        Console.ReadLine();


    }
}