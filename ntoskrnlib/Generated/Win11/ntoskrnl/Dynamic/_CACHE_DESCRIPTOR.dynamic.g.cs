using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CACHE_DESCRIPTOR")]
    public sealed class _CACHE_DESCRIPTOR : DynamicStructure
    {
        public byte Level { get; }
        public byte Associativity { get; }
        public ushort LineSize { get; }
        public uint Size { get; }
        public uint Type { get; }

        public _CACHE_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CACHE_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CACHE_DESCRIPTOR.Level),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CACHE_DESCRIPTOR.Associativity),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_CACHE_DESCRIPTOR.LineSize),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_CACHE_DESCRIPTOR.Size),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CACHE_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CACHE_DESCRIPTOR>((mem, ptr) => new _CACHE_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}