using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MapAC.DatLoader.Entity
{
    public class SoundTableData : IUnpackable
    {
        public uint SoundId; // Corresponds to the DatFileType.Wave
        public float Priority;
        public float Probability;
        public float Volume;

        public void Unpack(BinaryReader reader)
        {
            SoundId = reader.ReadUInt32();
            Priority = reader.ReadSingle();
            Probability = reader.ReadSingle();
            Volume = reader.ReadSingle();
        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(SoundId);
            writer.Write(Priority);
            writer.Write(Probability);
            writer.Write(Volume);
        }
    }
}
