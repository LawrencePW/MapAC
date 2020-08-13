using System.Collections.Generic;
using System.IO;

namespace MapAC.DatLoader.Entity
{
    public class CloSubPalEffect : IUnpackable
    {
        /// <summary>
        /// Icon portal.dat 0x06000000
        /// </summary>
        public uint Icon { get; private set; }
        public List<CloSubPalette> CloSubPalettes { get; } = new List<CloSubPalette>();

        public void Unpack(BinaryReader reader)
        {
            Icon = reader.ReadUInt32();

            CloSubPalettes.Unpack(reader);
        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write(Icon);

            CloSubPalettes.Pack(writer);
        }

    }
}