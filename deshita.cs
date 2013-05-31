using System;
using System.Collections.Generic;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");
            List<string> m = deshita("ありませんでした");
            foreach(string x in m){
                Console.WriteLine(x);
            }
        }
        public static string chopper1(string meat, string knife){
            int marker = meat.Length - knife.Length;
            string ret = "";
            for(int cnt = 0; cnt < marker; cnt++){
                ret = ret + meat[cnt];
            }
            return ret;
        }
        //Equals(), EndsWith()
        public static List<string> deshita(string a){
                List<string> d = new List<string>();
                if(a.EndsWith("でした")){
                    if(a.Equals("でした")){
                        d.Add("です");
                    }
                    else{
                        string zzz = chopper1(a, "でした");
                        d.Add(zzz);
                    }
                }
                return d;
        }
    }
}