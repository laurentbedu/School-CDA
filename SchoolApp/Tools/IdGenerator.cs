namespace SchoolApp.Tools
{
    internal static class IdGenerator
    {
        public static string generateId(object obj)
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
    }

}
