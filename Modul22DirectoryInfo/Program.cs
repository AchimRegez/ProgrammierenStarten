using System;
using System.IO;

namespace Modul22DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erstelle DirectoryInfo-Objekt
            string path = @"C:\Users\Thanatos\Desktop\Testordner";
            string path2 = @"C:\Users\Thanatos\Desktop\MeinOrdner";
            //Fehlermeldung wegen \ -> ESCAPE SEQUENZ wird mit \ eingeleitet. Mit @ werden die Escape Sequenzen deaktiviert
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectoryInfo directoryInfo2 = new DirectoryInfo(path2);

            Console.WriteLine(directoryInfo.Name);
            Console.WriteLine(directoryInfo.FullName);
            Console.WriteLine(directoryInfo.Exists);
            Console.WriteLine(directoryInfo.Root);
            Console.WriteLine(directoryInfo.CreationTime);
            Console.WriteLine(directoryInfo.CreateSubdirectory("Subfolder"));

            //Erstelle einen Ordner
            directoryInfo2.Create();

            //Lösche den Ordner !!! ACHTUNG !!! ORDNER WIRD DIREKT GELÖSCHT !!!
            //Wenn eine Datei im Ordner ist, muss true mitgegeben werden!!!
            //directoryInfo2.Delete(true);

            //Erstellt ein Array aus den Subordner/Unterordner
            Console.WriteLine();
            Console.WriteLine("DirectoryInfo-Array:");
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();

            //Durchläuft das Array und gibt Subordner/Unterordner in der Konsole aus
            foreach (DirectoryInfo directory in directoryInfos)
            {
                Console.WriteLine(directory.Name);
            }

            //Erstellt ein Array aus den Dateien im Ordner
            Console.WriteLine();
            Console.WriteLine("FileInfo-Array:");
            FileInfo[] files = directoryInfo.GetFiles();

            //Durchläuft das Array und gibt die Dateien in der Konsole aus
            foreach(FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }

            Console.ReadKey();
        }
    }
}
