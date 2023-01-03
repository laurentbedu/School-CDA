using System.Runtime.Serialization.Json;

namespace SchoolApp.Extensions
{
    public static class ListExtensions
    {
        public static bool Serialize<T>(this List<T> dataList)
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
