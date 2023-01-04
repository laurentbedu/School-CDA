﻿using System.Runtime.Serialization.Json;

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
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<T>));
            string filePath = $"Json/{typeof(T).Name}.json";
            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                var result = serializer.ReadObject(stream);
                return (List<T>)result;
            }
        }

        public bool SaveJsonData()
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<T>));
            string filePath = $"Json/{typeof(T).Name}.json";
            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                serializer.WriteObject(stream, dataList);
                return true;
            }
        }

        public List<T> GetWhere(Predicate<T>? filter = null)
        {
            return filter != null ? DataList.FindAll(filter) : DataList;
        }

        public T? GetById(string? id)
        {
            List<T> list = GetWhere(item => item.Id == id);
            return id != null && list.Count == 1 ? GetWhere(item => item.Id == id).First() : null;
        }


    }
}
