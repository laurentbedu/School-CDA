using Microsoft.VisualBasic.ApplicationServices;
using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;


namespace SchoolApp.DAL
{
    internal class JsonDataManager<T> where T : Model
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

        public List<T> LoadJsonData()
        {
            DataContractJsonSerializer serializer= new DataContractJsonSerializer(typeof(T));
            string filePath = $"Json/{typeof(T).Name}.json";
            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate)) 
            { 
            var result = serializer.ReadObject(stream);

                return (List<T>)result;
            }

             }

        public bool SaveJsonData()
        {
           DataContractJsonSerializer serializer= new DataContractJsonSerializer(typeof(T));
            string filePath = $"Json/{typeof(T).Name}.json";
            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                serializer.WriteObject(stream, dataList);
                return true;
            }
            
        }
        //public void Serialize(Eleve eleve)
        // {
        //     string jsonString = JsonSerializer.Serialize(eleve);
        //     File.WriteAllText("C:\\Users\\xseb\\source\\repos\\School - CDA\\SchoolApp\\dataEleve.json", jsonString);
        // }
    }
}
