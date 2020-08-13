using System.IO;

namespace MapAC.DatLoader.Entity
{
    public class AmbientSoundDesc : IUnpackable
    {
        public uint SType { get; private set; }
        public float Volume { get; private set; }
        public float BaseChance { get; private set; }
        public float MinRate { get; private set; }
        public float MaxRate { get; private set; }

        public void Unpack(BinaryReader reader)
        {
            SType = reader.ReadUInt32();
            Volume = reader.ReadSingle();
            BaseChance = reader.ReadSingle();
            MinRate = reader.ReadSingle();
            MaxRate = reader.ReadSingle();
        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(SType);
            writer.Write(Volume);
            writer.Write(BaseChance);
            writer.Write(MinRate);
            writer.Write(MaxRate);
        }

        public bool IsContinuous => (BaseChance == 0);
    }
}
