using System;
using System.IO;
using System.Collections.Generic;

namespace FileServiceLibrary
{
    public class FileService
    {
        public List<string> getFileList(string dir = ".") {
            return new List<string>(Directory.GetFiles(dir));
        }

        public List<string> getDirectoryList(string dir = ".") {
            return new List<string>(Directory.EnumerateDirectories(dir));
        }
    }
}
