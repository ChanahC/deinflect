using System;
using System.Collections.Generic;

namespace QuickSharp
{
    public class Program
    {
        private static List<string> mainL;
        private static Dictionary<char, char> dict;
        private static void Main()
        {
            mainL = lister();
            dict = dicter();
            Console.WriteLine("Input a japstring:");
            string a = Console.ReadLine();
            List<string> answer = imperative(a);
            Console.WriteLine("Answers:");
            foreach(string output in answer){
                Console.WriteLine(output);
            }
        }
        private static List<string> lister(){
            List<string> ret = new List<string>();
            ret.Add("おう");
            ret.Add("ろう");
            ret.Add("とう");
            ret.Add("よう");
            ret.Add("ぽう");
            ret.Add("そう");
            ret.Add("どう");
            ret.Add("ごう");
            ret.Add("ほう");
            ret.Add("こう");
            ret.Add("ぞう");
            ret.Add("ぼう");
            ret.Add("のう");
            ret.Add("もう");
            return ret;
        }
        private static Dictionary<char, char> dicter(){
            Dictionary<char, char> ret = new Dictionary<char, char>();
            ret.Add('お', 'う');
            ret.Add('ろ', 'る');
            ret.Add('と', 'つ');
            ret.Add('よ', 'る');
            ret.Add('ぽ', 'ぷ');
            ret.Add('そ', 'す');
            ret.Add('ど', 'づ');
            ret.Add('ご', 'ぐ');
            ret.Add('ほ', 'ふ');
            ret.Add('こ', 'く');
            ret.Add('ぞ', 'ず');
            ret.Add('ぼ', 'ぶ');
            ret.Add('の', 'ぬ');
            ret.Add('も', 'む');
            return ret;
        }
        public static string chopper2(string meat, string knife){
            int marker = meat.Length - knife.Length;
            string ret = "";
            for(int cnt = 0; cnt < (marker + 1); cnt++){
                if(cnt == marker){
                    ret = ret + dict[meat[cnt]];
                }
                else{
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public static string chopper1(string meat, string knife){
            int marker = meat.Length - knife.Length;
            string ret = "";
            for(int cnt = 0; cnt < marker; cnt++){
                ret = ret + meat[cnt];
            }
            return ret;
        }
        private static List<string> imperative(string a){
            List<string> ret = new List<string>();
            if(a.EndsWith("しよう")){
                ret.Add(chopper1(a, "しよう") + "する");
                return ret;
            }
            foreach(string b in mainL){
                if(a.EndsWith(b)){
                    ret.Add(chopper2(a, b));
                }
            }
            return ret;
        }
    }
}