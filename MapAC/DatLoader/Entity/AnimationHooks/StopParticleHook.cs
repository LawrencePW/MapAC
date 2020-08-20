using System.IO;

namespace MapAC.DatLoader.Entity.AnimationHooks
{
    public class StopParticleHook : AnimationHook
    {
        public uint EmitterId { get; private set; }

        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);

            EmitterId = reader.ReadUInt32();
        }

        public override void Pack(BinaryWriter writer)
        {
            base.Pack(writer);
            writer.Write(EmitterId);
        }
    }
}
