using System;
using System.Reflection;

namespace ExternalClassLibrary2
{
    public static class ExternalClass2
    {
        public static void Teste()
        {
            var assembly1 = Assembly.GetCallingAssembly();
            var assembly2 = Assembly.GetEntryAssembly();
            var assembly3 = Assembly.GetExecutingAssembly();
        }
    }
}
