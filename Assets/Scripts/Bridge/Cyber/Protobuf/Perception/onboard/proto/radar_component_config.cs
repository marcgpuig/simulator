// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: radar_component_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.onboard
{

    [global::ProtoBuf.ProtoContract()]
    public partial class RadarComponentConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public RadarComponentConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string radar_name
        {
            get { return __pbn__radar_name ?? ""; }
            set { __pbn__radar_name = value; }
        }
        public bool ShouldSerializeradar_name()
        {
            return __pbn__radar_name != null;
        }
        public void Resetradar_name()
        {
            __pbn__radar_name = null;
        }
        private string __pbn__radar_name;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string tf_child_frame_id
        {
            get { return __pbn__tf_child_frame_id ?? ""; }
            set { __pbn__tf_child_frame_id = value; }
        }
        public bool ShouldSerializetf_child_frame_id()
        {
            return __pbn__tf_child_frame_id != null;
        }
        public void Resettf_child_frame_id()
        {
            __pbn__tf_child_frame_id = null;
        }
        private string __pbn__tf_child_frame_id;

        [global::ProtoBuf.ProtoMember(3)]
        public double radar_forward_distance
        {
            get { return __pbn__radar_forward_distance.GetValueOrDefault(); }
            set { __pbn__radar_forward_distance = value; }
        }
        public bool ShouldSerializeradar_forward_distance()
        {
            return __pbn__radar_forward_distance != null;
        }
        public void Resetradar_forward_distance()
        {
            __pbn__radar_forward_distance = null;
        }
        private double? __pbn__radar_forward_distance;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string radar_preprocessor_method
        {
            get { return __pbn__radar_preprocessor_method ?? ""; }
            set { __pbn__radar_preprocessor_method = value; }
        }
        public bool ShouldSerializeradar_preprocessor_method()
        {
            return __pbn__radar_preprocessor_method != null;
        }
        public void Resetradar_preprocessor_method()
        {
            __pbn__radar_preprocessor_method = null;
        }
        private string __pbn__radar_preprocessor_method;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string radar_perception_method
        {
            get { return __pbn__radar_perception_method ?? ""; }
            set { __pbn__radar_perception_method = value; }
        }
        public bool ShouldSerializeradar_perception_method()
        {
            return __pbn__radar_perception_method != null;
        }
        public void Resetradar_perception_method()
        {
            __pbn__radar_perception_method = null;
        }
        private string __pbn__radar_perception_method;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string radar_pipeline_name
        {
            get { return __pbn__radar_pipeline_name ?? ""; }
            set { __pbn__radar_pipeline_name = value; }
        }
        public bool ShouldSerializeradar_pipeline_name()
        {
            return __pbn__radar_pipeline_name != null;
        }
        public void Resetradar_pipeline_name()
        {
            __pbn__radar_pipeline_name = null;
        }
        private string __pbn__radar_pipeline_name;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string odometry_channel_name
        {
            get { return __pbn__odometry_channel_name ?? ""; }
            set { __pbn__odometry_channel_name = value; }
        }
        public bool ShouldSerializeodometry_channel_name()
        {
            return __pbn__odometry_channel_name != null;
        }
        public void Resetodometry_channel_name()
        {
            __pbn__odometry_channel_name = null;
        }
        private string __pbn__odometry_channel_name;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue("")]
        public string output_channel_name
        {
            get { return __pbn__output_channel_name ?? ""; }
            set { __pbn__output_channel_name = value; }
        }
        public bool ShouldSerializeoutput_channel_name()
        {
            return __pbn__output_channel_name != null;
        }
        public void Resetoutput_channel_name()
        {
            __pbn__output_channel_name = null;
        }
        private string __pbn__output_channel_name;

    }

}

#pragma warning restore 0612, 1591, 3021
