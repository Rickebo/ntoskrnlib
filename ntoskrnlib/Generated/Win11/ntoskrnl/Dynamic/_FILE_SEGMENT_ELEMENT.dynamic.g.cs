using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FILE_SEGMENT_ELEMENT")]
    public sealed class _FILE_SEGMENT_ELEMENT : DynamicStructure
    {
        public IntPtr Buffer { get; }
        public ulong Alignment { get; }

        public _FILE_SEGMENT_ELEMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FILE_SEGMENT_ELEMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FILE_SEGMENT_ELEMENT.Buffer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FILE_SEGMENT_ELEMENT.Alignment),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_FILE_SEGMENT_ELEMENT>((mem, ptr) => new _FILE_SEGMENT_ELEMENT(mem, ptr), offsets);
        }
    }
}