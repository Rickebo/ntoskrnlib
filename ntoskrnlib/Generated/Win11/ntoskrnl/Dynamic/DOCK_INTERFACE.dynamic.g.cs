using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!DOCK_INTERFACE")]
    public sealed class DOCK_INTERFACE : DynamicStructure
    {
        public ushort Size { get; }
        public ushort Version { get; }
        public IntPtr Context { get; }
        public IntPtr InterfaceReference { get; }
        public IntPtr InterfaceDereference { get; }
        public IntPtr ProfileDepartureSetMode { get; }
        public IntPtr ProfileDepartureUpdate { get; }

        public DOCK_INTERFACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static DOCK_INTERFACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(DOCK_INTERFACE.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(DOCK_INTERFACE.Version),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(DOCK_INTERFACE.Context),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(DOCK_INTERFACE.InterfaceReference),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(DOCK_INTERFACE.InterfaceDereference),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(DOCK_INTERFACE.ProfileDepartureSetMode),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(DOCK_INTERFACE.ProfileDepartureUpdate),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<DOCK_INTERFACE>((mem, ptr) => new DOCK_INTERFACE(mem, ptr), offsets);
        }
    }
}