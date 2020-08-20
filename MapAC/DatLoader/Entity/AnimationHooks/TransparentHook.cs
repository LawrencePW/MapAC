using System.IO;

namespace MapAC.DatLoader.Entity.AnimationHooks
{
    public class TransparentHook : AnimationHook
    {
        public float Start { get; private set; }
        public float End { get; private set; }
        public float Time { get; private set; }

        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);

            Start   = reader.ReadSingle();
            End     = reader.ReadSingle();
            Time    = reader.ReadSingle();
        }

        public override void Pack(BinaryWriter writer)
        {
            base.Pack(writer);
            writer.Write(Start);
            writer.Write(End);
            writer.Write(Time);
        }
    }
}
