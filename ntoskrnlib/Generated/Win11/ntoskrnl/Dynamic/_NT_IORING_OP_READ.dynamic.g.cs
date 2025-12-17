using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_READ")]
    public sealed class _NT_IORING_OP_READ : DynamicStructure
    {
        public uint CommonOpFlags { get; }
        public uint Padding { get; }
        public _NT_IORING_HANDLEREF File { get; }
        public _NT_IORING_BUFFERREF Buffer { get; }
        public ulong Offset { get; }
        public uint Length { get; }
        public uint Key { get; }

        public _NT_IORING_OP_READ(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_OP_READ()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_OP_READ.CommonOpFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_READ.Padding),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_READ.File),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_READ.Buffer),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_READ.Offset),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_READ.Length),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_READ.Key),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_NT_IORING_OP_READ>((mem, ptr) => new _NT_IORING_OP_READ(mem, ptr), offsets);
        }
    }
}