// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: semantic.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.camera.traffic_light.tracker
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SemanticReviseParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SemanticReviseParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(1.5f)]
        public float revise_time_second
        {
            get { return __pbn__revise_time_second ?? 1.5f; }
            set { __pbn__revise_time_second = value; }
        }
        public bool ShouldSerializerevise_time_second()
        {
            return __pbn__revise_time_second != null;
        }
        public void Resetrevise_time_second()
        {
            __pbn__revise_time_second = null;
        }
        private float? __pbn__revise_time_second;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0.4f)]
        public float blink_threshold_second
        {
            get { return __pbn__blink_threshold_second ?? 0.4f; }
            set { __pbn__blink_threshold_second = value; }
        }
        public bool ShouldSerializeblink_threshold_second()
        {
            return __pbn__blink_threshold_second != null;
        }
        public void Resetblink_threshold_second()
        {
            __pbn__blink_threshold_second = null;
        }
        private float? __pbn__blink_threshold_second;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(2)]
        public int hysteretic_threshold_count
        {
            get { return __pbn__hysteretic_threshold_count ?? 2; }
            set { __pbn__hysteretic_threshold_count = value; }
        }
        public bool ShouldSerializehysteretic_threshold_count()
        {
            return __pbn__hysteretic_threshold_count != null;
        }
        public void Resethysteretic_threshold_count()
        {
            __pbn__hysteretic_threshold_count = null;
        }
        private int? __pbn__hysteretic_threshold_count;

    }

}

#pragma warning restore 0612, 1591, 3021
