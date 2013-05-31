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
            ret.Add("ぶ", "んで");
            ret.Add("む", "んで");
            ret.Add("ぬ", "んで");
            ret.Add("ぐ", "いで");
            ret.Add("つ", "って");
            ret.Add("る", "って");
            ret.Add("う", "って");
            ret.Add("す", "して");
            ret.Add("く", "いて");
            return ret;
        }
        
        private static List<string> lister(){
            List<string> telist = new List<string>();
            telist.Add("て");
            telist.Add("んで");
            telist.Add("いで");
            telist.Add("って");
            telist.Add("して");
            telist.Add("いて");
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
            if(comp.Equals("て")){
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
            if(a.EndsWith("くて")){
                listy.Add(chopper1(a, "くて") + "い");
                return listy;
            }
            else if(a.EndsWith("ないで")){
                listy.Add(chopper1(a, "で"));
                return listy;
            }
            foreach(string b in listx){
                if(a.EndsWith(b)){
                    if(b.Equals("て")){
                        listy.Add(chopper1(a, "て") + "る");
                    }
                    else{
                        List<string> listz = chopper3(a, b);
                        if(b.Equals("して")){
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