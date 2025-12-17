using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SECONDARY_INTERRUPT_PROVIDER_INTERFACE")]
    public sealed class _SECONDARY_INTERRUPT_PROVIDER_INTERFACE : DynamicStructure
    {
        public ushort Size { get; }
        public ushort Version { get; }
        public IntPtr Context { get; }
        public uint GsivBase { get; }
        public ushort GsivSize { get; }
        public IntPtr DriverObject { get; }
        public IntPtr Reserved1 { get; }
        public IntPtr Reserved2 { get; }
        public IntPtr Reserved3 { get; }
        public IntPtr Reserved4 { get; }
        public IntPtr Reserved5 { get; }
        public IntPtr Reserved6 { get; }
        public IntPtr Reserved7 { get; }

        public _SECONDARY_INTERRUPT_PROVIDER_INTERFACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SECONDARY_INTERRUPT_PROVIDER_INTERFACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SECONDARY_INTERRUPT_PROVIDER_INTERFACE.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_PROVIDER_INTERFACE.Version),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_PROVIDER_INTERFACE.Context),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_PROVIDER_INTERFACE.GsivBase),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_PROVIDER_INTERFACE.GsivSize),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_PROVIDER_INTERFACE.DriverObject),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_PROVIDER_INTERFACE.Reserved1),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_PROVIDER_INTERFACE.Reserved2),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_PROVIDER_INTERFACE.Reserved3),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_PROVIDER_INTERFACE.Reserved4),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_PROVIDER_INTERFACE.Reserved5),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_PROVIDER_INTERFACE.Reserved6),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_PROVIDER_INTERFACE.Reserved7),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_SECONDARY_INTERRUPT_PROVIDER_INTERFACE>((mem, ptr) => new _SECONDARY_INTERRUPT_PROVIDER_INTERFACE(mem, ptr), offsets);
        }
    }
}