using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_READ_SCATTER")]
    public sealed class _NT_IORING_OP_READ_SCATTER : DynamicStructure
    {
        public uint CommonOpFlags { get; }
        public uint Padding { get; }
        public _NT_IORING_HANDLEREF File { get; }
        public uint SegmentCount { get; }
        public IntPtr SegmentArray { get; }
        public ulong Offset { get; }
        public uint Length { get; }
        public uint Key { get; }

        public _NT_IORING_OP_READ_SCATTER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_OP_READ_SCATTER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_OP_READ_SCATTER.CommonOpFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_READ_SCATTER.Padding),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_READ_SCATTER.File),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_READ_SCATTER.SegmentCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_READ_SCATTER.SegmentArray),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_READ_SCATTER.Offset),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_READ_SCATTER.Length),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_READ_SCATTER.Key),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_NT_IORING_OP_READ_SCATTER>((mem, ptr) => new _NT_IORING_OP_READ_SCATTER(mem, ptr), offsets);
        }
    }
}