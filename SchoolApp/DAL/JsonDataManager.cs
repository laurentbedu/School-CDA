using Microsoft.VisualBasic.ApplicationServices;
using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolApp.DAL
{
    internal class JsonDataManager<T> where T : Models.ModelBase
    {
        private List<T> dataList;

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
           
            string fileName = "C:\\Users\\afpa\\source\\repos\\School-CDA\\SchoolApp\\Json\\Niveau.json";
                string jsonString = File.ReadAllText(fileName);
                List<T> data = JsonSerializer.Deserialize<List<T>>(jsonString)!;

                return data;
            
        }
    }
}
