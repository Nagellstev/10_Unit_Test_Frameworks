using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrary
{
    public class JsonWriting
    {
        JsonWriter writer;
        public JsonWriting()
        {
            StreamWriter logFile = File.CreateText("StringProcessing.json");
            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);
            writer.Formatting = Newtonsoft.Json.Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("String Processings");
            writer.WriteStartArray();
        }
        public void EndJsonFile()
        {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }
        public void StartJsonPartition(string inputStr)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("Input String");
            writer.WriteValue(inputStr);
        }
        public void EndJsonPartition(string result)
        {
            writer.WritePropertyName("Result");
            writer.WriteValue(result);
            writer.WriteEndObject();
        }
    }
}
