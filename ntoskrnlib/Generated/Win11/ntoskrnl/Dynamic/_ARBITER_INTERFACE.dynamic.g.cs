using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_INTERFACE")]
    public sealed class _ARBITER_INTERFACE : DynamicStructure
    {
        public ushort Size { get; }
        public ushort Version { get; }
        public IntPtr Context { get; }
        public IntPtr InterfaceReference { get; }
        public IntPtr InterfaceDereference { get; }
        public IntPtr ArbiterHandler { get; }
        public uint Flags { get; }

        public _ARBITER_INTERFACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_INTERFACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_INTERFACE.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARBITER_INTERFACE.Version),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_ARBITER_INTERFACE.Context),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ARBITER_INTERFACE.InterfaceReference),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ARBITER_INTERFACE.InterfaceDereference),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ARBITER_INTERFACE.ArbiterHandler),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ARBITER_INTERFACE.Flags),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_ARBITER_INTERFACE>((mem, ptr) => new _ARBITER_INTERFACE(mem, ptr), offsets);
        }
    }
}