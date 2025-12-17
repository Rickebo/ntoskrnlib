using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMINPAGE_SUPPORT")]
    public sealed class _MMINPAGE_SUPPORT : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public _SLIST_ENTRY SListEntry { get; }
        public _LIST_ENTRY ListHead { get; }
        public _KEVENT Event { get; }
        public _KEVENT CollidedEvent { get; }
        public _IO_STATUS_BLOCK IoStatus { get; }
        public _LARGE_INTEGER ReadOffset { get; }
        public _unnamed_tag_ u2 { get; }
        public IntPtr Thread { get; }
        public IntPtr LockedProtoPfn { get; }
        public _MMPTE PteContents { get; }
        public int WaitCount { get; }
        public int InjectRetry { get; }
        public uint ByteCount { get; }
        public _unnamed_tag_ u3 { get; }
        public _unnamed_tag_ u1 { get; }
        public IntPtr FilePointer { get; }
        public IntPtr PagingFile { get; }
        public IntPtr Subsection { get; }
        public IntPtr AutoBoostLock { get; }
        public IntPtr FaultingAddress { get; }
        public IntPtr PointerPte { get; }
        public IntPtr BasePte { get; }
        public IntPtr Pfn { get; }
        public IntPtr PrefetchMdl { get; }
        public long ProbeCount { get; }
        public _MDL Mdl { get; }
        public ulong[] Page { get; }
        public _MMINPAGE_SUPPORT_FLOW_THROUGH FlowThrough { get; }

        public _MMINPAGE_SUPPORT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMINPAGE_SUPPORT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMINPAGE_SUPPORT.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.SListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.ListHead),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.Event),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.CollidedEvent),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.IoStatus),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.ReadOffset),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.u2),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.Thread),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.LockedProtoPfn),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.PteContents),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.WaitCount),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.InjectRetry),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.ByteCount),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.u3),
                    new ulong[]
                    {
                        188UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.u1),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.FilePointer),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.PagingFile),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.Subsection),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.AutoBoostLock),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.FaultingAddress),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.PointerPte),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.BasePte),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.Pfn),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.PrefetchMdl),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.ProbeCount),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.Mdl),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.Page),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT.FlowThrough),
                    new ulong[]
                    {
                        320UL
                    }
                }
            };
            Register<_MMINPAGE_SUPPORT>((mem, ptr) => new _MMINPAGE_SUPPORT(mem, ptr), offsets);
        }
    }
}