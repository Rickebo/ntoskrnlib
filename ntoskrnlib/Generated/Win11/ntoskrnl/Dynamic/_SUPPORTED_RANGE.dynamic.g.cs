using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SUPPORTED_RANGE")]
    public sealed class _SUPPORTED_RANGE : DynamicStructure
    {
        public IntPtr Next { get; }
        public uint SystemAddressSpace { get; }
        public long SystemBase { get; }
        public long Base { get; }
        public long Limit { get; }

        public _SUPPORTED_RANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SUPPORTED_RANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SUPPORTED_RANGE.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGE.SystemAddressSpace),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGE.SystemBase),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGE.Base),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SUPPORTED_RANGE.Limit),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_SUPPORTED_RANGE>((mem, ptr) => new _SUPPORTED_RANGE(mem, ptr), offsets);
        }
    }
}