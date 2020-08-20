using System.IO;

namespace MapAC.DatLoader.Entity.AnimationHooks
{
    public class TextureVelocityHook : AnimationHook
    {
        public float USpeed { get; private set; }
        public float VSpeed { get; private set; }

        public override void Unpack(BinaryReader reader)
        {
            base.Unpack(reader);

            USpeed = reader.ReadSingle();
            VSpeed = reader.ReadSingle();
        }

        public override void Pack(BinaryWriter writer)
        {
            base.Pack(writer);
            writer.Write(USpeed);
            writer.Write(VSpeed);
        }
    }
}
