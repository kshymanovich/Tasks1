using System;
using System.Collections;
using System.Text.RegularExpressions;

//1. из URL получить информацию о кол-ве взрослых, детей и их возрасте. https://www.virginholidays.co.uk/holiday/orlando?departureDate=27-04-2019&duration=7&gateway=LGW&room=a3,i1,c3,c6,c2. в данном случае 3 взрослых, 1 infant(< 2 лет) и еще трое детей с возрастами 3, 6 и 2 лет)
namespace RegExUrl
{
    class UrlInfo
    {
        public string GetPassRow(string url)
        {
            string[] spliturl = url.Split('=');
            string passrow;
            return passrow = spliturl[spliturl.Length - 1];
        }

        public void PassCountAge(string url)
        {
            string pattern = @"[aic]\d*";
            int childnum = 0;
            MatchCollection mc = Regex.Matches(GetPassRow(url), pattern);
            ArrayList childage = new ArrayList();
            foreach (Match m in mc)
            {
                string mstr = m.ToString();
                if (mstr[0] == 'a') Console.WriteLine("number of adults is " + mstr.Substring(1));
                else if (mstr[0] == 'i') Console.WriteLine("number of infants (under 2 y.o.) is " + mstr.Substring(1));
                else if (mstr[0] == 'c')
                {
                    childage.Add(mstr.Substring(1));
                    childnum++;
                }
            }

            Console.Write("number of children is " + childnum + ", aged ");
            for (int i = 0; i < childnum; i++)
            {
                if (childnum > (i + 1)) Console.Write(childage[i] + ", ");
                else Console.WriteLine("and " + childage[i] + ".");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.virginholidays.co.uk/holiday/orlando?departureDate=27-04-2019&duration=7&gateway=LGW&room=a3,i1,c3,c6,c2";
            UrlInfo urlinfo1 = new();
            Console.WriteLine(urlinfo1.GetPassRow(url));
            urlinfo1.PassCountAge(url);
        }
    }
}
