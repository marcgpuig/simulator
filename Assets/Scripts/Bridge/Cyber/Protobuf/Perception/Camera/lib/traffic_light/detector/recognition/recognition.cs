// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: recognition.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.camera.traffic_light.recognition
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ClassifyParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ClassifyParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string model_name
        {
            get { return __pbn__model_name ?? ""; }
            set { __pbn__model_name = value; }
        }
        public bool ShouldSerializemodel_name()
        {
            return __pbn__model_name != null;
        }
        public void Resetmodel_name()
        {
            __pbn__model_name = null;
        }
        private string __pbn__model_name;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(@"CaffeNet")]
        public string model_type
        {
            get { return __pbn__model_type ?? @"CaffeNet"; }
            set { __pbn__model_type = value; }
        }
        public bool ShouldSerializemodel_type()
        {
            return __pbn__model_type != null;
        }
        public void Resetmodel_type()
        {
            __pbn__model_type = null;
        }
        private string __pbn__model_type;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string input_blob
        {
            get { return __pbn__input_blob ?? ""; }
            set { __pbn__input_blob = value; }
        }
        public bool ShouldSerializeinput_blob()
        {
            return __pbn__input_blob != null;
        }
        public void Resetinput_blob()
        {
            __pbn__input_blob = null;
        }
        private string __pbn__input_blob;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string output_blob
        {
            get { return __pbn__output_blob ?? ""; }
            set { __pbn__output_blob = value; }
        }
        public bool ShouldSerializeoutput_blob()
        {
            return __pbn__output_blob != null;
        }
        public void Resetoutput_blob()
        {
            __pbn__output_blob = null;
        }
        private string __pbn__output_blob;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string weight_file
        {
            get { return __pbn__weight_file ?? ""; }
            set { __pbn__weight_file = value; }
        }
        public bool ShouldSerializeweight_file()
        {
            return __pbn__weight_file != null;
        }
        public void Resetweight_file()
        {
            __pbn__weight_file = null;
        }
        private string __pbn__weight_file;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string proto_file
        {
            get { return __pbn__proto_file ?? ""; }
            set { __pbn__proto_file = value; }
        }
        public bool ShouldSerializeproto_file()
        {
            return __pbn__proto_file != null;
        }
        public void Resetproto_file()
        {
            __pbn__proto_file = null;
        }
        private string __pbn__proto_file;

        [global::ProtoBuf.ProtoMember(7)]
        public float classify_threshold
        {
            get { return __pbn__classify_threshold.GetValueOrDefault(); }
            set { __pbn__classify_threshold = value; }
        }
        public bool ShouldSerializeclassify_threshold()
        {
            return __pbn__classify_threshold != null;
        }
        public void Resetclassify_threshold()
        {
            __pbn__classify_threshold = null;
        }
        private float? __pbn__classify_threshold;

        [global::ProtoBuf.ProtoMember(8)]
        public int classify_resize_width
        {
            get { return __pbn__classify_resize_width.GetValueOrDefault(); }
            set { __pbn__classify_resize_width = value; }
        }
        public bool ShouldSerializeclassify_resize_width()
        {
            return __pbn__classify_resize_width != null;
        }
        public void Resetclassify_resize_width()
        {
            __pbn__classify_resize_width = null;
        }
        private int? __pbn__classify_resize_width;

        [global::ProtoBuf.ProtoMember(9)]
        public int classify_resize_height
        {
            get { return __pbn__classify_resize_height.GetValueOrDefault(); }
            set { __pbn__classify_resize_height = value; }
        }
        public bool ShouldSerializeclassify_resize_height()
        {
            return __pbn__classify_resize_height != null;
        }
        public void Resetclassify_resize_height()
        {
            __pbn__classify_resize_height = null;
        }
        private int? __pbn__classify_resize_height;

        [global::ProtoBuf.ProtoMember(10)]
        public float scale
        {
            get { return __pbn__scale.GetValueOrDefault(); }
            set { __pbn__scale = value; }
        }
        public bool ShouldSerializescale()
        {
            return __pbn__scale != null;
        }
        public void Resetscale()
        {
            __pbn__scale = null;
        }
        private float? __pbn__scale;

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue(95f)]
        public float mean_b
        {
            get { return __pbn__mean_b ?? 95f; }
            set { __pbn__mean_b = value; }
        }
        public bool ShouldSerializemean_b()
        {
            return __pbn__mean_b != null;
        }
        public void Resetmean_b()
        {
            __pbn__mean_b = null;
        }
        private float? __pbn__mean_b;

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue(99f)]
        public float mean_g
        {
            get { return __pbn__mean_g ?? 99f; }
            set { __pbn__mean_g = value; }
        }
        public bool ShouldSerializemean_g()
        {
            return __pbn__mean_g != null;
        }
        public void Resetmean_g()
        {
            __pbn__mean_g = null;
        }
        private float? __pbn__mean_g;

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue(96f)]
        public float mean_r
        {
            get { return __pbn__mean_r ?? 96f; }
            set { __pbn__mean_r = value; }
        }
        public bool ShouldSerializemean_r()
        {
            return __pbn__mean_r != null;
        }
        public void Resetmean_r()
        {
            __pbn__mean_r = null;
        }
        private float? __pbn__mean_r;

        [global::ProtoBuf.ProtoMember(15)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool is_bgr
        {
            get { return __pbn__is_bgr ?? true; }
            set { __pbn__is_bgr = value; }
        }
        public bool ShouldSerializeis_bgr()
        {
            return __pbn__is_bgr != null;
        }
        public void Resetis_bgr()
        {
            __pbn__is_bgr = null;
        }
        private bool? __pbn__is_bgr;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RecognizeBoxParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public RecognizeBoxParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public ClassifyParam vertical_model { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public ClassifyParam quadrate_model { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public ClassifyParam horizontal_model { get; set; }

    }

}

#pragma warning restore 0612, 1591, 3021
