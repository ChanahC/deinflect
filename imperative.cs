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
            ret.Add("え");
            ret.Add("ろ");
            ret.Add("て");
            ret.Add("れ");
            ret.Add("ぺ");
            ret.Add("せ");
            ret.Add("で");
            ret.Add("げ");
            ret.Add("へ");
            ret.Add("け");
            ret.Add("ぜ");
            ret.Add("べ");
            ret.Add("ね");
            ret.Add("め");
            return ret;
        }
        private static Dictionary<char, char> dicter(){
            Dictionary<char, char> ret = new Dictionary<char, char>();
            ret.Add('え', 'う');
            ret.Add('ろ', 'る');
            ret.Add('れ', 'る');
            ret.Add('て', 'つ');
            ret.Add('ぺ', 'ぷ');
            ret.Add('せ', 'す');
            ret.Add('で', 'づ');
            ret.Add('げ', 'ぐ');
            ret.Add('へ', 'ふ');
            ret.Add('け', 'く');
            ret.Add('ぜ', 'ず');
            ret.Add('べ', 'ぶ');
            ret.Add('ね', 'ぬ');
            ret.Add('め', 'む');
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
            if(a.EndsWith("しろ")){
                ret.Add(chopper1(a, "しろ") + "する");
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