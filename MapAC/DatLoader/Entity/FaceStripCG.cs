using System.IO;

namespace MapAC.DatLoader.Entity
{
    public class FaceStripCG : IUnpackable
    {
        public uint IconImage { get; private set; }
        public ObjDesc ObjDesc { get; } = new ObjDesc();

        public void Unpack(BinaryReader reader)
        {
            IconImage = reader.ReadUInt32();

            ObjDesc.Unpack(reader);
        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(IconImage);

            ObjDesc.Pack(writer);
        }

    }
}
