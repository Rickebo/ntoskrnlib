using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROCLOCALGIC")]
    public sealed class _PROCLOCALGIC : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public ushort Reserved { get; }
        public uint Identifier { get; }
        public uint AcpiProcessorId { get; }
        public uint Flags { get; }
        public uint ParkingProtocolVersion { get; }
        public uint PerformanceInterruptGsi { get; }
        public ulong ParkedPhysicalAddress { get; }
        public ulong ControllerPhysicalAddress { get; }
        public ulong Gicv { get; }
        public ulong Gich { get; }
        public uint VgicMaintenanceInterrupt { get; }
        public ulong GicrBaseAddress { get; }
        public ulong Mpidr { get; }
        public byte ProcessorPowerEfficiencyClass { get; }
        public byte Reserved77 { get; }
        public ushort SpeInterruptGsi { get; }

        public _PROCLOCALGIC(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCLOCALGIC()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCLOCALGIC.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.Reserved),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.Identifier),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.AcpiProcessorId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.ParkingProtocolVersion),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.PerformanceInterruptGsi),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.ParkedPhysicalAddress),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.ControllerPhysicalAddress),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.Gicv),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.Gich),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.VgicMaintenanceInterrupt),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.GicrBaseAddress),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.Mpidr),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.ProcessorPowerEfficiencyClass),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.Reserved77),
                    new ulong[]
                    {
                        77UL
                    }
                },
                {
                    nameof(_PROCLOCALGIC.SpeInterruptGsi),
                    new ulong[]
                    {
                        78UL
                    }
                }
            };
            Register<_PROCLOCALGIC>((mem, ptr) => new _PROCLOCALGIC(mem, ptr), offsets);
        }
    }
}