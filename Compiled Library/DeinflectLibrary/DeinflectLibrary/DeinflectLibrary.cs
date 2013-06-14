using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeinflectLibrary
{
    public class tari {
        public List<string> list;
        public Dictionary<string, string> dict;
        public tari() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister() {
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
        public Dictionary<string, string> dicter() {
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
        private List<string> chopper3(string input, string offset)
        {
            List<string> listy = new List<string>();
            int marker = input.Length - offset.Length;
            int cnt = 0;
            string ret = "";
            for (cnt = 0; cnt < marker; cnt++)
            {
                ret += input[cnt];
            }
            string comp = "";
            while (cnt < input.Length)
            {
                comp += input[cnt];
                cnt++;
            }
            if (comp.Equals("たり"))
            {
                listy.Add(ret + "る");
            }
            else
            {
                ICollection<string> cole = dict.Keys;
                foreach (string xxx in cole)
                {
                    if (dict[xxx].Equals(comp))
                    {
                        listy.Add(ret + xxx);
                    }
                }
            }
            return listy;
        }

        public string chopper1(string meat, string knife){
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public List<string> inflect(string input) { 
            List<string> listy = new List<string>();
            foreach(string b in list){
                if(input.EndsWith(b)){
                    if(b.Equals("たり")){
                        listy.Add(chopper1(input, "たり") + "る");
                    }
                    else{
                        List<string> listz = chopper3(input, b);
                        if(b.Equals("したり")){
                            listy.Add(chopper1(input, b) + "する");
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

    public class tara {
        public List<string> list;
        public Dictionary<string, string> dict;
        public tara() {
            dict = dicter();
            list = lister();
        }

        public List<string> lister() {
            List<string> telist = new List<string>();
            telist.Add("だら");
            telist.Add("んだら");
            telist.Add("いだら");
            telist.Add("ったら");
            telist.Add("したら");
            telist.Add("いたら");
            telist.Add("たら");
            return telist;
        }

        public Dictionary<string, string> dicter() {
            Dictionary<string, string> ret = new Dictionary<string, string>();
            ret.Add("ぶ", "んだら");
            ret.Add("む", "んだら");
            ret.Add("ぬ", "んだら");
            ret.Add("ぐ", "いだら");
            ret.Add("つ", "ったら");
            ret.Add("る", "ったら");
            ret.Add("う", "ったら");
            ret.Add("す", "したら");
            ret.Add("く", "いたら");
            return ret;
        }
        private List<string> chopper3(string input, string offset)
        {
            List<string> listy = new List<string>();
            int marker = input.Length - offset.Length;
            int cnt = 0;
            string ret = "";
            for (cnt = 0; cnt < marker; cnt++)
            {
                ret += input[cnt];
            }
            string comp = "";
            while (cnt < input.Length)
            {
                comp += input[cnt];
                cnt++;
            }
            if (comp.Equals("たら"))
            {
                listy.Add(ret + "る");
            }
            else
            {
                ICollection<string> cole = dict.Keys;
                foreach (string xxx in cole)
                {
                    if (dict[xxx].Equals(comp))
                    {
                        listy.Add(ret + xxx);
                    }
                }
            }
            return listy;
        }
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public List<string> inflect(string a) {
            List<string> listy = new List<string>();
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    if (b.Equals("たら"))
                    {
                        listy.Add(chopper1(a, "たら") + "る");
                    }
                    else
                    {
                        List<string> listz = chopper3(a, b);
                        if (b.Equals("したら"))
                        {
                            listy.Add(chopper1(a, b) + "する");
                        }
                        foreach (string yyy in listz)
                        {
                            listy.Add(yyy);
                        }
                    }
                }
            }
            return listy;
        }
    }

    public class te {
        public List<string> list;
        public Dictionary<string, string> dict;
        public te() {
            list = lister();
            dict = dicter();
        }
        public Dictionary<string, string> dicter() {
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
        public List<string> lister()
        {
            List<string> telist = new List<string>();
            telist.Add("て");
            telist.Add("んで");
            telist.Add("いで");
            telist.Add("って");
            telist.Add("して");
            telist.Add("いて");
            return telist;
        }
        public List<string> chopper3(string input, string offset)
        {
            List<string> listy = new List<string>();
            int marker = input.Length - offset.Length;
            int cnt = 0;
            string ret = "";
            for (cnt = 0; cnt < marker; cnt++)
            {
                ret += input[cnt];
            }
            string comp = "";
            while (cnt < input.Length)
            {
                comp += input[cnt];
                cnt++;
            }
            if (comp.Equals("て"))
            {
                listy.Add(ret + "る");
            }
            else
            {
                ICollection<string> cole = dict.Keys;
                foreach (string xxx in cole)
                {
                    if (dict[xxx].Equals(comp))
                    {
                        listy.Add(ret + xxx);
                    }
                }
            }
            return listy;
        }
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public List<string> inflect(string a)
        {
            List<string> listy = new List<string>();
            if (a.EndsWith("くて"))
            {
                listy.Add(chopper1(a, "くて") + "い");
                return listy;
            }
            else if (a.EndsWith("ないで"))
            {
                listy.Add(chopper1(a, "で"));
                return listy;
            }
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    if (b.Equals("て"))
                    {
                        listy.Add(chopper1(a, "て") + "る");
                    }
                    else
                    {
                        List<string> listz = chopper3(a, b);
                        if (b.Equals("して"))
                        {
                            listy.Add(chopper1(a, b) + "する");
                        }
                        foreach (string yyy in listz)
                        {
                            listy.Add(yyy);
                        }
                    }
                }
            }
            return listy;
        }
    }

    public class zu {
        public List<string> list;
        public Dictionary<char, char> dict;
        public zu() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister() {
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
        public Dictionary<char, char> dicter() {
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> inflect(string a)
        {
            List<string> ret = new List<string>();
            if (a.EndsWith("せず"))
            {
                ret.Add(chopper1(a, "せず") + "する");
                return ret;
            }
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    ret.Add(chopper1(a, b) + "る");
                    if (!b.Equals("ず"))
                    {
                        string temp2 = chopper2(a, b);
                        if (!ret.Contains(temp2))
                        {
                            ret.Add(temp2);
                        }
                    }
                }
            }
            return ret;
        }
    }

    public class ba
    {
        public List<string> list;
        public Dictionary<char, char> dict;
        public ba() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister() {
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
        public Dictionary<char, char> dicter() { 
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> inflect(string a) {
            List<string> ret = new List<string>();
            if (a.EndsWith("ければ"))
            {
                ret.Add(chopper1(a, "ければ") + "い");
                return ret;
            }
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    string temp2 = chopper2(a, b);
                    if (!ret.Contains(temp2))
                    {
                        ret.Add(temp2);
                    }
                    if (temp2.EndsWith("す"))
                    {
                        string temp3 = temp2 + "る";
                        if (!ret.Contains(temp3))
                        {
                            ret.Add(temp3);
                        }
                    }
                }
            }
            return ret;
        }
    }

    public class nasai {
        public List<string> list;
        public Dictionary<char, char> dict;
        public nasai() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister() {
            List<string> mlist = new List<string>();
            mlist.Add("いなさい");
            mlist.Add("しなさい");
            mlist.Add("りなさい");
            mlist.Add("ぴなさい");
            mlist.Add("ぎなさい");
            mlist.Add("みなさい");
            mlist.Add("きなさい");
            mlist.Add("びなさい");
            mlist.Add("になさい");
            mlist.Add("みなさい");
            mlist.Add("ちなさい");
            mlist.Add("なさい");
            return mlist;
        }
        public Dictionary<char, char> dicter() {
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> inflect(string a)
        {
            List<string> ret = new List<string>();
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    if (a.Equals(b))
                    {
                        string temp1 = chopper1(a, "なさい");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                    }
                    else
                    {
                        string temp1 = chopper1(a, "なさい");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                        if (!b.Equals("なさい"))
                        {
                            string temp2 = chopper2(a, b);
                            if (!ret.Contains(temp2))
                            {
                                ret.Add(temp2);
                            }
                            if (temp2.EndsWith("す"))
                            {
                                string temp3 = temp2 + "る";
                                if (!ret.Contains(temp3))
                                {
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

    public class sou {
        public List<string> list;
        public Dictionary<char, char> dict;
        public sou() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister() {
            List<string> mlist = new List<string>();
            mlist.Add("いそう");
            mlist.Add("しそう");
            mlist.Add("りそう");
            mlist.Add("ぴそう");
            mlist.Add("ぎそう");
            mlist.Add("みそう");
            mlist.Add("きそう");
            mlist.Add("びそう");
            mlist.Add("にそう");
            mlist.Add("みそう");
            mlist.Add("ちそう");
            mlist.Add("そう");
            return mlist;
        }
        public Dictionary<char, char> dicter(){
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> inflect(string a) {
            List<string> ret = new List<string>();
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    if (a.Equals(b))
                    {
                        string temp1 = chopper1(a, "そう");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                    }
                    else
                    {
                        string temp1 = chopper1(a, "そう");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                        if (!b.Equals("そう"))
                        {
                            string temp2 = chopper2(a, b);
                            if (!ret.Contains(temp2))
                            {
                                ret.Add(temp2);
                            }
                            if (temp2.EndsWith("す"))
                            {
                                string temp3 = temp2 + "る";
                                if (!ret.Contains(temp3))
                                {
                                    ret.Add(temp3);
                                }
                            }
                        }
                        else if (b.Equals("そう"))
                        {
                            ret.Add(chopper1(a, b) + "い");
                        }
                    }
                }
            }
            return ret;
        }
    }

    public class tai {
        public List<string> list;
        public Dictionary<char, char> dict;
        public tai() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister() {
            List<string> mlist = new List<string>();
            mlist.Add("いたい");
            mlist.Add("したい");
            mlist.Add("りたい");
            mlist.Add("ぴたい");
            mlist.Add("ぎたい");
            mlist.Add("みたい");
            mlist.Add("きたい");
            mlist.Add("びたい");
            mlist.Add("にたい");
            mlist.Add("みたい");
            mlist.Add("ちたい");
            mlist.Add("たい");
            return mlist;
        }
        public Dictionary<char, char> dicter() {
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> inflect(string a) {
            List<string> ret = new List<string>();
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    if (a.Equals(b))
                    {
                        string temp1 = chopper1(a, "たい");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                    }
                    else
                    {
                        string temp1 = chopper1(a, "たい");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                        if (!b.Equals("たい"))
                        {
                            string temp2 = chopper2(a, b);
                            if (!ret.Contains(temp2))
                            {
                                ret.Add(temp2);
                            }
                            if (temp2.EndsWith("す"))
                            {
                                string temp3 = temp2 + "る";
                                if (!ret.Contains(temp3))
                                {
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

    public class sugiru {
        public List<string> list;
        public Dictionary<char, char> dict;
        public sugiru() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister(){
            List<string> mlist = new List<string>();
            mlist.Add("いすぎる");
            mlist.Add("しすぎる");
            mlist.Add("りすぎる");
            mlist.Add("ぴすぎる");
            mlist.Add("ぎすぎる");
            mlist.Add("みすぎる");
            mlist.Add("きすぎる");
            mlist.Add("びすぎる");
            mlist.Add("にすぎる");
            mlist.Add("みすぎる");
            mlist.Add("ちすぎる");
            mlist.Add("すぎる");
            return mlist;
        }
        public Dictionary<char, char> dicter() {
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> inflect(string a) {
            List<string> ret = new List<string>();
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    if (a.Equals(b))
                    {
                        string temp1 = chopper1(a, "すぎる");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                    }
                    else
                    {
                        string temp1 = chopper1(a, "すぎる");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                        if (!b.Equals("すぎる"))
                        {
                            string temp2 = chopper2(a, b);
                            if (!ret.Contains(temp2))
                            {
                                ret.Add(temp2);
                            }
                            if (temp2.EndsWith("す"))
                            {
                                string temp3 = temp2 + "る";
                                if (!ret.Contains(temp3))
                                {
                                    ret.Add(temp3);
                                }
                            }
                        }
                        else if (b.Equals("すぎる"))
                        {
                            ret.Add(chopper1(a, b) + "い");
                        }
                    }
                }
            }
            return ret;
        }

    }

    public class volitional {
        public List<string> list;
        public Dictionary<char, char> dict;
        public volitional() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister() {
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
        public Dictionary<char, char> dicter() {
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> inflect(string a) {
            List<string> ret = new List<string>();
            if (a.EndsWith("しよう"))
            {
                ret.Add(chopper1(a, "しよう") + "する");
                return ret;
            }
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    ret.Add(chopper2(a, b));
                }
            }
            return ret;
        }
    }

    public class mashou {
        public List<string> list;
        public Dictionary<char, char> dict;
        public mashou() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister() {
            List<string> mlist = new List<string>();
            mlist.Add("いましょう");
            mlist.Add("しましょう");
            mlist.Add("りましょう");
            mlist.Add("ぴましょう");
            mlist.Add("ぎましょう");
            mlist.Add("みましょう");
            mlist.Add("きましょう");
            mlist.Add("びましょう");
            mlist.Add("にましょう");
            mlist.Add("みましょう");
            mlist.Add("ちましょう");
            mlist.Add("ましょう");
            return mlist;
        }
        public Dictionary<char, char> dicter() {
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> inflect(string a) {
            List<string> ret = new List<string>();
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    if (a.Equals(b))
                    {
                        string temp1 = chopper1(a, "ましょう");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                    }
                    else
                    {
                        string temp1 = chopper1(a, "ましょう");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                        if (!b.Equals("ましょう"))
                        {
                            string temp2 = chopper2(a, b);
                            if (!ret.Contains(temp2))
                            {
                                ret.Add(temp2);
                            }
                            if (temp2.EndsWith("す"))
                            {
                                string temp3 = temp2 + "る";
                                if (!ret.Contains(temp3))
                                {
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

    public class imperative {
        public List<string> list;
        public Dictionary<char, char> dict;
        public imperative() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister() {
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
        public Dictionary<char, char> dicter() {
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> inflect(string a) {
            List<string> ret = new List<string>();
            if (a.EndsWith("しろ"))
            {
                ret.Add(chopper1(a, "しろ") + "する");
                return ret;
            }
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    ret.Add(chopper2(a, b));
                }
            }
            return ret;
        }
    }

    public class masen {
        public List<string> list;
        public Dictionary<char, char> dict;
        public masen() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister() {
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
        public Dictionary<char, char> dicter() {
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> inflect(string a) {
            List<string> ret = new List<string>();
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    if (a.Equals(b))
                    {
                        string temp1 = chopper1(a, "ません");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                    }
                    else
                    {
                        string temp1 = chopper1(a, "ません");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                        if (!b.Equals("ません"))
                        {
                            string temp2 = chopper2(a, b);
                            if (!ret.Contains(temp2))
                            {
                                ret.Add(temp2);
                            }
                            if (temp2.EndsWith("す"))
                            {
                                string temp3 = temp2 + "る";
                                if (!ret.Contains(temp3))
                                {
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

    public class ta {
        public List<string> list;
        public Dictionary<string, string> dict;
        public ta() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister() {
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
        public Dictionary<string, string> dicter() {
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public List<string> chopper3(string input, string offset)
        {
            List<string> listy = new List<string>();
            int marker = input.Length - offset.Length;
            int cnt = 0;
            string ret = "";
            for (cnt = 0; cnt < marker; cnt++)
            {
                ret += input[cnt];
            }
            string comp = "";
            while (cnt < input.Length)
            {
                comp += input[cnt];
                cnt++;
            }
            if (comp.Equals("た"))
            {
                listy.Add(ret + "る");
            }
            else
            {
                ICollection<string> cole = dict.Keys;
                foreach (string xxx in cole)
                {
                    if (dict[xxx].Equals(comp))
                    {
                        listy.Add(ret + xxx);
                    }
                }
            }
            return listy;
        }
        public List<string> inflect(string a) {
            List<string> listy = new List<string>();
            if (a.EndsWith("ました")) {
                string tempx = chopper1(a, "ました") + "ます";
                listy.Add(tempx);
                return listy;
            }
            else if (a.EndsWith("かった"))
            {
                string tempx = chopper1(a, "かった") + "い";
                listy.Add(tempx);
                return listy;
            }
            else if (a.EndsWith("でした"))
            {
                string tempx = chopper1(a, "でした") + "です";
                listy.Add(tempx);
                return listy;
            }
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    if (b.Equals("た"))
                    {
                        listy.Add(chopper1(a, "た") + "る");
                    }
                    else
                    {
                        List<string> listz = chopper3(a, b);
                        if (b.Equals("した"))
                        {
                            listy.Add(chopper1(a, b) + "する");
                        }
                        foreach (string yyy in listz)
                        {
                            listy.Add(yyy);
                        }
                    }
                }
            }
            return listy;
        }


    }

    public class chau {
        public List<string> list;
        public Dictionary<string, string> dict;
        public chau() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister() {
            List<string> telist = new List<string>();
            telist.Add("んじゃう");
            telist.Add("いじゃう");
            telist.Add("っちゃう");
            telist.Add("しちゃう");
            telist.Add("いちゃう");
            telist.Add("ちゃう");
            return telist;
        }
        public Dictionary<string, string> dicter() {
            Dictionary<string, string> ret = new Dictionary<string, string>();
            ret.Add("ぶ", "んじゃう");
            ret.Add("む", "んじゃう");
            ret.Add("ぬ", "んじゃう");
            ret.Add("ぐ", "いじゃう");
            ret.Add("つ", "っちゃう");
            ret.Add("る", "っちゃう");
            ret.Add("う", "っちゃう");
            ret.Add("す", "しちゃう");
            ret.Add("く", "いちゃう");
            return ret;
        }
        private List<string> chopper3(string input, string offset)
        {
            List<string> listy = new List<string>();
            int marker = input.Length - offset.Length;
            int cnt = 0;
            string ret = "";
            for (cnt = 0; cnt < marker; cnt++)
            {
                ret += input[cnt];
            }
            string comp = "";
            while (cnt < input.Length)
            {
                comp += input[cnt];
                cnt++;
            }
            if (comp.Equals("ちゃう"))
            {
                listy.Add(ret + "る");
            }
            else
            {
                ICollection<string> cole = dict.Keys;
                foreach (string xxx in cole)
                {
                    if (dict[xxx].Equals(comp))
                    {
                        listy.Add(ret + xxx);
                    }
                }
            }
            return listy;
        }
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public List<string> chauInflect(string a) {
            List<string> listy = new List<string>();
            if (a.EndsWith("くちゃう")){
                listy.Add(chopper1(a, "くちゃう") + "い");
                return listy;
            }
            else if (a.EndsWith("ないじゃう")){
                listy.Add(chopper1(a, "じゃう"));
                return listy;
            }
            foreach (string b in list){
                if (a.EndsWith(b)){
                    if (b.Equals("ちゃう")){
                        listy.Add(chopper1(a, "ちゃう") + "る");
                    }
                    else{
                        List<string> listz = chopper3(a, b);
                        if (b.Equals("しちゃう")){
                            listy.Add(chopper1(a, b) + "する");
                        }
                        foreach (string yyy in listz){
                            listy.Add(yyy);
                        }
                    }
                }
            }
            return listy;
        }
        public List<string> lister1() {
            List<string> ret = new List<string>();
            ret.Add("む");
            ret.Add("ぬ");
            ret.Add("ぶ");
            ret.Add("ず");
            ret.Add("く");
            ret.Add("ぐ");
            ret.Add("ふ");
            ret.Add("づ");
            ret.Add("す");
            ret.Add("ぷ");
            ret.Add("う");
            ret.Add("つ");
            ret.Add("る");
            ret.Add("い");
            return ret;
        }
        public bool returnChecker(string input) {
            List<string> xx = lister1();
            foreach (string a in xx) {
                if (input.EndsWith(a)) {
                    if (a.Equals("う")) {
                        List<string> tempL = lister();
                        foreach(string temps in tempL){
                            if(input.EndsWith(temps)){
                                return false;
                            }
                        }
                        if (input.EndsWith("そう")) {
                            return false;
                        }
                    }
                    if (a.Equals("す"))
                    {
                        if (input.EndsWith("ます"))
                        {
                            return false;
                        }
                    }
                    if (a.Equals("い"))
                    {
                        if (input.EndsWith("ない"))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        public List<string> inflect(string input) {
            List<string> ret = new List<string>();
            zu a1 = new zu();
            te a2 = new te();
            ta a3 = new ta();
            tara a4 = new tara();
            tari a5 = new tari();
            List<string> b1 = a1.inflect(input);
            List<string> b2 = a2.inflect(input);
            List<string> b3 = a3.inflect(input);
            List<string> b4 = a4.inflect(input);
            List<string> b5 = a5.inflect(input);
            foreach(string a in b1){
                bool x = returnChecker(a);
                if (x == true)
                {
                    ret.Add(a);
                }
                else {
                    List<string> retx = chauInflect(a);
                    foreach (string z in retx) {
                        if (!ret.Contains(z)) {
                            ret.Add(z);
                        }
                    }
                }
            }
            foreach (string a in b2)
            {
                bool x = returnChecker(a);
                if (x == true)
                {
                    ret.Add(a);
                }
                else
                {
                    List<string> retx = chauInflect(a);
                    foreach (string z in retx)
                    {
                        if (!ret.Contains(z))
                        {
                            ret.Add(z);
                        }
                    }
                }
            }
            foreach (string a in b3)
            {
                bool x = returnChecker(a);
                if (x == true)
                {
                    ret.Add(a);
                }
                else
                {
                    List<string> retx = chauInflect(a);
                    foreach (string z in retx)
                    {
                        if (!ret.Contains(z))
                        {
                            ret.Add(z);
                        }
                    }
                }
            }
            foreach (string a in b4)
            {
                bool x = returnChecker(a);
                if (x == true)
                {
                    ret.Add(a);
                }
                else
                {
                    List<string> retx = chauInflect(a);
                    foreach (string z in retx)
                    {
                        if (!ret.Contains(z))
                        {
                            ret.Add(z);
                        }
                    }
                }
            }
            foreach (string a in b5)
            {
                bool x = returnChecker(a);
                if (x == true)
                {
                    ret.Add(a);
                }
                else
                {
                    List<string> retx = chauInflect(a);
                    foreach (string z in retx)
                    {
                        if (!ret.Contains(z))
                        {
                            ret.Add(z);
                        }
                    }
                }
            }
            List<string> rety = chauInflect(input);
            foreach (string z in rety)
            {
                if (!ret.Contains(z))
                {
                    ret.Add(z);
                }
            }

            return ret;
        }
    }

    public class nai {
        public List<string> list;
        public Dictionary<char, char> dict;
        public nai() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister()
        {
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
        public Dictionary<char, char> dicter()
        {
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> lister1()
        {
            List<string> ret = new List<string>();
            ret.Add("む");
            ret.Add("ぬ");
            ret.Add("ぶ");
            ret.Add("ず");
            ret.Add("く");
            ret.Add("ぐ");
            ret.Add("ふ");
            ret.Add("づ");
            ret.Add("す");
            ret.Add("ぷ");
            ret.Add("う");
            ret.Add("つ");
            ret.Add("る");
            ret.Add("い");
            return ret;
        }
        public bool returnChecker(string input)
        {
            List<string> xx = lister1();
            foreach (string a in xx)
            {
                if (input.EndsWith(a))
                {
                    if (a.Equals("う"))
                    {
                        List<string> tempL = lister();
                        foreach (string temps in tempL)
                        {
                            if (input.EndsWith(temps))
                            {
                                return false;
                            }
                        }
                        if (input.EndsWith("そう"))
                        {
                            return false;
                        }
                    }
                    if (a.Equals("す"))
                    {
                        if (input.EndsWith("ます"))
                        {
                            return false;
                        }
                    }
                    if (a.Equals("い"))
                    {
                        if (input.EndsWith("ない"))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        public List<string> naiInflect(string a) {
            List<string> ret = new List<string>();
            if (a.EndsWith("くない"))
            {
                ret.Add(chopper1(a, "くない") + "い");
                return ret;
            }
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    string temp1 = chopper1(a, "ない");
                    temp1 = temp1 + "る";
                    if (!ret.Contains(temp1))
                    {
                        ret.Add(temp1);
                    }
                    if (!b.Equals("ない"))
                    {
                        string temp2 = chopper2(a, b);
                        if (!ret.Contains(temp2))
                        {
                            ret.Add(temp2);
                        }
                        if (temp2.EndsWith("す"))
                        {
                            string temp3 = temp2 + "る";
                            if (!ret.Contains(temp3))
                            {
                                ret.Add(temp3);
                            }
                        }
                    }
                }
            }
            return ret;
        }
        public List<string> inflect(string input) {
            List<string> ret = new List<string>();
            te a2 = new te();
            List<string> b2 = a2.inflect(input);
            foreach (string a in b2)
            {
                bool x = returnChecker(a);
                if (x == true)
                {
                    ret.Add(a);
                }
                else
                {
                    List<string> retx = naiInflect(a);
                    foreach (string z in retx)
                    {
                        if (!ret.Contains(z))
                        {
                            ret.Add(z);
                        }
                    }
                }
            }
            List<string> rety = naiInflect(input);
            foreach (string z in rety)
            {
                if (!ret.Contains(z))
                {
                    ret.Add(z);
                }
            }

            return ret;
        }
    }

    public class masu {
        public List<string> list;
        public Dictionary<char, char> dict;
        public masu() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister(){
            List<string> mlist = new List<string>();
            mlist.Add("います");
            mlist.Add("します");
            mlist.Add("ります");
            mlist.Add("ぴます");
            mlist.Add("ぎます");
            mlist.Add("みます");
            mlist.Add("きます");
            mlist.Add("びます");
            mlist.Add("にます");
            mlist.Add("みます");
            mlist.Add("ちます");
            mlist.Add("ます");
            return mlist;
        }
        public Dictionary<char, char> dicter(){
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> lister1(){
            List<string> ret = new List<string>();
            ret.Add("む");
            ret.Add("ぬ");
            ret.Add("ぶ");
            ret.Add("ず");
            ret.Add("く");
            ret.Add("ぐ");
            ret.Add("ふ");
            ret.Add("づ");
            ret.Add("す");
            ret.Add("ぷ");
            ret.Add("う");
            ret.Add("つ");
            ret.Add("る");
            ret.Add("い");
            return ret;
        }
        public bool returnChecker(string input)
        {
            List<string> xx = lister1();
            foreach (string a in xx)
            {
                if (input.EndsWith(a))
                {
                    if (a.Equals("う"))
                    {
                        List<string> tempL = lister();
                        foreach (string temps in tempL)
                        {
                            if (input.EndsWith(temps))
                            {
                                return false;
                            }
                        }
                        if (input.EndsWith("そう"))
                        {
                            return false;
                        }
                    }
                    if (a.Equals("す"))
                    {
                        if (input.EndsWith("ます"))
                        {
                            return false;
                        }
                    }
                    if (a.Equals("い"))
                    {
                        if (input.EndsWith("ない"))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        public List<string> masuInflect(string a) {
            List<string> ret = new List<string>();
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    if (a.Equals(b))
                    {
                        string temp1 = chopper1(a, "ます");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                    }
                    else
                    {
                        string temp1 = chopper1(a, "ます");
                        temp1 = temp1 + "る";
                        if (!ret.Contains(temp1))
                        {
                            ret.Add(temp1);
                        }
                        if (!b.Equals("ます"))
                        {
                            string temp2 = chopper2(a, b);
                            if (!ret.Contains(temp2))
                            {
                                ret.Add(temp2);
                            }
                            if (temp2.EndsWith("す"))
                            {
                                string temp3 = temp2 + "る";
                                if (!ret.Contains(temp3))
                                {
                                    ret.Add(temp3);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }
        public List<string> inflect(string input) {
            List<string> ret = new List<string>();
            ta a1 = new ta();
            List<string> b1 = a1.inflect(input);
            foreach (string a in b1)
            {
                bool x = returnChecker(a);
                if (x == true)
                {
                    ret.Add(a);
                }
                else
                {
                    List<string> retx = masuInflect(a);
                    foreach (string z in retx)
                    {
                        if (!ret.Contains(z))
                        {
                            ret.Add(z);
                        }
                    }
                }
            }
            List<string> rety = masuInflect(input);
            foreach (string z in rety)
            {
                if (!ret.Contains(z))
                {
                    ret.Add(z);
                }
            }

            return ret;
        }
    }

    public class rare { 
        public List<string> list;
        public Dictionary<char, char> dict;
        public rare() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister()
        {
            List<string> retlist = new List<string>();
            retlist.Add("われ");
            retlist.Add("られ");
            retlist.Add("たれ");
            retlist.Add("ぱれ");
            retlist.Add("され");
            retlist.Add("だれ");
            retlist.Add("がれ");
            retlist.Add("はれ");
            retlist.Add("かれ");
            retlist.Add("ざれ");
            retlist.Add("ばれ");
            retlist.Add("なれ");
            retlist.Add("まれ");
            return retlist;
        }
        public Dictionary<char, char> dicter() {
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
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> lister1(){
            List<string> ret = new List<string>();
            ret.Add("む");
            ret.Add("ぬ");
            ret.Add("ぶ");
            ret.Add("ず");
            ret.Add("く");
            ret.Add("ぐ");
            ret.Add("ふ");
            ret.Add("づ");
            ret.Add("す");
            ret.Add("ぷ");
            ret.Add("う");
            ret.Add("つ");
            ret.Add("る");
            ret.Add("い");
            return ret;
        }
        public bool returnChecker(string input)
        {
            List<string> xx = lister1();
            foreach (string a in xx)
            {
                if (input.EndsWith(a))
                {
                    if (a.Equals("う"))
                    {
                        List<string> tempL = lister();
                        foreach (string temps in tempL)
                        {
                            if (input.EndsWith(temps))
                            {
                                return false;
                            }
                        }
                        if (input.EndsWith("そう"))
                        {
                            return false;
                        }
                    }
                    if (a.Equals("す"))
                    {
                        if (input.EndsWith("ます"))
                        {
                            return false;
                        }
                    }
                    if (a.Equals("い"))
                    {
                        if (input.EndsWith("ない"))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        public List<string> rareInflect(string a) {
            List<string> ret = new List<string>();
            if (a.EndsWith("る")) {
                a = chopper1(a, "る");          
            }
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    string temp2 = chopper2(a, b);
                    if (!ret.Contains(temp2))
                    {
                        ret.Add(temp2);
                    }
                    if (temp2.EndsWith("す"))
                    {
                        string temp3 = temp2 + "る";
                        if (!ret.Contains(temp3))
                        {
                            ret.Add(temp3);
                        }
                    }
                }
            }
            return ret;
        }
        public List<string> inflect(string input) {
            List<string> ret = new List<string>();
            masu a1 = new masu();
            chau a2 = new chau();
            nai a3 = new nai();
            ba a4 = new ba();
            nasai a5 = new nasai();
            sou a6 = new sou();
            tai a7 = new tai();
            sugiru a8 = new sugiru();
            volitional a9 = new volitional();
            mashou a10 = new mashou();
            imperative a11 = new imperative();
            masen a12 = new masen();
            List<string> b1 = a1.inflect(input);
            List<string> b2 = a2.inflect(input);
            List<string> b3 = a3.inflect(input);
            List<string> b4 = a4.inflect(input);
            List<string> b5 = a5.inflect(input);
            List<string> b6 = a6.inflect(input);
            List<string> b7 = a7.inflect(input);
            List<string> b8 = a8.inflect(input);
            List<string> b9 = a9.inflect(input);
            List<string> b10 = a10.inflect(input);
            List<string> b11 = a11.inflect(input);
            List<string> b12 = a12.inflect(input);
            foreach (string a in b1) { 
                bool x = returnChecker(a);
                if(a.EndsWith("る") || (x == true)){
                    List<string> test = rareInflect(a);
                    int counter = 0;
                    foreach (string c in test) {
                        if (!ret.Contains(c)) {
                            ret.Add(c);
                            counter++;
                        }
                    }
                    if(counter == 0){
                        ret.Add(a);
                    }
                }
            }
            foreach (string a in b2)
            {
                bool x = returnChecker(a);
                if (a.EndsWith("る") || (x == true))
                {
                    List<string> test = rareInflect(a);
                    int counter = 0;
                    foreach (string c in test)
                    {
                        if (!ret.Contains(c))
                        {
                            ret.Add(c);
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        ret.Add(a);
                    }
                }
            }
            foreach (string a in b3)
            {
                bool x = returnChecker(a);
                if (a.EndsWith("る") || (x == true))
                {
                    List<string> test = rareInflect(a);
                    int counter = 0;
                    foreach (string c in test)
                    {
                        if (!ret.Contains(c))
                        {
                            ret.Add(c);
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        ret.Add(a);
                    }
                }
            }
            foreach (string a in b4)
            {
                bool x = returnChecker(a);
                if (a.EndsWith("る") || (x == true))
                {
                    List<string> test = rareInflect(a);
                    int counter = 0;
                    foreach (string c in test)
                    {
                        if (!ret.Contains(c))
                        {
                            ret.Add(c);
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        ret.Add(a);
                    }
                }
            }
            foreach (string a in b5)
            {
                bool x = returnChecker(a);
                if (a.EndsWith("る") || (x == true))
                {
                    List<string> test = rareInflect(a);
                    int counter = 0;
                    foreach (string c in test)
                    {
                        if (!ret.Contains(c))
                        {
                            ret.Add(c);
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        ret.Add(a);
                    }
                }
            }
            foreach (string a in b6)
            {
                bool x = returnChecker(a);
                if (a.EndsWith("る") || (x == true))
                {
                    List<string> test = rareInflect(a);
                    int counter = 0;
                    foreach (string c in test)
                    {
                        if (!ret.Contains(c))
                        {
                            ret.Add(c);
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        ret.Add(a);
                    }
                }
            }
            foreach (string a in b7)
            {
                bool x = returnChecker(a);
                if (a.EndsWith("る") || (x == true))
                {
                    List<string> test = rareInflect(a);
                    int counter = 0;
                    foreach (string c in test)
                    {
                        if (!ret.Contains(c))
                        {
                            ret.Add(c);
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        ret.Add(a);
                    }
                }
            }
            foreach (string a in b8)
            {
                bool x = returnChecker(a);
                if (a.EndsWith("る") || (x == true))
                {
                    List<string> test = rareInflect(a);
                    int counter = 0;
                    foreach (string c in test)
                    {
                        if (!ret.Contains(c))
                        {
                            ret.Add(c);
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        ret.Add(a);
                    }
                }
            }
            foreach (string a in b9)
            {
                bool x = returnChecker(a);
                if (a.EndsWith("る") || (x == true))
                {
                    List<string> test = rareInflect(a);
                    int counter = 0;
                    foreach (string c in test)
                    {
                        if (!ret.Contains(c))
                        {
                            ret.Add(c);
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        ret.Add(a);
                    }
                }
            }
            foreach (string a in b10)
            {
                bool x = returnChecker(a);
                if (a.EndsWith("る") || (x == true))
                {
                    List<string> test = rareInflect(a);
                    int counter = 0;
                    foreach (string c in test)
                    {
                        if (!ret.Contains(c))
                        {
                            ret.Add(c);
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        ret.Add(a);
                    }
                }
            }
            foreach (string a in b11)
            {
                bool x = returnChecker(a);
                if (a.EndsWith("る") || (x == true))
                {
                    List<string> test = rareInflect(a);
                    int counter = 0;
                    foreach (string c in test)
                    {
                        if (!ret.Contains(c))
                        {
                            ret.Add(c);
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        ret.Add(a);
                    }
                }
            }
            foreach (string a in b12)
            {
                bool x = returnChecker(a);
                if (a.EndsWith("る") || (x == true))
                {
                    List<string> test = rareInflect(a);
                    int counter = 0;
                    foreach (string c in test)
                    {
                        if (!ret.Contains(c))
                        {
                            ret.Add(c);
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        ret.Add(a);
                    }
                }
            }
            List<string> rety = rareInflect(input);
            foreach (string z in rety)
            {
                if (!ret.Contains(z))
                {
                    ret.Add(z);
                }
            }
            return ret;
        }
    }

    public class sase { 
        public List<string> list;
        public Dictionary<char, char> dict;
        public sase() {
            list = lister();
            dict = dicter();
        }
        public List<string> lister() {
            List<string> retlist = new List<string>();
            retlist.Add("わせ");
            retlist.Add("らせ");
            retlist.Add("たせ");
            retlist.Add("ぱせ");
            retlist.Add("させ");
            retlist.Add("だせ");
            retlist.Add("がせ");
            retlist.Add("はせ");
            retlist.Add("かせ");
            retlist.Add("ざせ");
            retlist.Add("ばせ");
            retlist.Add("なせ");
            retlist.Add("ませ");
            return retlist;
        }
        public Dictionary<char, char> dicter() {
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
            return ret;
        }
        public string chopper1(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < marker; cnt++)
            {
                ret = ret + meat[cnt];
            }
            return ret;
        }
        public string chopper2(string meat, string knife)
        {
            int marker = meat.Length - knife.Length;
            string ret = "";
            for (int cnt = 0; cnt < (marker + 1); cnt++)
            {
                if (cnt == marker)
                {
                    ret = ret + dict[meat[cnt]];
                }
                else
                {
                    ret = ret + meat[cnt];
                }
            }
            return ret;
        }
        public List<string> lister1()
        {
            List<string> ret = new List<string>();
            ret.Add("む");
            ret.Add("ぬ");
            ret.Add("ぶ");
            ret.Add("ず");
            ret.Add("く");
            ret.Add("ぐ");
            ret.Add("ふ");
            ret.Add("づ");
            ret.Add("す");
            ret.Add("ぷ");
            ret.Add("う");
            ret.Add("つ");
            ret.Add("る");
            ret.Add("い");
            return ret;
        }
        public List<string> xlister()
        {
            List<string> telist = new List<string>();
            telist.Add("んじゃ");
            telist.Add("いじゃ");
            telist.Add("っちゃ");
            telist.Add("しちゃ");
            telist.Add("いちゃ");
            telist.Add("ちゃ");
            return telist;
        }
        public bool returnChecker(string input)
        {
            List<string> xx = lister1();
            foreach (string a in xx)
            {
                if (input.EndsWith(a))
                {
                    if (a.Equals("う"))
                    {
                        List<string> tempL = lister();
                        foreach (string temps in tempL)
                        {
                            if (input.EndsWith(temps))
                            {
                                return false;
                            }
                        }
                        if (input.EndsWith("そう"))
                        {
                            return false;
                        }
                    }
                    if (a.Equals("す"))
                    {
                        if (input.EndsWith("ます"))
                        {
                            return false;
                        }
                    }
                    if (a.Equals("い"))
                    {
                        if (input.EndsWith("ない"))
                        {
                            return false;
                        }
                    }
                    List<string> xlist = xlister();
                    foreach (string bx in xlist) {
                        string xd = bx + a;
                        if (input.EndsWith(bx + a)) {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        public List<string> saseInflect(string a) {
            List<string> ret = new List<string>();
            if (a.EndsWith("る"))
            {
                a = chopper1(a, "る");
            }
            foreach (string b in list)
            {
                if (a.EndsWith(b))
                {
                    string temp2 = chopper2(a, b);
                    if (!ret.Contains(temp2))
                    {
                        ret.Add(temp2);
                    }
                    if (temp2.EndsWith("す"))
                    {
                        string temp3 = temp2 + "る";
                        if (!ret.Contains(temp3))
                        {
                            ret.Add(temp3);
                        }
                        string temp4 = chopper1(temp2, "す") + "る";
                        if (!ret.Contains(temp4))
                        {
                            ret.Add(temp4);
                        }
                    }
                }
            }
            return ret;
        }
        public List<string> inflect(string input)
        {
            List<string> ret = new List<string>();
            rare a1 = new rare();
            List<string> b1 = a1.inflect(input);
            foreach (string a in b1)
            {
                bool x = returnChecker(a);
                if (a.EndsWith("る") || (x == true))
                {
                    List<string> test = saseInflect(a);
                    int counter = 0;
                    foreach (string c in test)
                    {
                        if (!ret.Contains(c))
                        {
                            ret.Add(c);
                            counter++;
                        }
                    }
                    if (counter == 0)
                    {
                        if (!ret.Contains(a)) {
                            ret.Add(a);
                        }
                    }
                }
            }
            List<string> rety = saseInflect(input);
            foreach (string z in rety)
            {
                if (!ret.Contains(z))
                {
                    ret.Add(z);
                }
            }
            List<string> returnList = new List<string>();
            foreach (string adds in ret) {
                if (!adds.EndsWith("ちゃる") && !adds.EndsWith("ちゃっる") && adds.Length > 1) {
                    returnList.Add(adds);
                }
            }
            return returnList;
        }
    }

}
