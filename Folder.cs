using System;
using System.Collections.Generic;
using System.Text;

namespace FolderStructure
{
    internal class Folder:IStorageObject
    {
        private string _name;
        private List<IStorageObject> _childItems = new List<IStorageObject>();

        public Folder(string name)
        {
            _name = name;
        }

        public void AddItem(IStorageObject storageObject)
        {
            _childItems.Add(storageObject);
        }

        public void RemoveItem(IStorageObject storageObject)
        {
            _childItems.Remove(storageObject);
        }

        public void ListName(string indentation)
        {
            Console.WriteLine(indentation + _name);
            foreach (var storageObject in _childItems)
            {
                storageObject.ListName(indentation + indentation);
            }
        }
    }
}
