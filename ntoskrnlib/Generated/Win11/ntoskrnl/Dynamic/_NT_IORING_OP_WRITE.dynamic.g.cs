using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_WRITE")]
    public sealed class _NT_IORING_OP_WRITE : DynamicStructure
    {
        public uint CommonOpFlags { get; }
        public uint Flags { get; }
        public _NT_IORING_HANDLEREF File { get; }
        public _NT_IORING_BUFFERREF Buffer { get; }
        public ulong Offset { get; }
        public uint Length { get; }
        public uint Key { get; }

        public _NT_IORING_OP_WRITE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_OP_WRITE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_OP_WRITE.CommonOpFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_WRITE.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_WRITE.File),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_WRITE.Buffer),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_WRITE.Offset),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_WRITE.Length),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_WRITE.Key),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_NT_IORING_OP_WRITE>((mem, ptr) => new _NT_IORING_OP_WRITE(mem, ptr), offsets);
        }
    }
}