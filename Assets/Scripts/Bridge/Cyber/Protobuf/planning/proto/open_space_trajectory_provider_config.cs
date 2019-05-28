// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: open_space_trajectory_provider_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class OpenSpaceTrajectoryProviderConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public OpenSpaceTrajectoryProviderConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public OpenSpaceTrajectoryOptimizerConfig open_space_trajectory_optimizer_config { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class OpenSpaceTrajectoryOptimizerConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public OpenSpaceTrajectoryOptimizerConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public HybridAStarConfig hybrid_a_star_config { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public DualVariableConfig dual_variable_warm_start_config { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public DistanceApproachTrajectorySmootherConfig distance_approach_trajectory_smoother_config { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0.5f)]
        public float delta_t
        {
            get { return __pbn__delta_t ?? 0.5f; }
            set { __pbn__delta_t = value; }
        }
        public bool ShouldSerializedelta_t()
        {
            return __pbn__delta_t != null;
        }
        public void Resetdelta_t()
        {
            __pbn__delta_t = null;
        }
        private float? __pbn__delta_t;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0.001)]
        public double is_near_destination_threshold
        {
            get { return __pbn__is_near_destination_threshold ?? 0.001; }
            set { __pbn__is_near_destination_threshold = value; }
        }
        public bool ShouldSerializeis_near_destination_threshold()
        {
            return __pbn__is_near_destination_threshold != null;
        }
        public void Resetis_near_destination_threshold()
        {
            __pbn__is_near_destination_threshold = null;
        }
        private double? __pbn__is_near_destination_threshold;

        [global::ProtoBuf.ProtoMember(6)]
        public PlannerOpenSpaceConfig planner_open_space_config { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class HybridAStarConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public HybridAStarConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(0.2)]
        public double xy_grid_resolution
        {
            get { return __pbn__xy_grid_resolution ?? 0.2; }
            set { __pbn__xy_grid_resolution = value; }
        }
        public bool ShouldSerializexy_grid_resolution()
        {
            return __pbn__xy_grid_resolution != null;
        }
        public void Resetxy_grid_resolution()
        {
            __pbn__xy_grid_resolution = null;
        }
        private double? __pbn__xy_grid_resolution;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0.05)]
        public double phi_grid_resolution
        {
            get { return __pbn__phi_grid_resolution ?? 0.05; }
            set { __pbn__phi_grid_resolution = value; }
        }
        public bool ShouldSerializephi_grid_resolution()
        {
            return __pbn__phi_grid_resolution != null;
        }
        public void Resetphi_grid_resolution()
        {
            __pbn__phi_grid_resolution = null;
        }
        private double? __pbn__phi_grid_resolution;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(10)]
        public ulong next_node_num
        {
            get { return __pbn__next_node_num ?? 10; }
            set { __pbn__next_node_num = value; }
        }
        public bool ShouldSerializenext_node_num()
        {
            return __pbn__next_node_num != null;
        }
        public void Resetnext_node_num()
        {
            __pbn__next_node_num = null;
        }
        private ulong? __pbn__next_node_num;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0.5)]
        public double step_size
        {
            get { return __pbn__step_size ?? 0.5; }
            set { __pbn__step_size = value; }
        }
        public bool ShouldSerializestep_size()
        {
            return __pbn__step_size != null;
        }
        public void Resetstep_size()
        {
            __pbn__step_size = null;
        }
        private double? __pbn__step_size;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double traj_forward_penalty
        {
            get { return __pbn__traj_forward_penalty ?? 0; }
            set { __pbn__traj_forward_penalty = value; }
        }
        public bool ShouldSerializetraj_forward_penalty()
        {
            return __pbn__traj_forward_penalty != null;
        }
        public void Resettraj_forward_penalty()
        {
            __pbn__traj_forward_penalty = null;
        }
        private double? __pbn__traj_forward_penalty;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double traj_back_penalty
        {
            get { return __pbn__traj_back_penalty ?? 0; }
            set { __pbn__traj_back_penalty = value; }
        }
        public bool ShouldSerializetraj_back_penalty()
        {
            return __pbn__traj_back_penalty != null;
        }
        public void Resettraj_back_penalty()
        {
            __pbn__traj_back_penalty = null;
        }
        private double? __pbn__traj_back_penalty;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(10)]
        public double traj_gear_switch_penalty
        {
            get { return __pbn__traj_gear_switch_penalty ?? 10; }
            set { __pbn__traj_gear_switch_penalty = value; }
        }
        public bool ShouldSerializetraj_gear_switch_penalty()
        {
            return __pbn__traj_gear_switch_penalty != null;
        }
        public void Resettraj_gear_switch_penalty()
        {
            __pbn__traj_gear_switch_penalty = null;
        }
        private double? __pbn__traj_gear_switch_penalty;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(100)]
        public double traj_steer_penalty
        {
            get { return __pbn__traj_steer_penalty ?? 100; }
            set { __pbn__traj_steer_penalty = value; }
        }
        public bool ShouldSerializetraj_steer_penalty()
        {
            return __pbn__traj_steer_penalty != null;
        }
        public void Resettraj_steer_penalty()
        {
            __pbn__traj_steer_penalty = null;
        }
        private double? __pbn__traj_steer_penalty;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(10)]
        public double traj_steer_change_penalty
        {
            get { return __pbn__traj_steer_change_penalty ?? 10; }
            set { __pbn__traj_steer_change_penalty = value; }
        }
        public bool ShouldSerializetraj_steer_change_penalty()
        {
            return __pbn__traj_steer_change_penalty != null;
        }
        public void Resettraj_steer_change_penalty()
        {
            __pbn__traj_steer_change_penalty = null;
        }
        private double? __pbn__traj_steer_change_penalty;

        [global::ProtoBuf.ProtoMember(15)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double grid_a_star_xy_resolution
        {
            get { return __pbn__grid_a_star_xy_resolution ?? 0.1; }
            set { __pbn__grid_a_star_xy_resolution = value; }
        }
        public bool ShouldSerializegrid_a_star_xy_resolution()
        {
            return __pbn__grid_a_star_xy_resolution != null;
        }
        public void Resetgrid_a_star_xy_resolution()
        {
            __pbn__grid_a_star_xy_resolution = null;
        }
        private double? __pbn__grid_a_star_xy_resolution;

        [global::ProtoBuf.ProtoMember(16)]
        [global::System.ComponentModel.DefaultValue(0.5)]
        public double node_radius
        {
            get { return __pbn__node_radius ?? 0.5; }
            set { __pbn__node_radius = value; }
        }
        public bool ShouldSerializenode_radius()
        {
            return __pbn__node_radius != null;
        }
        public void Resetnode_radius()
        {
            __pbn__node_radius = null;
        }
        private double? __pbn__node_radius;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DualVariableConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public DualVariableConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(1)]
        public double weight_d
        {
            get { return __pbn__weight_d ?? 1; }
            set { __pbn__weight_d = value; }
        }
        public bool ShouldSerializeweight_d()
        {
            return __pbn__weight_d != null;
        }
        public void Resetweight_d()
        {
            __pbn__weight_d = null;
        }
        private double? __pbn__weight_d;

        [global::ProtoBuf.ProtoMember(2)]
        public IpoptSolverConfig ipopt_config { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(DualVariableMode.DUAL_VARIABLE_IPOPT)]
        public DualVariableMode qp_format
        {
            get { return __pbn__qp_format ?? DualVariableMode.DUAL_VARIABLE_IPOPT; }
            set { __pbn__qp_format = value; }
        }
        public bool ShouldSerializeqp_format()
        {
            return __pbn__qp_format != null;
        }
        public void Resetqp_format()
        {
            __pbn__qp_format = null;
        }
        private DualVariableMode? __pbn__qp_format;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double min_safety_distance
        {
            get { return __pbn__min_safety_distance ?? 0; }
            set { __pbn__min_safety_distance = value; }
        }
        public bool ShouldSerializemin_safety_distance()
        {
            return __pbn__min_safety_distance != null;
        }
        public void Resetmin_safety_distance()
        {
            __pbn__min_safety_distance = null;
        }
        private double? __pbn__min_safety_distance;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DistanceApproachTrajectorySmootherConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public DistanceApproachTrajectorySmootherConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double weight_steer
        {
            get { return __pbn__weight_steer.GetValueOrDefault(); }
            set { __pbn__weight_steer = value; }
        }
        public bool ShouldSerializeweight_steer()
        {
            return __pbn__weight_steer != null;
        }
        public void Resetweight_steer()
        {
            __pbn__weight_steer = null;
        }
        private double? __pbn__weight_steer;

        [global::ProtoBuf.ProtoMember(2)]
        public double weight_a
        {
            get { return __pbn__weight_a.GetValueOrDefault(); }
            set { __pbn__weight_a = value; }
        }
        public bool ShouldSerializeweight_a()
        {
            return __pbn__weight_a != null;
        }
        public void Resetweight_a()
        {
            __pbn__weight_a = null;
        }
        private double? __pbn__weight_a;

        [global::ProtoBuf.ProtoMember(3)]
        public double weight_steer_rate
        {
            get { return __pbn__weight_steer_rate.GetValueOrDefault(); }
            set { __pbn__weight_steer_rate = value; }
        }
        public bool ShouldSerializeweight_steer_rate()
        {
            return __pbn__weight_steer_rate != null;
        }
        public void Resetweight_steer_rate()
        {
            __pbn__weight_steer_rate = null;
        }
        private double? __pbn__weight_steer_rate;

        [global::ProtoBuf.ProtoMember(4)]
        public double weight_a_rate
        {
            get { return __pbn__weight_a_rate.GetValueOrDefault(); }
            set { __pbn__weight_a_rate = value; }
        }
        public bool ShouldSerializeweight_a_rate()
        {
            return __pbn__weight_a_rate != null;
        }
        public void Resetweight_a_rate()
        {
            __pbn__weight_a_rate = null;
        }
        private double? __pbn__weight_a_rate;

        [global::ProtoBuf.ProtoMember(5)]
        public double weight_x
        {
            get { return __pbn__weight_x.GetValueOrDefault(); }
            set { __pbn__weight_x = value; }
        }
        public bool ShouldSerializeweight_x()
        {
            return __pbn__weight_x != null;
        }
        public void Resetweight_x()
        {
            __pbn__weight_x = null;
        }
        private double? __pbn__weight_x;

        [global::ProtoBuf.ProtoMember(6)]
        public double weight_y
        {
            get { return __pbn__weight_y.GetValueOrDefault(); }
            set { __pbn__weight_y = value; }
        }
        public bool ShouldSerializeweight_y()
        {
            return __pbn__weight_y != null;
        }
        public void Resetweight_y()
        {
            __pbn__weight_y = null;
        }
        private double? __pbn__weight_y;

        [global::ProtoBuf.ProtoMember(7)]
        public double weight_phi
        {
            get { return __pbn__weight_phi.GetValueOrDefault(); }
            set { __pbn__weight_phi = value; }
        }
        public bool ShouldSerializeweight_phi()
        {
            return __pbn__weight_phi != null;
        }
        public void Resetweight_phi()
        {
            __pbn__weight_phi = null;
        }
        private double? __pbn__weight_phi;

        [global::ProtoBuf.ProtoMember(8)]
        public double weight_v
        {
            get { return __pbn__weight_v.GetValueOrDefault(); }
            set { __pbn__weight_v = value; }
        }
        public bool ShouldSerializeweight_v()
        {
            return __pbn__weight_v != null;
        }
        public void Resetweight_v()
        {
            __pbn__weight_v = null;
        }
        private double? __pbn__weight_v;

        [global::ProtoBuf.ProtoMember(9)]
        public double weight_steer_stitching
        {
            get { return __pbn__weight_steer_stitching.GetValueOrDefault(); }
            set { __pbn__weight_steer_stitching = value; }
        }
        public bool ShouldSerializeweight_steer_stitching()
        {
            return __pbn__weight_steer_stitching != null;
        }
        public void Resetweight_steer_stitching()
        {
            __pbn__weight_steer_stitching = null;
        }
        private double? __pbn__weight_steer_stitching;

        [global::ProtoBuf.ProtoMember(10)]
        public double weight_a_stitching
        {
            get { return __pbn__weight_a_stitching.GetValueOrDefault(); }
            set { __pbn__weight_a_stitching = value; }
        }
        public bool ShouldSerializeweight_a_stitching()
        {
            return __pbn__weight_a_stitching != null;
        }
        public void Resetweight_a_stitching()
        {
            __pbn__weight_a_stitching = null;
        }
        private double? __pbn__weight_a_stitching;

        [global::ProtoBuf.ProtoMember(11)]
        public double weight_first_order_time
        {
            get { return __pbn__weight_first_order_time.GetValueOrDefault(); }
            set { __pbn__weight_first_order_time = value; }
        }
        public bool ShouldSerializeweight_first_order_time()
        {
            return __pbn__weight_first_order_time != null;
        }
        public void Resetweight_first_order_time()
        {
            __pbn__weight_first_order_time = null;
        }
        private double? __pbn__weight_first_order_time;

        [global::ProtoBuf.ProtoMember(12)]
        public double weight_second_order_time
        {
            get { return __pbn__weight_second_order_time.GetValueOrDefault(); }
            set { __pbn__weight_second_order_time = value; }
        }
        public bool ShouldSerializeweight_second_order_time()
        {
            return __pbn__weight_second_order_time != null;
        }
        public void Resetweight_second_order_time()
        {
            __pbn__weight_second_order_time = null;
        }
        private double? __pbn__weight_second_order_time;

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double min_safety_distance
        {
            get { return __pbn__min_safety_distance ?? 0; }
            set { __pbn__min_safety_distance = value; }
        }
        public bool ShouldSerializemin_safety_distance()
        {
            return __pbn__min_safety_distance != null;
        }
        public void Resetmin_safety_distance()
        {
            __pbn__min_safety_distance = null;
        }
        private double? __pbn__min_safety_distance;

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue(3)]
        public double max_speed_forward
        {
            get { return __pbn__max_speed_forward ?? 3; }
            set { __pbn__max_speed_forward = value; }
        }
        public bool ShouldSerializemax_speed_forward()
        {
            return __pbn__max_speed_forward != null;
        }
        public void Resetmax_speed_forward()
        {
            __pbn__max_speed_forward = null;
        }
        private double? __pbn__max_speed_forward;

        [global::ProtoBuf.ProtoMember(15)]
        [global::System.ComponentModel.DefaultValue(2)]
        public double max_speed_reverse
        {
            get { return __pbn__max_speed_reverse ?? 2; }
            set { __pbn__max_speed_reverse = value; }
        }
        public bool ShouldSerializemax_speed_reverse()
        {
            return __pbn__max_speed_reverse != null;
        }
        public void Resetmax_speed_reverse()
        {
            __pbn__max_speed_reverse = null;
        }
        private double? __pbn__max_speed_reverse;

        [global::ProtoBuf.ProtoMember(16)]
        [global::System.ComponentModel.DefaultValue(2)]
        public double max_acceleration_forward
        {
            get { return __pbn__max_acceleration_forward ?? 2; }
            set { __pbn__max_acceleration_forward = value; }
        }
        public bool ShouldSerializemax_acceleration_forward()
        {
            return __pbn__max_acceleration_forward != null;
        }
        public void Resetmax_acceleration_forward()
        {
            __pbn__max_acceleration_forward = null;
        }
        private double? __pbn__max_acceleration_forward;

        [global::ProtoBuf.ProtoMember(17)]
        [global::System.ComponentModel.DefaultValue(2)]
        public double max_acceleration_reverse
        {
            get { return __pbn__max_acceleration_reverse ?? 2; }
            set { __pbn__max_acceleration_reverse = value; }
        }
        public bool ShouldSerializemax_acceleration_reverse()
        {
            return __pbn__max_acceleration_reverse != null;
        }
        public void Resetmax_acceleration_reverse()
        {
            __pbn__max_acceleration_reverse = null;
        }
        private double? __pbn__max_acceleration_reverse;

        [global::ProtoBuf.ProtoMember(18)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double min_time_sample_scaling
        {
            get { return __pbn__min_time_sample_scaling ?? 0.1; }
            set { __pbn__min_time_sample_scaling = value; }
        }
        public bool ShouldSerializemin_time_sample_scaling()
        {
            return __pbn__min_time_sample_scaling != null;
        }
        public void Resetmin_time_sample_scaling()
        {
            __pbn__min_time_sample_scaling = null;
        }
        private double? __pbn__min_time_sample_scaling;

        [global::ProtoBuf.ProtoMember(19)]
        [global::System.ComponentModel.DefaultValue(10)]
        public double max_time_sample_scaling
        {
            get { return __pbn__max_time_sample_scaling ?? 10; }
            set { __pbn__max_time_sample_scaling = value; }
        }
        public bool ShouldSerializemax_time_sample_scaling()
        {
            return __pbn__max_time_sample_scaling != null;
        }
        public void Resetmax_time_sample_scaling()
        {
            __pbn__max_time_sample_scaling = null;
        }
        private double? __pbn__max_time_sample_scaling;

        [global::ProtoBuf.ProtoMember(20)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool use_fix_time
        {
            get { return __pbn__use_fix_time ?? false; }
            set { __pbn__use_fix_time = value; }
        }
        public bool ShouldSerializeuse_fix_time()
        {
            return __pbn__use_fix_time != null;
        }
        public void Resetuse_fix_time()
        {
            __pbn__use_fix_time = null;
        }
        private bool? __pbn__use_fix_time;

        [global::ProtoBuf.ProtoMember(21)]
        public IpoptSolverConfig ipopt_config { get; set; }

        [global::ProtoBuf.ProtoMember(22)]
        public bool enable_constraint_check
        {
            get { return __pbn__enable_constraint_check.GetValueOrDefault(); }
            set { __pbn__enable_constraint_check = value; }
        }
        public bool ShouldSerializeenable_constraint_check()
        {
            return __pbn__enable_constraint_check != null;
        }
        public void Resetenable_constraint_check()
        {
            __pbn__enable_constraint_check = null;
        }
        private bool? __pbn__enable_constraint_check;

        [global::ProtoBuf.ProtoMember(23)]
        public bool enable_hand_derivative
        {
            get { return __pbn__enable_hand_derivative.GetValueOrDefault(); }
            set { __pbn__enable_hand_derivative = value; }
        }
        public bool ShouldSerializeenable_hand_derivative()
        {
            return __pbn__enable_hand_derivative != null;
        }
        public void Resetenable_hand_derivative()
        {
            __pbn__enable_hand_derivative = null;
        }
        private bool? __pbn__enable_hand_derivative;

        [global::ProtoBuf.ProtoMember(24)]
        public bool enable_derivative_check
        {
            get { return __pbn__enable_derivative_check.GetValueOrDefault(); }
            set { __pbn__enable_derivative_check = value; }
        }
        public bool ShouldSerializeenable_derivative_check()
        {
            return __pbn__enable_derivative_check != null;
        }
        public void Resetenable_derivative_check()
        {
            __pbn__enable_derivative_check = null;
        }
        private bool? __pbn__enable_derivative_check;

        [global::ProtoBuf.ProtoMember(25)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool enable_initial_final_check
        {
            get { return __pbn__enable_initial_final_check ?? false; }
            set { __pbn__enable_initial_final_check = value; }
        }
        public bool ShouldSerializeenable_initial_final_check()
        {
            return __pbn__enable_initial_final_check != null;
        }
        public void Resetenable_initial_final_check()
        {
            __pbn__enable_initial_final_check = null;
        }
        private bool? __pbn__enable_initial_final_check;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class IpoptSolverConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public IpoptSolverConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public int ipopt_print_level
        {
            get { return __pbn__ipopt_print_level.GetValueOrDefault(); }
            set { __pbn__ipopt_print_level = value; }
        }
        public bool ShouldSerializeipopt_print_level()
        {
            return __pbn__ipopt_print_level != null;
        }
        public void Resetipopt_print_level()
        {
            __pbn__ipopt_print_level = null;
        }
        private int? __pbn__ipopt_print_level;

        [global::ProtoBuf.ProtoMember(2)]
        public int mumps_mem_percent
        {
            get { return __pbn__mumps_mem_percent.GetValueOrDefault(); }
            set { __pbn__mumps_mem_percent = value; }
        }
        public bool ShouldSerializemumps_mem_percent()
        {
            return __pbn__mumps_mem_percent != null;
        }
        public void Resetmumps_mem_percent()
        {
            __pbn__mumps_mem_percent = null;
        }
        private int? __pbn__mumps_mem_percent;

        [global::ProtoBuf.ProtoMember(3)]
        public double mumps_pivtol
        {
            get { return __pbn__mumps_pivtol.GetValueOrDefault(); }
            set { __pbn__mumps_pivtol = value; }
        }
        public bool ShouldSerializemumps_pivtol()
        {
            return __pbn__mumps_pivtol != null;
        }
        public void Resetmumps_pivtol()
        {
            __pbn__mumps_pivtol = null;
        }
        private double? __pbn__mumps_pivtol;

        [global::ProtoBuf.ProtoMember(4)]
        public int ipopt_max_iter
        {
            get { return __pbn__ipopt_max_iter.GetValueOrDefault(); }
            set { __pbn__ipopt_max_iter = value; }
        }
        public bool ShouldSerializeipopt_max_iter()
        {
            return __pbn__ipopt_max_iter != null;
        }
        public void Resetipopt_max_iter()
        {
            __pbn__ipopt_max_iter = null;
        }
        private int? __pbn__ipopt_max_iter;

        [global::ProtoBuf.ProtoMember(5)]
        public double ipopt_tol
        {
            get { return __pbn__ipopt_tol.GetValueOrDefault(); }
            set { __pbn__ipopt_tol = value; }
        }
        public bool ShouldSerializeipopt_tol()
        {
            return __pbn__ipopt_tol != null;
        }
        public void Resetipopt_tol()
        {
            __pbn__ipopt_tol = null;
        }
        private double? __pbn__ipopt_tol;

        [global::ProtoBuf.ProtoMember(6)]
        public double ipopt_acceptable_constr_viol_tol
        {
            get { return __pbn__ipopt_acceptable_constr_viol_tol.GetValueOrDefault(); }
            set { __pbn__ipopt_acceptable_constr_viol_tol = value; }
        }
        public bool ShouldSerializeipopt_acceptable_constr_viol_tol()
        {
            return __pbn__ipopt_acceptable_constr_viol_tol != null;
        }
        public void Resetipopt_acceptable_constr_viol_tol()
        {
            __pbn__ipopt_acceptable_constr_viol_tol = null;
        }
        private double? __pbn__ipopt_acceptable_constr_viol_tol;

        [global::ProtoBuf.ProtoMember(7)]
        public double ipopt_min_hessian_perturbation
        {
            get { return __pbn__ipopt_min_hessian_perturbation.GetValueOrDefault(); }
            set { __pbn__ipopt_min_hessian_perturbation = value; }
        }
        public bool ShouldSerializeipopt_min_hessian_perturbation()
        {
            return __pbn__ipopt_min_hessian_perturbation != null;
        }
        public void Resetipopt_min_hessian_perturbation()
        {
            __pbn__ipopt_min_hessian_perturbation = null;
        }
        private double? __pbn__ipopt_min_hessian_perturbation;

        [global::ProtoBuf.ProtoMember(8)]
        public double ipopt_jacobian_regularization_value
        {
            get { return __pbn__ipopt_jacobian_regularization_value.GetValueOrDefault(); }
            set { __pbn__ipopt_jacobian_regularization_value = value; }
        }
        public bool ShouldSerializeipopt_jacobian_regularization_value()
        {
            return __pbn__ipopt_jacobian_regularization_value != null;
        }
        public void Resetipopt_jacobian_regularization_value()
        {
            __pbn__ipopt_jacobian_regularization_value = null;
        }
        private double? __pbn__ipopt_jacobian_regularization_value;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ipopt_print_timing_statistics
        {
            get { return __pbn__ipopt_print_timing_statistics ?? ""; }
            set { __pbn__ipopt_print_timing_statistics = value; }
        }
        public bool ShouldSerializeipopt_print_timing_statistics()
        {
            return __pbn__ipopt_print_timing_statistics != null;
        }
        public void Resetipopt_print_timing_statistics()
        {
            __pbn__ipopt_print_timing_statistics = null;
        }
        private string __pbn__ipopt_print_timing_statistics;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ipopt_alpha_for_y
        {
            get { return __pbn__ipopt_alpha_for_y ?? ""; }
            set { __pbn__ipopt_alpha_for_y = value; }
        }
        public bool ShouldSerializeipopt_alpha_for_y()
        {
            return __pbn__ipopt_alpha_for_y != null;
        }
        public void Resetipopt_alpha_for_y()
        {
            __pbn__ipopt_alpha_for_y = null;
        }
        private string __pbn__ipopt_alpha_for_y;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ipopt_recalc_y
        {
            get { return __pbn__ipopt_recalc_y ?? ""; }
            set { __pbn__ipopt_recalc_y = value; }
        }
        public bool ShouldSerializeipopt_recalc_y()
        {
            return __pbn__ipopt_recalc_y != null;
        }
        public void Resetipopt_recalc_y()
        {
            __pbn__ipopt_recalc_y = null;
        }
        private string __pbn__ipopt_recalc_y;

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double ipopt_mu_init
        {
            get { return __pbn__ipopt_mu_init ?? 0.1; }
            set { __pbn__ipopt_mu_init = value; }
        }
        public bool ShouldSerializeipopt_mu_init()
        {
            return __pbn__ipopt_mu_init != null;
        }
        public void Resetipopt_mu_init()
        {
            __pbn__ipopt_mu_init = null;
        }
        private double? __pbn__ipopt_mu_init;

    }

    [global::ProtoBuf.ProtoContract()]
    public enum DualVariableMode
    {
        DUAL_VARIABLE_IPOPT = 0,
        DUAL_VARIABLE_IPOPTQP = 1,
        DUAL_VARIABLE_OSQP = 2,
        DUAL_VARIABLE_DEBUG = 3,
    }

}

#pragma warning restore 0612, 1591, 3021
