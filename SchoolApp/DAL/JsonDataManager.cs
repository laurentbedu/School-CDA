﻿using Microsoft.VisualBasic.ApplicationServices;
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
