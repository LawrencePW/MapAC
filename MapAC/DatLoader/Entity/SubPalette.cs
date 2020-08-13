using System.IO;

namespace MapAC.DatLoader.Entity
{
    // TODO: refactor to use existing PaletteOverride object
    public class SubPalette : IUnpackable
    {
        public uint SubID { get; set; }
        public uint Offset { get; set; }
        public uint NumColors { get; set; }

        public void Unpack(BinaryReader reader)
        {
            SubID       = reader.ReadAsDataIDOfKnownType(0x04000000);
            Offset      = (uint)(reader.ReadByte() * 8);
            NumColors   = reader.ReadByte();

            if (NumColors == 0)
                NumColors = 256;

            NumColors *= 8;
        }

        public void Pack(BinaryWriter writer)
        {
            writer.WriteAsDataIDOfKnownType(SubID, 0x04000000);
            writer.Write(Offset / 8);

            var colors = NumColors / 8;
            if (colors == 256) colors = 0;
            writer.Write(colors);
        }

    }
}
