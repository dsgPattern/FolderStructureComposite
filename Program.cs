using System;

namespace FolderStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //root
            //  File1
            //  Folder1
            //      File11
            //  Folder2
            //      File2


            var root = new Folder("root");
            root.AddItem(new File("File1"));
            root.AddItem(new Folder("Folder1"));

            var folder2 = new Folder("Folder2");
            folder2.AddItem(new File("File2"));
            var folder3 = new Folder("Folder3");
            folder3.AddItem(new File("File3"));
            folder2.AddItem(folder3);
            root.AddItem(folder2);

            root.ListName(" ");

            //folder2.ListName(" ");

            Console.ReadLine();
        }
    }
}
