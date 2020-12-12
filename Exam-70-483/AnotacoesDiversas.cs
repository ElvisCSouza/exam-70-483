using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Exam_70_483
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class Documentation : Attribute
    {
        private string Privado;
        private string OutroPrivado;
        public string Publico;
        public string OutroPublico;
        public Documentation(string privado)
        {
            Privado = privado;
        }
    }

    [Documentation("teste", Publico = "teste", OutroPublico = "teste")]
    public class AnotacoesDiversas
    {
        public void Test()
        {
            if (!EventLog.SourceExists("Teste"))
            {
                EventLog.CreateEventSource("Teste", "AppCenter");
            }
            EventLog eventLog = new EventLog("AppCenter");
            eventLog.Source = "Teste";
            eventLog.WriteEntry("Invalido");
        }
    }
}
