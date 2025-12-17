using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_CQE")]
    public sealed class _NT_IORING_CQE : DynamicStructure
    {
        public ulong UserData { get; }
        public ulong PaddingUserDataForWow { get; }
        public _IO_STATUS_BLOCK IoStatus { get; }

        public _NT_IORING_CQE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_CQE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_CQE.UserData),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_CQE.PaddingUserDataForWow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_CQE.IoStatus),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_NT_IORING_CQE>((mem, ptr) => new _NT_IORING_CQE(mem, ptr), offsets);
        }
    }
}