using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_WRITE_GATHER")]
    public sealed class _NT_IORING_OP_WRITE_GATHER : DynamicStructure
    {
        public uint CommonOpFlags { get; }
        public uint Flags { get; }
        public _NT_IORING_HANDLEREF File { get; }
        public uint SegmentCount { get; }
        public IntPtr SegmentArray { get; }
        public ulong Offset { get; }
        public uint Length { get; }
        public uint Key { get; }

        public _NT_IORING_OP_WRITE_GATHER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_OP_WRITE_GATHER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_OP_WRITE_GATHER.CommonOpFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_WRITE_GATHER.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_WRITE_GATHER.File),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_WRITE_GATHER.SegmentCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_WRITE_GATHER.SegmentArray),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_WRITE_GATHER.Offset),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_WRITE_GATHER.Length),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_WRITE_GATHER.Key),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_NT_IORING_OP_WRITE_GATHER>((mem, ptr) => new _NT_IORING_OP_WRITE_GATHER(mem, ptr), offsets);
        }
    }
}