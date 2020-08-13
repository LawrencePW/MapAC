using System.IO;

namespace MapAC.DatLoader.Entity
{
    public class AnimationPartChange : IUnpackable
    {
        public byte PartIndex { get; set; }
        public uint PartID { get; set; }

        public void Unpack(BinaryReader reader)
        {
            PartIndex = reader.ReadByte();
            PartID    = reader.ReadAsDataIDOfKnownType(0x01000000);
        }

        public void Unpack(BinaryReader reader, ushort partIndex)
        {
            PartIndex = (byte)(partIndex & 255);
            PartID    = reader.ReadAsDataIDOfKnownType(0x01000000);
        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(PartIndex);
            writer.WriteAsDataIDOfKnownType(PartID, 0x01000000);
        }

        public void Pack(BinaryWriter writer, ushort partIndex)
        {
            PartIndex = (byte)(partIndex & 255);
            writer.WriteAsDataIDOfKnownType(PartID, 0x01000000);
        }

    }
}
