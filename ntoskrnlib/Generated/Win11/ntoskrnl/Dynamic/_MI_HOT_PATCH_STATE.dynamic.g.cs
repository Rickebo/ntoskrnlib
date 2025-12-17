using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_HOT_PATCH_STATE")]
    public sealed class _MI_HOT_PATCH_STATE : DynamicStructure
    {
        public _RTL_AVL_TREE UserSidPatchLists { get; }
        public _RTL_AVL_TREE GlobalHotPatchList { get; }
        public _RTL_AVL_TREE PreviouslyRegisteredHotPatchList { get; }
        public _RTL_AVL_TREE SecureImageActivePatches { get; }
        public _EX_PUSH_LOCK HotPatchListLock { get; }
        public IntPtr InProgressPatchTableEntry { get; }
        public IntPtr InProgressBaseTableEntry { get; }
        public sbyte ReadyForPatchOperations { get; }
        public uint HotPatchReserveSize { get; }
        public uint DriverProxyReserveSize { get; }
        public uint HotPatchingEnabled { get; }
        public uint Spare { get; }

        public _MI_HOT_PATCH_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_HOT_PATCH_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_HOT_PATCH_STATE.UserSidPatchLists),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_HOT_PATCH_STATE.GlobalHotPatchList),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_HOT_PATCH_STATE.PreviouslyRegisteredHotPatchList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_HOT_PATCH_STATE.SecureImageActivePatches),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_HOT_PATCH_STATE.HotPatchListLock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_HOT_PATCH_STATE.InProgressPatchTableEntry),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_HOT_PATCH_STATE.InProgressBaseTableEntry),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_HOT_PATCH_STATE.ReadyForPatchOperations),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_HOT_PATCH_STATE.HotPatchReserveSize),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_MI_HOT_PATCH_STATE.DriverProxyReserveSize),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_HOT_PATCH_STATE.HotPatchingEnabled),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_MI_HOT_PATCH_STATE.Spare),
                    new ulong[]
                    {
                        68UL
                    }
                }
            };
            Register<_MI_HOT_PATCH_STATE>((mem, ptr) => new _MI_HOT_PATCH_STATE(mem, ptr), offsets);
        }
    }
}