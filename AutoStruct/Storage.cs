using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using AutoStruct.Data;

namespace AutoStruct
{
    class Storage
    {
        public void Save(List<AutoData> info)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(@"data.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, info);
                sw.Close();
            }
        }

        public List<AutoData> Load()
        {
            JsonSerializer serializer = new JsonSerializer();
            List<AutoData> result = new List<AutoData>();

            using (StreamReader sr = new StreamReader(@"data.json"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                result = serializer.Deserialize<List<AutoData>>(reader);
                sr.Close();
            }

            return result;
        }

        //For the tests
        public void Save(List<AutoData> info, string file)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter($@"{file}.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, info);
                sw.Close();
            }
        }

        public List<AutoData> Load(string file)
        {
            JsonSerializer serializer = new JsonSerializer();
            List<AutoData> result = new List<AutoData>();

            using (StreamReader sr = new StreamReader($@"{file}.json"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                result = serializer.Deserialize<List<AutoData>>(reader);
                sr.Close();
            }

            return result;
        }
    }
}
