using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;

namespace Butterfly.Service.Salary.Model
{
    public class Serializer
    {
        public static void Serialize(object obj, Stream outputStream)
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(obj.GetType());
            json.WriteObject(outputStream, obj);
        }
        public static object Deserialize(string content, Type type)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(content);
            DataContractJsonSerializer json = new DataContractJsonSerializer(type);
            MemoryStream m = new MemoryStream(bytes);            
            return json.ReadObject(m);
        }
        public static object Deserialize(Stream inputStream, Type type)
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(type);
            return json.ReadObject(inputStream);
        }
    }
}