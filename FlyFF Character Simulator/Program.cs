using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FlyFF_Character_Simulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Init();
        }
        private class ResFile
        {
            public string fileName;
            public byte[] content;
            public int offset;
        }
        private static void Init()
        {
            ResFile[] files = ReadRes("C:/Program Files/Gpotato/Flyff/dataSub2.res");
            
        }
        private static ResFile[] ReadRes(string path)
        {
            BinaryReader bs = new BinaryReader(new FileStream(path, FileMode.Open));
            byte encKey = bs.ReadByte();
            bool encrypted = bs.ReadByte() == 1;
            byte[] header = bs.ReadBytes(bs.ReadInt32());
            for (int i = 0; i < header.Length; i++)
                header[i] = Decrypt(header[i], encKey);
            BinaryReader hr = new BinaryReader(new MemoryStream(header));
            hr.ReadBytes(7);
            ResFile[] inner = new ResFile[hr.ReadInt16()];
            for (int i = 0; i < inner.Length; i++)
            {
                inner[i] = new ResFile();
                inner[i].fileName = Encoding.ASCII.GetString(hr.ReadBytes(hr.ReadInt16()));
                inner[i].content = new byte[hr.ReadInt32()];
                hr.ReadInt32();
                inner[i].offset = hr.ReadInt32();
            }
            hr.Close();
            for (int i = 0; i < inner.Length; i++)
            {
                bs.BaseStream.Seek(inner[i].offset, SeekOrigin.Begin);
                for (int b = 0; b < inner[i].content.Length; b++)
                    inner[i].content[b] = Decrypt(bs.ReadByte(), encKey);
            }
            bs.Close();
            return inner;
        }
        private static byte Decrypt(byte val, byte encKey)
        {
            val = (byte)(~val ^ encKey);
            return (byte)((val << 4) | (val >> 4));
        }
    }
}
