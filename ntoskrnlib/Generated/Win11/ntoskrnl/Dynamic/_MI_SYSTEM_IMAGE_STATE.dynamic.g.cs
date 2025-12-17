using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_IMAGE_STATE")]
    public sealed class _MI_SYSTEM_IMAGE_STATE : DynamicStructure
    {
        public _LIST_ENTRY FixupList { get; }
        public IntPtr LoadLockOwner { get; }
        public uint LoadLockCount { get; }
        public int FixupLock { get; }
        public _EX_PUSH_LOCK EncodeDecodeLock { get; }
        public uint EncodeDecodeDepth { get; }
        public byte FirstLoadEver { get; }
        public byte SystemImagesLoaded { get; }
        public _LIST_ENTRY StrongCodeLoadFailureList { get; }
        public byte[] SystemBase { get; }
        public byte[] BaseImageDiscardedBitmaps { get; }
        public _EX_PUSH_LOCK MappingRangesPushLock { get; }
        public IntPtr MappingRanges { get; }
        public _MM_SYSTEM_PAGE_COUNTS PageCounts { get; }
        public _EX_PUSH_LOCK CollidedLock { get; }
        public _RTL_AVL_TREE ImageTree { get; }
        public _LIST_ENTRY LoadInProgress { get; }
        public ulong ImportEntriesReplaced { get; }
        public _EX_PUSH_LOCK SecurePteExclusionLock { get; }
        public IntPtr SecurePteExclusionBase { get; }
        public IntPtr SecurePteExclusionTop { get; }
        public byte[] WorkingSetLockArray { get; }
        public _RTL_FUNCTION_OVERRIDE_CAPABILITIES FunctionOverrideCapabilities { get; }

        public _MI_SYSTEM_IMAGE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SYSTEM_IMAGE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.FixupList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.LoadLockOwner),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.LoadLockCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.FixupLock),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.EncodeDecodeLock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.EncodeDecodeDepth),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.FirstLoadEver),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.SystemImagesLoaded),
                    new ulong[]
                    {
                        45UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.StrongCodeLoadFailureList),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.SystemBase),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.BaseImageDiscardedBitmaps),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.MappingRangesPushLock),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.MappingRanges),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.PageCounts),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.CollidedLock),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.ImageTree),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.LoadInProgress),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.ImportEntriesReplaced),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.SecurePteExclusionLock),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.SecurePteExclusionBase),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.SecurePteExclusionTop),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.WorkingSetLockArray),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_IMAGE_STATE.FunctionOverrideCapabilities),
                    new ulong[]
                    {
                        448UL
                    }
                }
            };
            Register<_MI_SYSTEM_IMAGE_STATE>((mem, ptr) => new _MI_SYSTEM_IMAGE_STATE(mem, ptr), offsets);
        }
    }
}