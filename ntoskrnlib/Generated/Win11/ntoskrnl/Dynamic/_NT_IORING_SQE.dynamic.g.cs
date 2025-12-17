using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_SQE")]
    public sealed class _NT_IORING_SQE : DynamicStructure
    {
        public uint OpCode { get; }
        public uint Flags { get; }
        public ulong UserData { get; }
        public ulong PaddingUserDataForWow { get; }
        public _NT_IORING_OP_READ Read { get; }
        public _NT_IORING_OP_REGISTER_FILES RegisterFiles { get; }
        public _NT_IORING_OP_REGISTER_BUFFERS RegisterBuffers { get; }
        public _NT_IORING_OP_CANCEL Cancel { get; }
        public _NT_IORING_OP_WRITE Write { get; }
        public _NT_IORING_OP_FLUSH Flush { get; }
        public _NT_IORING_OP_READ_SCATTER ReadScatter { get; }
        public _NT_IORING_OP_WRITE_GATHER WriteGather { get; }
        public _NT_IORING_OP_RESERVED ReservedMaxSizePadding { get; }

        public _NT_IORING_SQE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_SQE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_SQE.OpCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_SQE.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NT_IORING_SQE.UserData),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NT_IORING_SQE.PaddingUserDataForWow),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NT_IORING_SQE.Read),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_SQE.RegisterFiles),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_SQE.RegisterBuffers),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_SQE.Cancel),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_SQE.Write),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_SQE.Flush),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_SQE.ReadScatter),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_SQE.WriteGather),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_SQE.ReservedMaxSizePadding),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_NT_IORING_SQE>((mem, ptr) => new _NT_IORING_SQE(mem, ptr), offsets);
        }
    }
}