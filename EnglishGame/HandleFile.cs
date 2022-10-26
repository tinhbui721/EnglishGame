using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EnglishGame
{
    internal class HandleFile
    {

        public static bool SaveFile(string data, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path + "\\File\\data.txt", true, Encoding.UTF8);
                sw.WriteLine(data);
                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool DeleteData(string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path + "\\File\\data.txt", false, Encoding.UTF8);
                sw.Write("");
                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static List<Data> ReadFile(string path)
        {
            StreamReader sr = new StreamReader(path + "\\File\\data.txt", Encoding.UTF8);
            try
            {
                List<Data> list = new List<Data>();
                string line = sr.ReadLine();
                while (line != null)
                {

                    string[] arr = line.Split(';');
                    Data data = new Data();
                    data.point = int.Parse(arr[0]);
                    data.second = int.Parse(arr[1].Split(':')[2]);
                    data.minute = int.Parse(arr[1].Split(':')[1]);
                    data.hour = int.Parse(arr[1].Split(':')[0]);
                    data.topic = arr[2];
                    list.Add(data);
                    line = sr.ReadLine();
                }
                sr.Close();
                return list;
            }
            catch (Exception e)
            {
                sr.Close();
                return null;
                //throw e;
            }
        }
    }
}
