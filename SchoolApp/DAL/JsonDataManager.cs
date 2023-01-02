using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolApp.DAL
{
    internal class JsonDataManager<T> where T : Models.Model
    {
        private List<T>? dataList;

        public List<T> DataList
        {
            get
            {
                if (dataList == null)
                {
                    dataList = LoadJsonData();

                }
                return dataList;
            }
        }
        private List<T> LoadJsonData()
        {
            string str = typeof(T).Name;
            string fileName = "C:\\Users\\Nicolas\\Source\\Repos\\laurentbedu\\School-CDA\\SchoolApp\\Json\\" + str + ".json";
            string jsonString = File.ReadAllText(fileName);
            List<T> newList = JsonSerializer.Deserialize<List<T>>(jsonString)!;

            return newList;
        }

        public void WriteJsonData(List<T> dataList)
        {
            string str = typeof(T).Name;
            string fileName = "C:\\Users\\Nicolas\\Source\\Repos\\laurentbedu\\School-CDA\\SchoolApp\\Json\\"+str+".json";
            string jsonString = JsonSerializer.Serialize(dataList);
            File.WriteAllText(fileName, jsonString);

        }
        
    }
}

