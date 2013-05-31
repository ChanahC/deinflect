using System;
using System.Collections.Generic;

namespace QuickSharp
{
    public class Program
    {
        public static Dictionary<string, string> dict;
        public static List<string> listx;
        private static void Main()
        {
            Console.WriteLine("Hello World!");
            dict = assigner();
            listx = lister();
            Console.WriteLine("Enter a japstring");
            string input = Console.ReadLine();
            List<string> answer = teformx(input);
            Console.WriteLine("Answers: ");
            foreach(string s in answer){
                Console.WriteLine(s);
            }
        }
        
        private static Dictionary<string, string> assigner(){
            Dictionary<string, string> ret = new Dictionary<string, string>();
            ret.Add("ぶ", "んだ");
            ret.Add("む", "んだ");
            ret.Add("ぬ", "んだ");
            ret.Add("ぐ", "いだ");
            ret.Add("つ", "った");
            ret.Add("る", "った");
            ret.Add("う", "った");
            ret.Add("す", "した");
            ret.Add("く", "いた");
            return ret;
        }
        
        private static List<string> lister(){
            List<string> telist = new List<string>();
            telist.Add("だ");
            telist.Add("んだ");
            telist.Add("いだ");
            telist.Add("った");
            telist.Add("した");
            telist.Add("いた");
            telist.Add("た");
            return telist;
        }
        
        private static List<string> chopper3(string input, string offset){
            List<string> listy = new List<string>();
            int marker = input.Length - offset.Length;
            int cnt = 0;
            string ret = "";
            for(cnt = 0; cnt < marker; cnt++){
                ret += input[cnt];
            }
            string comp = "";
            while(cnt < input.Length){
                comp += input[cnt];
                cnt++;
            }
            if(comp.Equals("た")){
                listy.Add(ret + "る");
            }
            else{
                ICollection<string> cole = dict.Keys;
                foreach(string xxx in cole){
                    if(dict[xxx].Equals(comp)){
                        listy.Add(ret + xxx);
                    }
                }
            }
            return listy;
        }
        
        public static string chopper1(string meat, string knife){
            int marker = meat.Length - knife.Length;
            string ret = "";
            for(int cnt = 0; cnt < marker; cnt++){
                ret = ret + meat[cnt];
            }
            return ret;
        }
        
        private static List<string> teformx(string a){
            List<string> listy = new List<string>();
            foreach(string b in listx){
                if(a.EndsWith(b)){
                    if(b.Equals("た")){
                        listy.Add(chopper1(a, "た") + "る");
                    }
                    else{
                        List<string> listz = chopper3(a, b);
                        if(b.Equals("した")){
                            listy.Add(chopper1(a, b) + "する");
                        }
                        foreach(string yyy in listz){
                            listy.Add(yyy);
                        }
                    }
                }
            }
            return listy;
        }
        
    }
}