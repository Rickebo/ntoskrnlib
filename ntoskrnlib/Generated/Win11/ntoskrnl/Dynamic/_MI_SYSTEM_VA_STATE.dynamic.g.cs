using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_VA_STATE")]
    public sealed class _MI_SYSTEM_VA_STATE : DynamicStructure
    {
        public int SystemTablesLock { get; }
        public ulong AvailableSystemCacheVa { get; }
        public _MI_DYNAMIC_BITMAP DynamicBitMapKernelStacks { get; }
        public _MI_DYNAMIC_BITMAP DynamicBitMapKernelShadowStacks { get; }
        public _MI_DYNAMIC_BITMAP DynamicBitMapSystemPtes { get; }
        public _MI_DYNAMIC_BITMAP DynamicBitMapNonCachedMappings { get; }
        public _MI_DYNAMIC_BITMAP DynamicBitMapDriverImages { get; }
        public _MI_DYNAMIC_BITMAP DynamicBitMapPagedPool { get; }
        public _MI_DYNAMIC_BITMAP DynamicBitMapSystemCache { get; }
        public _MI_DYNAMIC_BITMAP DynamicBitMapSystemDataViews { get; }
        public _MI_DYNAMIC_BITMAP DynamicBitMapSecureNonPagedPool { get; }
        public IntPtr HalPrivateVaStart { get; }
        public ulong HalPrivateVaSize { get; }
        public uint[] SystemVaAssignment { get; }
        public uint SystemVaAssignmentHint { get; }
        public uint[] VaRegionShadowed { get; }
        public uint[] TopLevelPteLockBits { get; }
        public _MMSUPPORT_FULL SoftWsleSystemVm { get; }
        public IntPtr HyperSpaceBase { get; }
        public IntPtr PagableHyperSpace { get; }
        public IntPtr HyperSpaceEnd { get; }
        public IntPtr UserSoftWsleBase { get; }
        public ulong PagableHyperSpaceBytes { get; }
        public ulong[] PageTableCommitmentOffset { get; }
        public int SystemCacheViewLock { get; }
        public byte[] SystemWorkingSetList { get; }
        public ulong[] SelfmapLock { get; }
        public byte[] SystemCacheWorkingSetLockArray { get; }

        public _MI_SYSTEM_VA_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SYSTEM_VA_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SYSTEM_VA_STATE.SystemTablesLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.AvailableSystemCacheVa),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.DynamicBitMapKernelStacks),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.DynamicBitMapKernelShadowStacks),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.DynamicBitMapSystemPtes),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.DynamicBitMapNonCachedMappings),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.DynamicBitMapDriverImages),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.DynamicBitMapPagedPool),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.DynamicBitMapSystemCache),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.DynamicBitMapSystemDataViews),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.DynamicBitMapSecureNonPagedPool),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.HalPrivateVaStart),
                    new ulong[]
                    {
                        664UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.HalPrivateVaSize),
                    new ulong[]
                    {
                        672UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.SystemVaAssignment),
                    new ulong[]
                    {
                        680UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.SystemVaAssignmentHint),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.VaRegionShadowed),
                    new ulong[]
                    {
                        716UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.TopLevelPteLockBits),
                    new ulong[]
                    {
                        748UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.SoftWsleSystemVm),
                    new ulong[]
                    {
                        896UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.HyperSpaceBase),
                    new ulong[]
                    {
                        1216UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.PagableHyperSpace),
                    new ulong[]
                    {
                        1224UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.HyperSpaceEnd),
                    new ulong[]
                    {
                        1232UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.UserSoftWsleBase),
                    new ulong[]
                    {
                        1240UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.PagableHyperSpaceBytes),
                    new ulong[]
                    {
                        1248UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.PageTableCommitmentOffset),
                    new ulong[]
                    {
                        1256UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.SystemCacheViewLock),
                    new ulong[]
                    {
                        1272UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.SystemWorkingSetList),
                    new ulong[]
                    {
                        1280UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.SelfmapLock),
                    new ulong[]
                    {
                        3840UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_VA_STATE.SystemCacheWorkingSetLockArray),
                    new ulong[]
                    {
                        3904UL
                    }
                }
            };
            Register<_MI_SYSTEM_VA_STATE>((mem, ptr) => new _MI_SYSTEM_VA_STATE(mem, ptr), offsets);
        }
    }
}