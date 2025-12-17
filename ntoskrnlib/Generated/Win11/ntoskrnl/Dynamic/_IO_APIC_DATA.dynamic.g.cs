using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_APIC_DATA")]
    public sealed class _IO_APIC_DATA : DynamicStructure
    {
        public ulong PhysicalAddress { get; }
        public uint Identifier { get; }
        public IntPtr BaseAddress { get; }
        public byte Version { get; }
        public byte PinCount { get; }
        public byte Initialized { get; }
        public byte InitializedFirstLocalUnit { get; }
        public uint GsiBase { get; }
        public uint CmciRegister { get; }
        public uint DeferredErrorRegister { get; }
        public byte IoUnitMissing { get; }

        public _IO_APIC_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_APIC_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_APIC_DATA.PhysicalAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_APIC_DATA.Identifier),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IO_APIC_DATA.BaseAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IO_APIC_DATA.Version),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IO_APIC_DATA.PinCount),
                    new ulong[]
                    {
                        25UL
                    }
                },
                {
                    nameof(_IO_APIC_DATA.Initialized),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_IO_APIC_DATA.InitializedFirstLocalUnit),
                    new ulong[]
                    {
                        27UL
                    }
                },
                {
                    nameof(_IO_APIC_DATA.GsiBase),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_IO_APIC_DATA.CmciRegister),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IO_APIC_DATA.DeferredErrorRegister),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_IO_APIC_DATA.IoUnitMissing),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_IO_APIC_DATA>((mem, ptr) => new _IO_APIC_DATA(mem, ptr), offsets);
        }
    }
}