using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace MapAC.DatLoader.Entity
{
    /// <summary>
    /// A vertex position, normal, and texture coords
    /// </summary>
    public class SWVertex : IUnpackable
    {
        public Vector3 Origin { get; private set; }
        public Vector3 Normal { get; private set; }

        public List<Vec2Duv> UVs { get; private set; }

        public void Unpack(BinaryReader reader)
        {
            var numUVs = reader.ReadUInt16();
            UVs = new List<Vec2Duv>(numUVs);

            Origin = reader.ReadVector3();
            Normal = reader.ReadVector3();

            UVs.Unpack(reader, numUVs);
        }

        public void Pack(BinaryWriter writer)
        {
            writer.Write((ushort)UVs.Count);

            writer.WriteVector3(Origin);
            writer.WriteVector3(Normal);

            for (var i = 0; i < UVs.Count; i++)
                UVs[i].Pack(writer);

        }

    }
}
