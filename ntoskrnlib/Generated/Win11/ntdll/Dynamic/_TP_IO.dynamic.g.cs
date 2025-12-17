using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TP_IO")]
    public sealed class _TP_IO : DynamicStructure
    {
        public _TPP_CLEANUP_GROUP_MEMBER CleanupGroupMember { get; }
        public _TP_DIRECT Direct { get; }
        public IntPtr File { get; }
        public int PendingIrpCount { get; }

        public _TP_IO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_IO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TP_IO.CleanupGroupMember),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TP_IO.Direct),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_TP_IO.File),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_TP_IO.PendingIrpCount),
                    new ulong[]
                    {
                        280UL
                    }
                }
            };
            Register<_TP_IO>((mem, ptr) => new _TP_IO(mem, ptr), offsets);
        }
    }
}