﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace RCS_08._15_Student
{
    class FileIO
    {
        public static void SaveToFile(List<Student> st)
        {
            string jsonString;
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            jsonString = System.Text.Json.JsonSerializer.Serialize(st, options);

            File.WriteAllText(GetGameFile(), jsonString);
        }

        public static List<Student> LoadFromFile()
        {
            try
            {
                StreamReader reader = new StreamReader(GetGameFile());
                String line = reader.ReadLine();
                String json = "";

                while (line != null)
                {
                    json += line;
                    line = reader.ReadLine();
                }
                reader.Close();

                return System.Text.Json.JsonSerializer.Deserialize<List<Student>>(json);
            }
            catch
            {
                return null;
            }
        }

        public static string GetGameFile()
        {
            string filename = Directory.GetCurrentDirectory();
            filename += @"\StudList.json";

            return filename;
        }
    }
}