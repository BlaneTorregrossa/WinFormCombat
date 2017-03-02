using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace WinFormCombat
{
    class DataManager
    {

        
        public static void Serialize<T>(string fileName, T data)
        {
            XmlSerializer serilazation = new XmlSerializer(typeof(T));
            System.IO.TextWriter writer = new System.IO.StreamWriter(fileName + ".xml");
            serilazation.Serialize(writer, data);
            writer.Close();
        }

        
        public static T Deserialize<T>(string fileName)
        {
            T data;
            XmlSerializer serilazation = new XmlSerializer(typeof(T));
            System.IO.TextReader reader = new System.IO.StreamReader(fileName + ".xml");
            data = (T)serilazation.Deserialize(reader);
            reader.Close();
            return data;
                        
        }

   
    }
}
