using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!<unnamed-tag>")]
    public sealed class _unnamed_tag_ : DynamicStructure
    {
        public uint LowPart { get; }
        public int HighPart { get; }

        public _unnamed_tag_(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _unnamed_tag_()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_unnamed_tag_.LowPart),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.HighPart),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_unnamed_tag_>((mem, ptr) => new _unnamed_tag_(mem, ptr), offsets);
        }
    }
}