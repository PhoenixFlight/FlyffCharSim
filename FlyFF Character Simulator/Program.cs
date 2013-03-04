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
        private static Dictionary<string, string> propItemText;
        private static Dictionary<string, string> propMoverText;
        private static Character player;
        static void Main()
        {
            Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private class ResFile
        {
            public string fileName;
            public byte[] content;
            public int offset;
        }
        private static void Init()
        {
            player = new Character();
            ResFile[] files = ReadRes("C:/Program Files/Gpotato/Flyff/dataSub2.res");
            propItemText = new Dictionary<string, string>();
            int i;
            for(i = 0; i < files.Length && !files[i].fileName.Equals("propItem.txt.txt"); i++);
            string output = Encoding.ASCII.GetString(files[i].content).Replace(Convert.ToChar(0x0).ToString(), "").Replace("??", "");
            string[] content = output.Split(new char[] { '\n' });
            for (int index = 0; index < content.Length; index ++)
            {
                string key = content[index].Substring(0, "IDS_PROPITEM_TXT_016364".Length).Trim();
                propItemText.Add(key, content[index].Substring(key.Length).Trim());
            }

            for (i = 0; i < files.Length && !files[i].fileName.Equals("Spec_Item.txt"); i++);
            output = Encoding.ASCII.GetString(files[i].content).Replace(Convert.ToChar(0x0).ToString(), "");
            content = output.Split(new char[] { '\n' });
            Equipment.allGear = new Dictionary<string, Equipment>();
            for (int index = 0; index < content.Length; index++)
            {
                string[] line = content[index].Split(new char[] { '\t' });
                if (line.Length < 20)
                    continue;
                if(!(line[5].Equals("IK1_WEAPON") || line[5].Equals("IK1_ARMOR") || line[6].Equals("IK2_JEWELRY")))
                    continue;
                Equipment eq = new Equipment();
                eq.id = line[1];
                eq.sid = line[2];
                eq.type = (Equipment.Type)(Enum.Parse(typeof(Equipment.Type), line[7]));
                eq.job = (FClass.Job)(Enum.Parse(typeof(FClass.Job), line[8]));
                eq.ultimate = line.Contains("WEAPON_ULTIMATE");

                Equipment.allGear.Add(eq.id, eq);
            }
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
