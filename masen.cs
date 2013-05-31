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
            mlist.Add("いません");
            mlist.Add("しません");
            mlist.Add("りません");
            mlist.Add("ぴません");
            mlist.Add("ぎません");
            mlist.Add("みません");
            mlist.Add("きません");
            mlist.Add("びません");
            mlist.Add("にません");
            mlist.Add("みません");
            mlist.Add("ちません");
            mlist.Add("ません");
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
            ret.Add('い', 'う');
            ret.Add('り', 'る');
            ret.Add('ち', 'つ');
            ret.Add('ぴ', 'ぷ');
            ret.Add('し', 'す');
            ret.Add('ぢ', 'づ');
            ret.Add('ぎ', 'ぐ');
            ret.Add('ひ', 'ふ');
            ret.Add('き', 'く');
            ret.Add('じ', 'ず');
            ret.Add('び', 'ぶ');
            ret.Add('に', 'ぬ');
            ret.Add('み', 'む');
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
            foreach(string b in masuL){
                if(a.EndsWith(b)){
                    if(a.Equals(b)){
                        string temp1 = chopper1(a, "ません");
                        temp1 = temp1 + "る";
                        if(!ret.Contains(temp1)){
                            ret.Add(temp1);
                        }
                    }
                    else{
                        string temp1 = chopper1(a, "ません");
                        temp1 = temp1 + "る";
                        if(!ret.Contains(temp1)){
                            ret.Add(temp1);
                        }
                        if(!b.Equals("ません")){
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
            }
            return ret;
        }
    }
}