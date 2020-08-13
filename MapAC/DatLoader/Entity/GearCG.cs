using System.IO;

namespace MapAC.DatLoader.Entity
{
    public class GearCG : IUnpackable
    {
        public string Name { get; private set; }
        public uint ClothingTable { get; private set; }
        public uint WeenieDefault { get; private set; }

        public void Unpack(BinaryReader reader)
        {
            Name            = reader.ReadString();
            ClothingTable   = reader.ReadUInt32();
            WeenieDefault   = reader.ReadUInt32();
        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Name);
            writer.Write(ClothingTable);
            writer.Write(WeenieDefault);
        }

    }
}
