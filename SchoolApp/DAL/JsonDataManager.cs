using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
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

        public void SaveJsonData()
        {
            string str = typeof(T).Name;
            string fileName = "C:\\Users\\Nicolas\\Source\\Repos\\laurentbedu\\School-CDA\\SchoolApp\\Json\\"+str+".json";
            string jsonString = JsonSerializer.Serialize(dataList);
            File.WriteAllText(fileName, jsonString);

        }

        public List<T> GetWhere(Predicate<T>? filter = null)
        {
            //var list = DataList.FindAll(filter);
            var result = filter != null ? DataList.FindAll(filter) : DataList;
            return result;
        }

        public T? GetById(string? id)
        {
            //List<T> list = GetWhere(item => item.Id == id);
            List<T> list = DataList.FindAll(obj => obj.Id == id);
            return id != null && list.Count == 1 ? list.First() : null;
        }

    }
}

