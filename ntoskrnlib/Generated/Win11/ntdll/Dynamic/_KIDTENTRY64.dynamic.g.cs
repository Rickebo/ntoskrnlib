using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KIDTENTRY64")]
    public sealed class _KIDTENTRY64 : DynamicStructure
    {
        public ushort OffsetLow { get; }
        public ushort Selector { get; }
        public ushort IstIndex { get; }
        public ushort Reserved0 { get; }
        public ushort Type { get; }
        public ushort Dpl { get; }
        public ushort Present { get; }
        public ushort OffsetMiddle { get; }
        public uint OffsetHigh { get; }
        public uint Reserved1 { get; }
        public ulong Alignment { get; }

        public _KIDTENTRY64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KIDTENTRY64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KIDTENTRY64.OffsetLow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KIDTENTRY64.Selector),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_KIDTENTRY64.IstIndex),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KIDTENTRY64.Reserved0),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KIDTENTRY64.Type),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KIDTENTRY64.Dpl),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KIDTENTRY64.Present),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KIDTENTRY64.OffsetMiddle),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_KIDTENTRY64.OffsetHigh),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KIDTENTRY64.Reserved1),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KIDTENTRY64.Alignment),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KIDTENTRY64>((mem, ptr) => new _KIDTENTRY64(mem, ptr), offsets);
        }
    }
}