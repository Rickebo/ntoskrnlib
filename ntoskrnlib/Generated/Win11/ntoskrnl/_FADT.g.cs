#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 276)]
    public partial struct _FADT
    {
        [FieldOffset(0)]
        public _DESCRIPTION_HEADER Header;
        [FieldOffset(36)]
        public uint facs;
        [FieldOffset(40)]
        public uint dsdt;
        [FieldOffset(44)]
        public byte int_model;
        [FieldOffset(45)]
        public byte pm_profile;
        [FieldOffset(46)]
        public ushort sci_int_vector;
        [FieldOffset(48)]
        public uint smi_cmd_io_port;
        [FieldOffset(52)]
        public byte acpi_on_value;
        [FieldOffset(53)]
        public byte acpi_off_value;
        [FieldOffset(54)]
        public byte s4bios_req;
        [FieldOffset(55)]
        public byte pstate_control;
        [FieldOffset(56)]
        public uint pm1a_evt_blk_io_port;
        [FieldOffset(60)]
        public uint pm1b_evt_blk_io_port;
        [FieldOffset(64)]
        public uint pm1a_ctrl_blk_io_port;
        [FieldOffset(68)]
        public uint pm1b_ctrl_blk_io_port;
        [FieldOffset(72)]
        public uint pm2_ctrl_blk_io_port;
        [FieldOffset(76)]
        public uint pm_tmr_blk_io_port;
        [FieldOffset(80)]
        public uint gp0_blk_io_port;
        [FieldOffset(84)]
        public uint gp1_blk_io_port;
        [FieldOffset(88)]
        public byte pm1_evt_len;
        [FieldOffset(89)]
        public byte pm1_ctrl_len;
        [FieldOffset(90)]
        public byte pm2_ctrl_len;
        [FieldOffset(91)]
        public byte pm_tmr_len;
        [FieldOffset(92)]
        public byte gp0_blk_len;
        [FieldOffset(93)]
        public byte gp1_blk_len;
        [FieldOffset(94)]
        public byte gp1_base;
        [FieldOffset(95)]
        public byte cstate_control;
        [FieldOffset(96)]
        public ushort lvl2_latency;
        [FieldOffset(98)]
        public ushort lvl3_latency;
        [FieldOffset(100)]
        public ushort flush_size;
        [FieldOffset(102)]
        public ushort flush_stride;
        [FieldOffset(104)]
        public byte duty_offset;
        [FieldOffset(105)]
        public byte duty_width;
        [FieldOffset(106)]
        public byte day_alarm_index;
        [FieldOffset(107)]
        public byte month_alarm_index;
        [FieldOffset(108)]
        public byte century_alarm_index;
        [FieldOffset(109)]
        public ushort boot_arch;
        [FieldOffset(111)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] reserved3;
        [FieldOffset(112)]
        public uint flags;
        [FieldOffset(116)]
        public _GEN_ADDR reset_reg;
        [FieldOffset(128)]
        public byte reset_val;
        [FieldOffset(129)]
        public ushort arm_boot_arch;
        [FieldOffset(131)]
        public byte minor_version_number;
        [FieldOffset(132)]
        public _LARGE_INTEGER x_firmware_ctrl;
        [FieldOffset(140)]
        public _LARGE_INTEGER x_dsdt;
        [FieldOffset(148)]
        public _GEN_ADDR x_pm1a_evt_blk;
        [FieldOffset(160)]
        public _GEN_ADDR x_pm1b_evt_blk;
        [FieldOffset(172)]
        public _GEN_ADDR x_pm1a_ctrl_blk;
        [FieldOffset(184)]
        public _GEN_ADDR x_pm1b_ctrl_blk;
        [FieldOffset(196)]
        public _GEN_ADDR x_pm2_ctrl_blk;
        [FieldOffset(208)]
        public _GEN_ADDR x_pm_tmr_blk;
        [FieldOffset(220)]
        public _GEN_ADDR x_gp0_blk;
        [FieldOffset(232)]
        public _GEN_ADDR x_gp1_blk;
        [FieldOffset(244)]
        public _GEN_ADDR sleep_control_reg;
        [FieldOffset(256)]
        public _GEN_ADDR sleep_status_reg;
        [FieldOffset(268)]
        public ulong hypervisor_vendor_identity;
    }
}