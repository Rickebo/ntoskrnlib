using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FADT")]
    public sealed class Fadt : DynamicStructure
    {
        [Offset(0UL)]
        public DescriptionHeader Header { get => ReadStructure<DescriptionHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(36UL)]
        public uint facs { get => ReadHere<uint>(nameof(facs)); set => WriteHere(nameof(facs), value); }

        [Offset(40UL)]
        public uint dsdt { get => ReadHere<uint>(nameof(dsdt)); set => WriteHere(nameof(dsdt), value); }

        [Offset(44UL)]
        public byte int_model { get => ReadHere<byte>(nameof(int_model)); set => WriteHere(nameof(int_model), value); }

        [Offset(45UL)]
        public byte pm_profile { get => ReadHere<byte>(nameof(pm_profile)); set => WriteHere(nameof(pm_profile), value); }

        [Offset(46UL)]
        public ushort sci_int_vector { get => ReadHere<ushort>(nameof(sci_int_vector)); set => WriteHere(nameof(sci_int_vector), value); }

        [Offset(48UL)]
        public uint smi_cmd_io_port { get => ReadHere<uint>(nameof(smi_cmd_io_port)); set => WriteHere(nameof(smi_cmd_io_port), value); }

        [Offset(52UL)]
        public byte acpi_on_value { get => ReadHere<byte>(nameof(acpi_on_value)); set => WriteHere(nameof(acpi_on_value), value); }

        [Offset(53UL)]
        public byte acpi_off_value { get => ReadHere<byte>(nameof(acpi_off_value)); set => WriteHere(nameof(acpi_off_value), value); }

        [Offset(54UL)]
        public byte s4bios_req { get => ReadHere<byte>(nameof(s4bios_req)); set => WriteHere(nameof(s4bios_req), value); }

        [Offset(55UL)]
        public byte pstate_control { get => ReadHere<byte>(nameof(pstate_control)); set => WriteHere(nameof(pstate_control), value); }

        [Offset(56UL)]
        public uint pm1a_evt_blk_io_port { get => ReadHere<uint>(nameof(pm1a_evt_blk_io_port)); set => WriteHere(nameof(pm1a_evt_blk_io_port), value); }

        [Offset(60UL)]
        public uint pm1b_evt_blk_io_port { get => ReadHere<uint>(nameof(pm1b_evt_blk_io_port)); set => WriteHere(nameof(pm1b_evt_blk_io_port), value); }

        [Offset(64UL)]
        public uint pm1a_ctrl_blk_io_port { get => ReadHere<uint>(nameof(pm1a_ctrl_blk_io_port)); set => WriteHere(nameof(pm1a_ctrl_blk_io_port), value); }

        [Offset(68UL)]
        public uint pm1b_ctrl_blk_io_port { get => ReadHere<uint>(nameof(pm1b_ctrl_blk_io_port)); set => WriteHere(nameof(pm1b_ctrl_blk_io_port), value); }

        [Offset(72UL)]
        public uint pm2_ctrl_blk_io_port { get => ReadHere<uint>(nameof(pm2_ctrl_blk_io_port)); set => WriteHere(nameof(pm2_ctrl_blk_io_port), value); }

        [Offset(76UL)]
        public uint pm_tmr_blk_io_port { get => ReadHere<uint>(nameof(pm_tmr_blk_io_port)); set => WriteHere(nameof(pm_tmr_blk_io_port), value); }

        [Offset(80UL)]
        public uint gp0_blk_io_port { get => ReadHere<uint>(nameof(gp0_blk_io_port)); set => WriteHere(nameof(gp0_blk_io_port), value); }

        [Offset(84UL)]
        public uint gp1_blk_io_port { get => ReadHere<uint>(nameof(gp1_blk_io_port)); set => WriteHere(nameof(gp1_blk_io_port), value); }

        [Offset(88UL)]
        public byte pm1_evt_len { get => ReadHere<byte>(nameof(pm1_evt_len)); set => WriteHere(nameof(pm1_evt_len), value); }

        [Offset(89UL)]
        public byte pm1_ctrl_len { get => ReadHere<byte>(nameof(pm1_ctrl_len)); set => WriteHere(nameof(pm1_ctrl_len), value); }

        [Offset(90UL)]
        public byte pm2_ctrl_len { get => ReadHere<byte>(nameof(pm2_ctrl_len)); set => WriteHere(nameof(pm2_ctrl_len), value); }

        [Offset(91UL)]
        public byte pm_tmr_len { get => ReadHere<byte>(nameof(pm_tmr_len)); set => WriteHere(nameof(pm_tmr_len), value); }

        [Offset(92UL)]
        public byte gp0_blk_len { get => ReadHere<byte>(nameof(gp0_blk_len)); set => WriteHere(nameof(gp0_blk_len), value); }

        [Offset(93UL)]
        public byte gp1_blk_len { get => ReadHere<byte>(nameof(gp1_blk_len)); set => WriteHere(nameof(gp1_blk_len), value); }

        [Offset(94UL)]
        public byte gp1_base { get => ReadHere<byte>(nameof(gp1_base)); set => WriteHere(nameof(gp1_base), value); }

        [Offset(95UL)]
        public byte cstate_control { get => ReadHere<byte>(nameof(cstate_control)); set => WriteHere(nameof(cstate_control), value); }

        [Offset(96UL)]
        public ushort lvl2_latency { get => ReadHere<ushort>(nameof(lvl2_latency)); set => WriteHere(nameof(lvl2_latency), value); }

        [Offset(98UL)]
        public ushort lvl3_latency { get => ReadHere<ushort>(nameof(lvl3_latency)); set => WriteHere(nameof(lvl3_latency), value); }

        [Offset(100UL)]
        public ushort flush_size { get => ReadHere<ushort>(nameof(flush_size)); set => WriteHere(nameof(flush_size), value); }

        [Offset(102UL)]
        public ushort flush_stride { get => ReadHere<ushort>(nameof(flush_stride)); set => WriteHere(nameof(flush_stride), value); }

        [Offset(104UL)]
        public byte duty_offset { get => ReadHere<byte>(nameof(duty_offset)); set => WriteHere(nameof(duty_offset), value); }

        [Offset(105UL)]
        public byte duty_width { get => ReadHere<byte>(nameof(duty_width)); set => WriteHere(nameof(duty_width), value); }

        [Offset(106UL)]
        public byte day_alarm_index { get => ReadHere<byte>(nameof(day_alarm_index)); set => WriteHere(nameof(day_alarm_index), value); }

        [Offset(107UL)]
        public byte month_alarm_index { get => ReadHere<byte>(nameof(month_alarm_index)); set => WriteHere(nameof(month_alarm_index), value); }

        [Offset(108UL)]
        public byte century_alarm_index { get => ReadHere<byte>(nameof(century_alarm_index)); set => WriteHere(nameof(century_alarm_index), value); }

        [Offset(109UL)]
        public ushort boot_arch { get => ReadHere<ushort>(nameof(boot_arch)); set => WriteHere(nameof(boot_arch), value); }

        [Offset(111UL)]
        [Length(1)]
        public DynamicArray reserved3 { get => ReadStructure<DynamicArray>(nameof(reserved3)); set => WriteStructure(nameof(reserved3), value); }

        [Offset(112UL)]
        public uint flags { get => ReadHere<uint>(nameof(flags)); set => WriteHere(nameof(flags), value); }

        [Offset(116UL)]
        public GenAddr reset_reg { get => ReadStructure<GenAddr>(nameof(reset_reg)); set => WriteStructure(nameof(reset_reg), value); }

        [Offset(128UL)]
        public byte reset_val { get => ReadHere<byte>(nameof(reset_val)); set => WriteHere(nameof(reset_val), value); }

        [Offset(129UL)]
        public ushort arm_boot_arch { get => ReadHere<ushort>(nameof(arm_boot_arch)); set => WriteHere(nameof(arm_boot_arch), value); }

        [Offset(131UL)]
        public byte minor_version_number { get => ReadHere<byte>(nameof(minor_version_number)); set => WriteHere(nameof(minor_version_number), value); }

        [Offset(132UL)]
        public LargeInteger x_firmware_ctrl { get => ReadStructure<LargeInteger>(nameof(x_firmware_ctrl)); set => WriteStructure(nameof(x_firmware_ctrl), value); }

        [Offset(140UL)]
        public LargeInteger x_dsdt { get => ReadStructure<LargeInteger>(nameof(x_dsdt)); set => WriteStructure(nameof(x_dsdt), value); }

        [Offset(148UL)]
        public GenAddr x_pm1a_evt_blk { get => ReadStructure<GenAddr>(nameof(x_pm1a_evt_blk)); set => WriteStructure(nameof(x_pm1a_evt_blk), value); }

        [Offset(160UL)]
        public GenAddr x_pm1b_evt_blk { get => ReadStructure<GenAddr>(nameof(x_pm1b_evt_blk)); set => WriteStructure(nameof(x_pm1b_evt_blk), value); }

        [Offset(172UL)]
        public GenAddr x_pm1a_ctrl_blk { get => ReadStructure<GenAddr>(nameof(x_pm1a_ctrl_blk)); set => WriteStructure(nameof(x_pm1a_ctrl_blk), value); }

        [Offset(184UL)]
        public GenAddr x_pm1b_ctrl_blk { get => ReadStructure<GenAddr>(nameof(x_pm1b_ctrl_blk)); set => WriteStructure(nameof(x_pm1b_ctrl_blk), value); }

        [Offset(196UL)]
        public GenAddr x_pm2_ctrl_blk { get => ReadStructure<GenAddr>(nameof(x_pm2_ctrl_blk)); set => WriteStructure(nameof(x_pm2_ctrl_blk), value); }

        [Offset(208UL)]
        public GenAddr x_pm_tmr_blk { get => ReadStructure<GenAddr>(nameof(x_pm_tmr_blk)); set => WriteStructure(nameof(x_pm_tmr_blk), value); }

        [Offset(220UL)]
        public GenAddr x_gp0_blk { get => ReadStructure<GenAddr>(nameof(x_gp0_blk)); set => WriteStructure(nameof(x_gp0_blk), value); }

        [Offset(232UL)]
        public GenAddr x_gp1_blk { get => ReadStructure<GenAddr>(nameof(x_gp1_blk)); set => WriteStructure(nameof(x_gp1_blk), value); }

        [Offset(244UL)]
        public GenAddr sleep_control_reg { get => ReadStructure<GenAddr>(nameof(sleep_control_reg)); set => WriteStructure(nameof(sleep_control_reg), value); }

        [Offset(256UL)]
        public GenAddr sleep_status_reg { get => ReadStructure<GenAddr>(nameof(sleep_status_reg)); set => WriteStructure(nameof(sleep_status_reg), value); }

        [Offset(268UL)]
        public ulong hypervisor_vendor_identity { get => ReadHere<ulong>(nameof(hypervisor_vendor_identity)); set => WriteHere(nameof(hypervisor_vendor_identity), value); }

        public Fadt(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Fadt>();
        }
    }
}