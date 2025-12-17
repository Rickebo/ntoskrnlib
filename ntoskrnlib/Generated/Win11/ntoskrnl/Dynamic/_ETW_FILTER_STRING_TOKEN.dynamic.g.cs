using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_FILTER_STRING_TOKEN")]
    public sealed class _ETW_FILTER_STRING_TOKEN : DynamicStructure
    {
        public ushort Count { get; }
        public byte[] Tokens { get; }

        public _ETW_FILTER_STRING_TOKEN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_FILTER_STRING_TOKEN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_FILTER_STRING_TOKEN.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_FILTER_STRING_TOKEN.Tokens),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_ETW_FILTER_STRING_TOKEN>((mem, ptr) => new _ETW_FILTER_STRING_TOKEN(mem, ptr), offsets);
        }
    }
}