using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_TARGET_VERIFIED_DRIVER_DATA")]
    public sealed class _VF_TARGET_VERIFIED_DRIVER_DATA : DynamicStructure
    {
        public IntPtr SuspectDriverEntry { get; }
        public IntPtr WMICallback { get; }
        public _LIST_ENTRY EtwHandlesListHead { get; }
        public _unnamed_tag_ u1 { get; }
        public ulong Signature { get; }
        public byte SeSigningLevel { get; }
        public _SLIST_HEADER PoolPageHeaders { get; }
        public _SLIST_HEADER PoolTrackers { get; }
        public _LIST_ENTRY DifPluginPerDriverDataContextHead { get; }
        public uint CurrentPagedPoolAllocations { get; }
        public uint CurrentNonPagedPoolAllocations { get; }
        public uint PeakPagedPoolAllocations { get; }
        public uint PeakNonPagedPoolAllocations { get; }
        public ulong PagedBytes { get; }
        public ulong NonPagedBytes { get; }
        public ulong PeakPagedBytes { get; }
        public ulong PeakNonPagedBytes { get; }
        public uint RaiseIrqls { get; }
        public uint AcquireSpinLocks { get; }
        public uint SynchronizeExecutions { get; }
        public uint AllocationsWithNoTag { get; }
        public uint AllocationsFailed { get; }
        public uint AllocationsFailedDeliberately { get; }
        public ulong LockedBytes { get; }
        public ulong PeakLockedBytes { get; }
        public ulong MappedLockedBytes { get; }
        public ulong PeakMappedLockedBytes { get; }
        public ulong MappedIoSpaceBytes { get; }
        public ulong PeakMappedIoSpaceBytes { get; }
        public ulong PagesForMdlBytes { get; }
        public ulong PeakPagesForMdlBytes { get; }
        public ulong ContiguousMemoryBytes { get; }
        public ulong PeakContiguousMemoryBytes { get; }
        public _LIST_ENTRY ContiguousMemoryListHead { get; }

        public _VF_TARGET_VERIFIED_DRIVER_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_TARGET_VERIFIED_DRIVER_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.SuspectDriverEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.WMICallback),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.EtwHandlesListHead),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.u1),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.Signature),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.SeSigningLevel),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.PoolPageHeaders),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.PoolTrackers),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.DifPluginPerDriverDataContextHead),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.CurrentPagedPoolAllocations),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.CurrentNonPagedPoolAllocations),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.PeakPagedPoolAllocations),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.PeakNonPagedPoolAllocations),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.PagedBytes),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.NonPagedBytes),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.PeakPagedBytes),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.PeakNonPagedBytes),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.RaiseIrqls),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.AcquireSpinLocks),
                    new ulong[]
                    {
                        164UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.SynchronizeExecutions),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.AllocationsWithNoTag),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.AllocationsFailed),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.AllocationsFailedDeliberately),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.LockedBytes),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.PeakLockedBytes),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.MappedLockedBytes),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.PeakMappedLockedBytes),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.MappedIoSpaceBytes),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.PeakMappedIoSpaceBytes),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.PagesForMdlBytes),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.PeakPagesForMdlBytes),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.ContiguousMemoryBytes),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.PeakContiguousMemoryBytes),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_VF_TARGET_VERIFIED_DRIVER_DATA.ContiguousMemoryListHead),
                    new ulong[]
                    {
                        264UL
                    }
                }
            };
            Register<_VF_TARGET_VERIFIED_DRIVER_DATA>((mem, ptr) => new _VF_TARGET_VERIFIED_DRIVER_DATA(mem, ptr), offsets);
        }
    }
}