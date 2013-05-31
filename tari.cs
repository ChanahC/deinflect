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
            ret.Add("ぶ", "んだり");
            ret.Add("む", "んだり");
            ret.Add("ぬ", "んだり");
            ret.Add("ぐ", "いだり");
            ret.Add("つ", "ったり");
            ret.Add("る", "ったり");
            ret.Add("う", "ったり");
            ret.Add("す", "したり");
            ret.Add("く", "いたり");
            return ret;
        }
        
        private static List<string> lister(){
            List<string> telist = new List<string>();
            telist.Add("だり");
            telist.Add("んだり");
            telist.Add("いだり");
            telist.Add("ったり");
            telist.Add("したり");
            telist.Add("いたり");
            telist.Add("たり");
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
            if(comp.Equals("たり")){
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
                    if(b.Equals("たり")){
                        listy.Add(chopper1(a, "たり") + "る");
                    }
                    else{
                        List<string> listz = chopper3(a, b);
                        if(b.Equals("したり")){
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