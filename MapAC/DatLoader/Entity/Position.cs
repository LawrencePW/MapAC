using System.IO;

namespace MapAC.DatLoader.Entity
{
    /// <summary>
    /// Position consists of a CellID + a Frame (Origin + Orientation)
    /// </summary>
    public class Position : IUnpackable
    {
        public uint ObjCellID { get; private set; }

        public Frame Frame = new Frame();

        public void Unpack(BinaryReader reader)
        {
            ObjCellID = reader.ReadUInt32();

            Frame.Unpack(reader);
        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(ObjCellID);

            Frame.Pack(writer);
        }

    }
}
