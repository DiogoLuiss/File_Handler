using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulation.Utils
{
    internal class HandlingBinaryFiles
    {

        public void CreateFileBina(string AddressFile)
        {
            using (var FlowFile = new FileStream(AddressFile, FileMode.Create))
            using (var writer = new BinaryWriter(FlowFile))
            {

                for (int i = 0; i < 100; i++)
                {
                    writer.Write(i);
                }

            }
        }

        public void ReadBina(string AddressFile)
        {

            using (var FlowFile = new FileStream(AddressFile, FileMode.Open))
            using (var Reader = new BinaryReader(FlowFile))

                while (Reader.BaseStream.Position != Reader.BaseStream.Length)
                {
                    var teste1 = Reader.BaseStream.Position;
                    var teste = Reader.ReadInt32();
                    Console.WriteLine(teste);
                    Console.ReadKey();
                }
        }
    }

}
