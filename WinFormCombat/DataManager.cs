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

        /// <summary>
        /// Save function
        /// Problem: SavedData folder is created on desktop and not in the folder with the executable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"> Name of the file </param>
        /// <param name="data"> Data saved in file</param>
        public static void Serialize<T>(string fileName, T data)
        {
            XmlSerializer serilazation = new XmlSerializer(typeof(T));
            Directory.CreateDirectory("../ADGP-125/SavedData/");
            System.IO.TextWriter writer = new System.IO.StreamWriter("../ADGP-125/SavedData/" + fileName + ".xml");
            serilazation.Serialize(writer, data);
            writer.Close();
        }

        /// <summary>
        /// load function
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"> Name of the file </param>
        /// <returns></returns>
        public static T Deserialize<T>(string fileName)
        {
            T data;
            XmlSerializer serilazation = new XmlSerializer(typeof(T));
            System.IO.TextReader reader = new System.IO.StreamReader("../ADGP-125/SavedData/" + fileName + ".xml");
            data = (T)serilazation.Deserialize(reader);
            reader.Close();
            return data;
                        
        }

   
    }
}
