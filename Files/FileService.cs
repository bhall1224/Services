using System;
using System.Diagnostics;
using System.Collections;
using System.IO;

namespace Services.Files
{
    public class FileService
    {
        public string FileContents { get; set; }

        public void SaveFile(string fileContent, string fileName)
        {
            Console.WriteLine($"Save Game file: {fileContent} to file: {fileName}");

            string dir = Directory.GetCurrentDirectory();
            Console.WriteLine($"Current working directory: {dir}");

            string path = $"{dir}/{fileName}";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(fileContent);
            }
        }

        public void LoadFile(string fileName)
        {
            Console.WriteLine($"Loading file: {fileName}");

            string dir = Directory.GetCurrentDirectory();
            Console.WriteLine($"Current working directory: {dir}");

            string path = $"{dir}/{fileName}";
            using (StreamReader sr = File.OpenText(path))
            {
                string contents;
                while ((contents = sr.ReadLine()) != null)
                {
                    Console.WriteLine($"Contents: {contents}");
                    FileContents += contents;
                }
            }
        }
    }
}
