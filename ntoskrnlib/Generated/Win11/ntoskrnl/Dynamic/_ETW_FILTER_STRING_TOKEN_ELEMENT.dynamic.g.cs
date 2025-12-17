using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_FILTER_STRING_TOKEN_ELEMENT")]
    public sealed class _ETW_FILTER_STRING_TOKEN_ELEMENT : DynamicStructure
    {
        public ushort Length { get; }
        public IntPtr String { get; }

        public _ETW_FILTER_STRING_TOKEN_ELEMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_FILTER_STRING_TOKEN_ELEMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_FILTER_STRING_TOKEN_ELEMENT.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_FILTER_STRING_TOKEN_ELEMENT.String),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_ETW_FILTER_STRING_TOKEN_ELEMENT>((mem, ptr) => new _ETW_FILTER_STRING_TOKEN_ELEMENT(mem, ptr), offsets);
        }
    }
}