using System;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Input a japstring");
            string input = Console.ReadLine();
            Console.WriteLine(katta(input));
        }
        
        public static string chopper1(string meat, string knife){
            int marker = meat.Length - knife.Length;
            string ret = "";
            for(int cnt = 0; cnt < marker; cnt++){
                ret = ret + meat[cnt];
            }
            return ret;
        }
        
        private static string katta(string input){
            if(input.EndsWith("かった")){
                return chopper1(input, "かった") + "い";
            }
            return "";
        }
    }
}