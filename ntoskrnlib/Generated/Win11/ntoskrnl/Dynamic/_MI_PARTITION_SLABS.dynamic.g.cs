using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_SLABS")]
    public sealed class _MI_PARTITION_SLABS : DynamicStructure
    {
        public IntPtr SlabTypeIdentifiers { get; }
        public ulong SlabEntriesDemoted { get; }
        public int SlabDemoteInProgress { get; }
        public uint SlabTypeAcquiresCharges { get; }
        public byte[] IdentityRefs { get; }
        public _RTL_BITMAP InUseIdentitiesBitmap { get; }
        public uint[] InUseIdentitiesBitmapBuffer { get; }
        public int IdentitySlabsInitialized { get; }
        public _EX_PUSH_LOCK IdentitiesLock { get; }
        public ulong IdentitySlabAvailablePages { get; }
        public byte[] IdentitySlabAvailablePagesWaitState { get; }
        public _EX_RUNDOWN_REF ReplenishRundownProtection { get; }
        public ulong LowMemoryConditionStartTime { get; }

        public _MI_PARTITION_SLABS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PARTITION_SLABS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PARTITION_SLABS.SlabTypeIdentifiers),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SLABS.SlabEntriesDemoted),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SLABS.SlabDemoteInProgress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SLABS.SlabTypeAcquiresCharges),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SLABS.IdentityRefs),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SLABS.InUseIdentitiesBitmap),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SLABS.InUseIdentitiesBitmapBuffer),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SLABS.IdentitySlabsInitialized),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SLABS.IdentitiesLock),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SLABS.IdentitySlabAvailablePages),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SLABS.IdentitySlabAvailablePagesWaitState),
                    new ulong[]
                    {
                        584UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SLABS.ReplenishRundownProtection),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SLABS.LowMemoryConditionStartTime),
                    new ulong[]
                    {
                        656UL
                    }
                }
            };
            Register<_MI_PARTITION_SLABS>((mem, ptr) => new _MI_PARTITION_SLABS(mem, ptr), offsets);
        }
    }
}