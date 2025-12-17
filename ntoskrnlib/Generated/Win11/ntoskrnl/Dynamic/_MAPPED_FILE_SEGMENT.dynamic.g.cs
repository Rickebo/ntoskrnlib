using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MAPPED_FILE_SEGMENT")]
    public sealed class _MAPPED_FILE_SEGMENT : DynamicStructure
    {
        public IntPtr ControlArea { get; }
        public uint TotalNumberOfPtes { get; }
        public _SEGMENT_FLAGS SegmentFlags { get; }
        public ulong NumberOfCommittedPages { get; }
        public ulong SizeOfSegment { get; }
        public IntPtr ExtendInfo { get; }
        public IntPtr BasedAddress { get; }
        public _EX_PUSH_LOCK SegmentLock { get; }

        public _MAPPED_FILE_SEGMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MAPPED_FILE_SEGMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MAPPED_FILE_SEGMENT.ControlArea),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MAPPED_FILE_SEGMENT.TotalNumberOfPtes),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MAPPED_FILE_SEGMENT.SegmentFlags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MAPPED_FILE_SEGMENT.NumberOfCommittedPages),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MAPPED_FILE_SEGMENT.SizeOfSegment),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MAPPED_FILE_SEGMENT.ExtendInfo),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MAPPED_FILE_SEGMENT.BasedAddress),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MAPPED_FILE_SEGMENT.SegmentLock),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_MAPPED_FILE_SEGMENT>((mem, ptr) => new _MAPPED_FILE_SEGMENT(mem, ptr), offsets);
        }
    }
}