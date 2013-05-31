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
            retlist.Add("えば");
            retlist.Add("れば");
            retlist.Add("てば");
            retlist.Add("ぺば");
            retlist.Add("せば");
            retlist.Add("でば");
            retlist.Add("げば");
            retlist.Add("へば");
            retlist.Add("けば");
            retlist.Add("ぜば");
            retlist.Add("べば");
            retlist.Add("ねば");
            retlist.Add("めば");
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
            ret.Add('え', 'う');
            ret.Add('れ', 'る');
            ret.Add('て', 'つ');
            ret.Add('ぺ', 'ぷ');
            ret.Add('せ', 'す');
            ret.Add('で', 'づ');
            ret.Add('げ', 'ぐ');
            ret.Add('へ', 'ふ');
            ret.Add('け', 'く');
            ret.Add('べ', 'ぶ');
            ret.Add('ね', 'ぬ');
            ret.Add('ざ', 'ず');
            ret.Add('め', 'む');
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
            if(a.EndsWith("ければ")){
                ret.Add(chopper1(a, "ければ") + "い");
                return ret;
            }
            foreach(string b in listx){
                if(a.EndsWith(b)){
                    string temp2 = chopper2(a, b);
                    if(!ret.Contains(temp2)){
                        ret.Add(temp2);
                    }
                    if(temp2.EndsWith("す")){
                        string temp3 = temp2 + "る";
                        if(!ret.Contains(temp3)){
                            ret.Add(temp3);
                        }
                    }
                }
            }
            return ret;
        }
        
        
        
    }
}