using Microsoft.VisualBasic.ApplicationServices;
using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace SchoolApp.DAL
{
    internal class JsonDataManager<T> where T : Models.ModelBase
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
            string typeName = typeof(T).Name;
            string fileName = "Json\\" + typeName +".json";
                string jsonString = File.ReadAllText(fileName);
                List<T> data = JsonSerializer.Deserialize<List<T>>(jsonString)!;
                return data;            
        }

        public void SaveJsonData (List<T> dataList) 
        {
            string typeName = typeof(T).Name;
            string fileName = "Json\\" + typeName + ".json";
            string jsonString = JsonSerializer.Serialize(DataList);
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
