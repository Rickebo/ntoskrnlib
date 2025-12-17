using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEGMENT")]
    public sealed class _SEGMENT : DynamicStructure
    {
        public IntPtr ControlArea { get; }
        public uint TotalNumberOfPtes { get; }
        public _SEGMENT_FLAGS SegmentFlags { get; }
        public ulong NumberOfCommittedPages { get; }
        public ulong SizeOfSegment { get; }
        public IntPtr ExtendInfo { get; }
        public IntPtr BasedAddress { get; }
        public _EX_PUSH_LOCK SegmentLock { get; }
        public _unnamed_tag_ u1 { get; }
        public _unnamed_tag_ u2 { get; }
        public IntPtr PrototypePte { get; }

        public _SEGMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEGMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEGMENT.ControlArea),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEGMENT.TotalNumberOfPtes),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SEGMENT.SegmentFlags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_SEGMENT.NumberOfCommittedPages),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SEGMENT.SizeOfSegment),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SEGMENT.ExtendInfo),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SEGMENT.BasedAddress),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SEGMENT.SegmentLock),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_SEGMENT.u1),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_SEGMENT.u2),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_SEGMENT.PrototypePte),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_SEGMENT>((mem, ptr) => new _SEGMENT(mem, ptr), offsets);
        }
    }
}