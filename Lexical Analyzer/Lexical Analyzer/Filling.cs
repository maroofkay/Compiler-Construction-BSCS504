﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lexical_Analyzer
{
    static
    class Filling
    {
        public
        static
        string[] Read(string fileName)
        {
            string path = RootDirectory() + fileName;
            string[] lines = File.ReadAllLines(path);
            return lines;
        }

        public
        static
        void Write(string fileName, string[] lines)
        {
            string path = RootDirectory() + fileName;
            File.WriteAllLines(path, lines);
        }

        private
        static
        string RootDirectory()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string directory = baseDirectory.Replace(@"bin\Debug\", "");
            return directory;
        }
    }
}
