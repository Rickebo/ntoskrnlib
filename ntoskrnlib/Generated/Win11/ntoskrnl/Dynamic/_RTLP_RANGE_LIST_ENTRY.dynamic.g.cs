using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTLP_RANGE_LIST_ENTRY")]
    public sealed class _RTLP_RANGE_LIST_ENTRY : DynamicStructure
    {
        public ulong Start { get; }
        public ulong End { get; }
        public _unnamed_tag_ Allocated { get; }
        public _unnamed_tag_ Merged { get; }
        public byte Attributes { get; }
        public byte PublicFlags { get; }
        public ushort PrivateFlags { get; }
        public _LIST_ENTRY ListEntry { get; }

        public _RTLP_RANGE_LIST_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTLP_RANGE_LIST_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTLP_RANGE_LIST_ENTRY.Start),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTLP_RANGE_LIST_ENTRY.End),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTLP_RANGE_LIST_ENTRY.Allocated),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTLP_RANGE_LIST_ENTRY.Merged),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTLP_RANGE_LIST_ENTRY.Attributes),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RTLP_RANGE_LIST_ENTRY.PublicFlags),
                    new ulong[]
                    {
                        33UL
                    }
                },
                {
                    nameof(_RTLP_RANGE_LIST_ENTRY.PrivateFlags),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_RTLP_RANGE_LIST_ENTRY.ListEntry),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_RTLP_RANGE_LIST_ENTRY>((mem, ptr) => new _RTLP_RANGE_LIST_ENTRY(mem, ptr), offsets);
        }
    }
}