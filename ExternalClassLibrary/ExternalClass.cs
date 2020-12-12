using ExternalClassLibrary2;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ExternalClassLibrary
{
    public class ExternalClass
    {
        public void Teste()
        {
            var assembly = Assembly.GetEntryAssembly();
            var assembly3 = Assembly.GetExecutingAssembly();
            ExternalClass2.Teste();
        }
    }
}
