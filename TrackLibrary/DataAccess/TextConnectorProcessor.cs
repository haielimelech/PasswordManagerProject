using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using TrackLibrary.Models;

namespace TrackLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFillPath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["FilePath"]}\\{ fileName }";
        }

        public static List <string> LoadFile (this string file)
        {
            if (File.Exists(file)==false) //if the file not exist
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
        public static List<PasswordModel> ConvertToPasswordModels(this List <string> lines)
        {
            List<PasswordModel> output = new List<PasswordModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PasswordModel p = new PasswordModel();
                p.Id = int.Parse(cols[0]);
                p.Name = cols[1];
                p.Email = cols[2];
                p.password = cols[3];
                p.Previous_password =cols[4];
                output.Add(p);
            }
            return output;
        }

        public static void SaveToPasswordFile(this List<PasswordModel> models,string FileName)
        {
            List<string> lines = new List<string>();
            foreach (PasswordModel p in models)
            {
               lines.Add($"{p.Id},{p.Name},{p.Email},{p.password},{p.Previous_password}");
            }
            File.WriteAllLines(FileName.FullFillPath(),lines);
        }
    }

}
