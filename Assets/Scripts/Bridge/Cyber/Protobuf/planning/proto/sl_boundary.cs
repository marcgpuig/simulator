// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: sl_boundary.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SLBoundary : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SLBoundary()
        {
            boundary_point = new global::System.Collections.Generic.List<global::apollo.common.SLPoint>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double start_s
        {
            get { return __pbn__start_s.GetValueOrDefault(); }
            set { __pbn__start_s = value; }
        }
        public bool ShouldSerializestart_s()
        {
            return __pbn__start_s != null;
        }
        public void Resetstart_s()
        {
            __pbn__start_s = null;
        }
        private double? __pbn__start_s;

        [global::ProtoBuf.ProtoMember(2)]
        public double end_s
        {
            get { return __pbn__end_s.GetValueOrDefault(); }
            set { __pbn__end_s = value; }
        }
        public bool ShouldSerializeend_s()
        {
            return __pbn__end_s != null;
        }
        public void Resetend_s()
        {
            __pbn__end_s = null;
        }
        private double? __pbn__end_s;

        [global::ProtoBuf.ProtoMember(3)]
        public double start_l
        {
            get { return __pbn__start_l.GetValueOrDefault(); }
            set { __pbn__start_l = value; }
        }
        public bool ShouldSerializestart_l()
        {
            return __pbn__start_l != null;
        }
        public void Resetstart_l()
        {
            __pbn__start_l = null;
        }
        private double? __pbn__start_l;

        [global::ProtoBuf.ProtoMember(4)]
        public double end_l
        {
            get { return __pbn__end_l.GetValueOrDefault(); }
            set { __pbn__end_l = value; }
        }
        public bool ShouldSerializeend_l()
        {
            return __pbn__end_l != null;
        }
        public void Resetend_l()
        {
            __pbn__end_l = null;
        }
        private double? __pbn__end_l;

        [global::ProtoBuf.ProtoMember(5)]
        public global::System.Collections.Generic.List<global::apollo.common.SLPoint> boundary_point { get; private set; }

    }

}

#pragma warning restore 0612, 1591, 3021
