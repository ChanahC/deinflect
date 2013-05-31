using System;
using System.Collections.Generic;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Input a japstring: ");
            string xinput = Console.ReadLine();
            List<string> chan = masu(xinput);
            foreach(string holderz in chan){
                Console.WriteLine(holderz);
            }
        }
        
        public static List<string> lister(){
            List<string> mlist = new List<string>();
            mlist.Add("わない");
            mlist.Add("らない");
            mlist.Add("たない");
            mlist.Add("ぱない");
            mlist.Add("さない");
            mlist.Add("だない");
            mlist.Add("がない");
            mlist.Add("はない");
            mlist.Add("かない");
            mlist.Add("ざない");
            mlist.Add("ばない");
            mlist.Add("なない");
            mlist.Add("まない");
            mlist.Add("ない");
            return mlist;
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
            ret.Add('ざ', 'ず');
            ret.Add('ば', 'ぶ');
            ret.Add('な', 'ぬ');
            ret.Add('ま', 'む');
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
        
        //Use Contains() to avoid duplication.
        public static List<string> masu(string a){
            List<string> masuL = lister();
            List<string> ret = new List<string>();
            if(a.EndsWith("くない")){
                ret.Add(chopper1(a, "くない") + "い");
                return ret;
            }
            foreach(string b in masuL){
                if(a.EndsWith(b)){
                    string temp1 = chopper1(a, "ない");
                    temp1 = temp1 + "る";
                    if(!ret.Contains(temp1)){
                        ret.Add(temp1);
                    }
                    if(!b.Equals("ない")){
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
            }
            return ret;
        }
    }
}