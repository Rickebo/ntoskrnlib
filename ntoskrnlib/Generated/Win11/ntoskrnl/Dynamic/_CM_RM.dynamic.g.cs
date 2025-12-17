using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_RM")]
    public sealed class _CM_RM : DynamicStructure
    {
        public _LIST_ENTRY RmListEntry { get; }
        public _LIST_ENTRY TransactionListHead { get; }
        public IntPtr TmHandle { get; }
        public IntPtr Tm { get; }
        public IntPtr RmHandle { get; }
        public IntPtr KtmRm { get; }
        public uint RefCount { get; }
        public uint ContainerNum { get; }
        public ulong ContainerSize { get; }
        public IntPtr CmHive { get; }
        public IntPtr LogFileObject { get; }
        public IntPtr MarshallingContext { get; }
        public uint RmFlags { get; }
        public int LogStartStatus1 { get; }
        public int LogStartStatus2 { get; }
        public ulong BaseLsn { get; }
        public IntPtr RmLock { get; }

        public _CM_RM(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_RM()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_RM.RmListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_RM.TransactionListHead),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_RM.TmHandle),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CM_RM.Tm),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_CM_RM.RmHandle),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_RM.KtmRm),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CM_RM.RefCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_CM_RM.ContainerNum),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_CM_RM.ContainerSize),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_CM_RM.CmHive),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_CM_RM.LogFileObject),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CM_RM.MarshallingContext),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_CM_RM.RmFlags),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_CM_RM.LogStartStatus1),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_CM_RM.LogStartStatus2),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_CM_RM.BaseLsn),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_CM_RM.RmLock),
                    new ulong[]
                    {
                        128UL
                    }
                }
            };
            Register<_CM_RM>((mem, ptr) => new _CM_RM(mem, ptr), offsets);
        }
    }
}