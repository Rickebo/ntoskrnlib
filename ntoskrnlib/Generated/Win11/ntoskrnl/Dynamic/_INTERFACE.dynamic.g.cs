using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INTERFACE")]
    public sealed class _INTERFACE : DynamicStructure
    {
        public ushort Size { get; }
        public ushort Version { get; }
        public IntPtr Context { get; }
        public IntPtr InterfaceReference { get; }
        public IntPtr InterfaceDereference { get; }

        public _INTERFACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERFACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERFACE.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERFACE.Version),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_INTERFACE.Context),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_INTERFACE.InterfaceReference),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_INTERFACE.InterfaceDereference),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_INTERFACE>((mem, ptr) => new _INTERFACE(mem, ptr), offsets);
        }
    }
}