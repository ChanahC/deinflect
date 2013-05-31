using System;
using System.Collections.Generic;

namespace QuickSharp
{
    public class Program
    {
        public static List<string> listx;
        private static void Main()
        {
            listx = lister();
            Console.WriteLine("Input a japstring: ");
            string xinput = Console.ReadLine();
            Console.WriteLine("Answers:");
            List<string> chan = masu(xinput);
            foreach(string holderz in chan){
                Console.WriteLine(holderz);
            }
        }
        public static List<string> lister(){
            List<string> retlist = new List<string>();
            retlist.Add("わず");
            retlist.Add("らず");
            retlist.Add("たず");
            retlist.Add("ぱず");
            retlist.Add("さず");
            retlist.Add("だず");
            retlist.Add("がず");
            retlist.Add("はず");
            retlist.Add("かず");
            retlist.Add("ざず");
            retlist.Add("ばず");
            retlist.Add("なず");
            retlist.Add("まず");
            retlist.Add("ず");
            return retlist;
        }
        
        public static string chopper1(string meat, string knife){
            int marker = meat.Length - knife.Length;
            string ret = "";
            for(int cnt = 0; cnt < marker; cnt++){
                ret = ret + meat[cnt];
            }
            return ret;
        }
        
        public static Dictionary<char, char> imasu(){
            Dictionary<char, char> ret = new Dictionary<char, char>();
            ret.Add('わ', 'う');
            ret.Add('ら', 'る');
            ret.Add('た', 'つ');
            ret.Add('ぱ', 'ぷ');
            ret.Add('さ', 'す');
            ret.Add('だ', 'づ');
            ret.Add('が', 'ぐ');
            ret.Add('は', 'ふ');
            ret.Add('か', 'く');
            ret.Add('ば', 'ぶ');
            ret.Add('な', 'ぬ');
            ret.Add('ま', 'む');
            ret.Add('ぜ', 'ず');
            return ret;
        }
        
        public static string chopper2(string meat, string knife){
            Dictionary<char, char> imas = imasu();
            int marker = meat.Length - knife.Length;
            string ret = "";
            for(int cnt = 0; cnt < (marker + 1); cnt++){
                if(cnt == marker){
                    ret = ret + imas[meat[cnt]];
                }
                else{
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        
        public static List<string> masu(string a){
            List<string> ret = new List<string>();
            if(a.EndsWith("せず")){
                ret.Add(chopper1(a, "せず") + "する");
                return ret;
            }
            foreach(string b in listx){
                if(a.EndsWith(b)){
                    ret.Add(chopper1(a, b) + "る");
                    if(!b.Equals("ず")){
                        string temp2 = chopper2(a, b);
                        if(!ret.Contains(temp2)){
                            ret.Add(temp2);
                        }
                    }
                }
            }
            return ret;
        }
        
        
        
    }
}