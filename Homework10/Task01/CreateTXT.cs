using System;
using System.IO;
namespace Task01
{
    static class CreateTXT
    {
        static string folder;
        static int count;
        public static void CreateFile(string file)
        {
            if (count == 0) folder = file.Remove(file.IndexOf("\\")+1);
            string more = file.Replace(folder, "");
            try
            {
                new FileInfo(file).Create();
                folder = "";
                count = 0;
            }
            catch (Exception)
            {
                count++;
                folder = folder.Insert(folder.Length, more.Remove(more.IndexOf("\\") + 1));
                if (!new DirectoryInfo(folder).Exists)
                {
                    new DirectoryInfo(folder).Create();
                    Console.WriteLine(folder);
                }
                CreateFile(file);
            }

        }
    }
}
