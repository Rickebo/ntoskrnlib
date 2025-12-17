using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FADT")]
    public sealed class _FADT : DynamicStructure
    {
        public _DESCRIPTION_HEADER Header { get; }
        public uint facs { get; }
        public uint dsdt { get; }
        public byte int_model { get; }
        public byte pm_profile { get; }
        public ushort sci_int_vector { get; }
        public uint smi_cmd_io_port { get; }
        public byte acpi_on_value { get; }
        public byte acpi_off_value { get; }
        public byte s4bios_req { get; }
        public byte pstate_control { get; }
        public uint pm1a_evt_blk_io_port { get; }
        public uint pm1b_evt_blk_io_port { get; }
        public uint pm1a_ctrl_blk_io_port { get; }
        public uint pm1b_ctrl_blk_io_port { get; }
        public uint pm2_ctrl_blk_io_port { get; }
        public uint pm_tmr_blk_io_port { get; }
        public uint gp0_blk_io_port { get; }
        public uint gp1_blk_io_port { get; }
        public byte pm1_evt_len { get; }
        public byte pm1_ctrl_len { get; }
        public byte pm2_ctrl_len { get; }
        public byte pm_tmr_len { get; }
        public byte gp0_blk_len { get; }
        public byte gp1_blk_len { get; }
        public byte gp1_base { get; }
        public byte cstate_control { get; }
        public ushort lvl2_latency { get; }
        public ushort lvl3_latency { get; }
        public ushort flush_size { get; }
        public ushort flush_stride { get; }
        public byte duty_offset { get; }
        public byte duty_width { get; }
        public byte day_alarm_index { get; }
        public byte month_alarm_index { get; }
        public byte century_alarm_index { get; }
        public ushort boot_arch { get; }
        public byte[] reserved3 { get; }
        public uint flags { get; }
        public _GEN_ADDR reset_reg { get; }
        public byte reset_val { get; }
        public ushort arm_boot_arch { get; }
        public byte minor_version_number { get; }
        public _LARGE_INTEGER x_firmware_ctrl { get; }
        public _LARGE_INTEGER x_dsdt { get; }
        public _GEN_ADDR x_pm1a_evt_blk { get; }
        public _GEN_ADDR x_pm1b_evt_blk { get; }
        public _GEN_ADDR x_pm1a_ctrl_blk { get; }
        public _GEN_ADDR x_pm1b_ctrl_blk { get; }
        public _GEN_ADDR x_pm2_ctrl_blk { get; }
        public _GEN_ADDR x_pm_tmr_blk { get; }
        public _GEN_ADDR x_gp0_blk { get; }
        public _GEN_ADDR x_gp1_blk { get; }
        public _GEN_ADDR sleep_control_reg { get; }
        public _GEN_ADDR sleep_status_reg { get; }
        public ulong hypervisor_vendor_identity { get; }

        public _FADT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FADT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FADT.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FADT.facs),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_FADT.dsdt),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_FADT.int_model),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_FADT.pm_profile),
                    new ulong[]
                    {
                        45UL
                    }
                },
                {
                    nameof(_FADT.sci_int_vector),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_FADT.smi_cmd_io_port),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_FADT.acpi_on_value),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_FADT.acpi_off_value),
                    new ulong[]
                    {
                        53UL
                    }
                },
                {
                    nameof(_FADT.s4bios_req),
                    new ulong[]
                    {
                        54UL
                    }
                },
                {
                    nameof(_FADT.pstate_control),
                    new ulong[]
                    {
                        55UL
                    }
                },
                {
                    nameof(_FADT.pm1a_evt_blk_io_port),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_FADT.pm1b_evt_blk_io_port),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_FADT.pm1a_ctrl_blk_io_port),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_FADT.pm1b_ctrl_blk_io_port),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_FADT.pm2_ctrl_blk_io_port),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_FADT.pm_tmr_blk_io_port),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_FADT.gp0_blk_io_port),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_FADT.gp1_blk_io_port),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_FADT.pm1_evt_len),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_FADT.pm1_ctrl_len),
                    new ulong[]
                    {
                        89UL
                    }
                },
                {
                    nameof(_FADT.pm2_ctrl_len),
                    new ulong[]
                    {
                        90UL
                    }
                },
                {
                    nameof(_FADT.pm_tmr_len),
                    new ulong[]
                    {
                        91UL
                    }
                },
                {
                    nameof(_FADT.gp0_blk_len),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_FADT.gp1_blk_len),
                    new ulong[]
                    {
                        93UL
                    }
                },
                {
                    nameof(_FADT.gp1_base),
                    new ulong[]
                    {
                        94UL
                    }
                },
                {
                    nameof(_FADT.cstate_control),
                    new ulong[]
                    {
                        95UL
                    }
                },
                {
                    nameof(_FADT.lvl2_latency),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_FADT.lvl3_latency),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_FADT.flush_size),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_FADT.flush_stride),
                    new ulong[]
                    {
                        102UL
                    }
                },
                {
                    nameof(_FADT.duty_offset),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_FADT.duty_width),
                    new ulong[]
                    {
                        105UL
                    }
                },
                {
                    nameof(_FADT.day_alarm_index),
                    new ulong[]
                    {
                        106UL
                    }
                },
                {
                    nameof(_FADT.month_alarm_index),
                    new ulong[]
                    {
                        107UL
                    }
                },
                {
                    nameof(_FADT.century_alarm_index),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_FADT.boot_arch),
                    new ulong[]
                    {
                        109UL
                    }
                },
                {
                    nameof(_FADT.reserved3),
                    new ulong[]
                    {
                        111UL
                    }
                },
                {
                    nameof(_FADT.flags),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_FADT.reset_reg),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_FADT.reset_val),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_FADT.arm_boot_arch),
                    new ulong[]
                    {
                        129UL
                    }
                },
                {
                    nameof(_FADT.minor_version_number),
                    new ulong[]
                    {
                        131UL
                    }
                },
                {
                    nameof(_FADT.x_firmware_ctrl),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_FADT.x_dsdt),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_FADT.x_pm1a_evt_blk),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_FADT.x_pm1b_evt_blk),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_FADT.x_pm1a_ctrl_blk),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_FADT.x_pm1b_ctrl_blk),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_FADT.x_pm2_ctrl_blk),
                    new ulong[]
                    {
                        196UL
                    }
                },
                {
                    nameof(_FADT.x_pm_tmr_blk),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_FADT.x_gp0_blk),
                    new ulong[]
                    {
                        220UL
                    }
                },
                {
                    nameof(_FADT.x_gp1_blk),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_FADT.sleep_control_reg),
                    new ulong[]
                    {
                        244UL
                    }
                },
                {
                    nameof(_FADT.sleep_status_reg),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_FADT.hypervisor_vendor_identity),
                    new ulong[]
                    {
                        268UL
                    }
                }
            };
            Register<_FADT>((mem, ptr) => new _FADT(mem, ptr), offsets);
        }
    }
}