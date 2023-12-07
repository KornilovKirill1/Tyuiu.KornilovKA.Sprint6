using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KornilovKA.Sprint6.Task6.V17.Lib
{
    public class DataService : ISprint6Task6V17
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //if (line == "")
                    //{
                    //    continue;
                    //} else
                    //{
                    //    string[] arrayString = line.Split(' ');
                    //    resStr = resStr + arrayString[2] + " ";
                    //}
                    //StringBuilder result = new StringBuilder();
                    if(line == "")
                    {
                        continue;
                    } else
                    {
                        List<string> result = new List<string>();
                        MatchCollection words = Regex.Matches(line, @"[А-Яа-яA-Za-z]+");
                        foreach (var word in words)
                        {
                            result.Add(word.ToString());
                        }
                        resStr = resStr + result[2] + " ";
                    }
                }
            }
            resStr = resStr.Remove(resStr.Length - 1);
            return resStr;
        }
    }
}
