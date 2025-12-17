using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KGDTENTRY64")]
    public sealed class _KGDTENTRY64 : DynamicStructure
    {
        public ushort LimitLow { get; }
        public ushort BaseLow { get; }
        public _unnamed_tag_ Bytes { get; }
        public _unnamed_tag_ Bits { get; }
        public uint BaseUpper { get; }
        public uint MustBeZero { get; }
        public long DataLow { get; }
        public long DataHigh { get; }

        public _KGDTENTRY64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KGDTENTRY64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KGDTENTRY64.LimitLow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KGDTENTRY64.BaseLow),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_KGDTENTRY64.Bytes),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KGDTENTRY64.Bits),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KGDTENTRY64.BaseUpper),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KGDTENTRY64.MustBeZero),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KGDTENTRY64.DataLow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KGDTENTRY64.DataHigh),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_KGDTENTRY64>((mem, ptr) => new _KGDTENTRY64(mem, ptr), offsets);
        }
    }
}