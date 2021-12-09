using System;
using System.IO;

/*Mit dem Schlüsselwort using wird ein Objekt erzeugt, welches nach dem Codeblock das zu dem using Statement gehört, sofort aus dem Speicher gelöscht wird.
 *Es wird die dispose() Methode am Ende aufgerufen -> automatisch
 *Damit wird der ganze Speicher am Ende wieder frei gemacht! 
 */

namespace Modul22UsingStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Thanatos\Desktop\Testordner\TestWriter.txt", true))
            {
                sw.WriteLine("Salü Hans Nötig, geits guet?");

                sw.WriteLine("");
                sw.WriteLine("Salü Hans Nötig, geits guet?");
            }
        }
    }
}
