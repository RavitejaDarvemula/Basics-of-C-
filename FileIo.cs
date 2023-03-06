using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice
{
    class FileIo
    {
        static void Main(string[] args)
        {
            FileStream F = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for(int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }
            F.Position = 0;
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine(F.ReadByte() + " ");
            }
            F.Close();
        }
    }
}
