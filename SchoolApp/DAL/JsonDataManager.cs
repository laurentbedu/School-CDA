using System.Runtime.Serialization.Json;

namespace SchoolApp.DAL
{
    internal class JsonDataManager<T> where T : Models.Model
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
            //set
            //{
            //    dataList = value;
            //    SaveJsonData();

            //}
        }

        private List<T> LoadJsonData()
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<T>));
            string filePath = $"Json/{typeof(T).Name}.json";
            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return (List<T>)serializer.ReadObject(stream);
            }
            //return new List<T>();
        }

        public bool SaveJsonData()
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<T>));
            string filePath = $"Json/{typeof(T).Name}.json";
            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                serializer.WriteObject(stream, dataList);
            }
            return true;
        }
    }
}
