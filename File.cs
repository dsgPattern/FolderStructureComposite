using System;
using System.Collections.Generic;
using System.Text;

namespace FolderStructure
{
    internal class File: IStorageObject
    {
        private string _name;

        public File(string name)
        {
            _name = name;
        }

        public void ListName(string indentation)
        {
            Console.WriteLine(indentation + _name);
        }
    }
}
