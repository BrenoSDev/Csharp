using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Banco.Contas;
using Banco;

namespace Caelum
{
    public static class ObjectExtensions
    {
        public static string AsXml(this Conta resource)
        {
            var stringWriter = new StringWriter();
            new XmlSerializer(resource.GetType()).Serialize(stringWriter, resource);
            return stringWriter.ToString();
        }

        public static void MudaTitular(this Conta c, Cliente titular)
        {
            c.Titular = titular;
        }
    }
}
