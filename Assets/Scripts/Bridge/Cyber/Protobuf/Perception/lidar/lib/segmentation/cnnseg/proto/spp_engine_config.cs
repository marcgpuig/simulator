// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: spp_engine_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.lidar
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SppEngineConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SppEngineConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(0.5f)]
        public float height_gap
        {
            get { return __pbn__height_gap ?? 0.5f; }
            set { __pbn__height_gap = value; }
        }
        public bool ShouldSerializeheight_gap()
        {
            return __pbn__height_gap != null;
        }
        public void Resetheight_gap()
        {
            __pbn__height_gap = null;
        }
        private float? __pbn__height_gap;

    }

}

#pragma warning restore 0612, 1591, 3021
