using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_KCB_UOW")]
    public sealed class _CM_KCB_UOW : DynamicStructure
    {
        public _LIST_ENTRY TransactionListEntry { get; }
        public IntPtr KCBLock { get; }
        public IntPtr KeyLock { get; }
        public _LIST_ENTRY KCBListEntry { get; }
        public IntPtr KeyControlBlock { get; }
        public IntPtr Transaction { get; }
        public uint UoWState { get; }
        public uint ActionType { get; }
        public uint StorageType { get; }
        public IntPtr ParentUoW { get; }
        public IntPtr ChildKCB { get; }
        public uint VolatileKeyCell { get; }
        public uint OldValueCell { get; }
        public uint NewValueCell { get; }
        public uint UserFlags { get; }
        public _LARGE_INTEGER LastWriteTime { get; }
        public IntPtr TxCachedSecurity { get; }
        public uint TxSecurityCell { get; }
        public byte UpdateEntireSecurity { get; }
        public IntPtr PrepareDataPointer { get; }
        public IntPtr SecurityData { get; }
        public IntPtr ModifyKeysData { get; }
        public IntPtr SetValueData { get; }
        public IntPtr ValueData { get; }
        public IntPtr DiscardReplaceContext { get; }

        public _CM_KCB_UOW(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_KCB_UOW()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_KCB_UOW.TransactionListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.KCBLock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.KeyLock),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.KCBListEntry),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.KeyControlBlock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.Transaction),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.UoWState),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.ActionType),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.StorageType),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.ParentUoW),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.ChildKCB),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.VolatileKeyCell),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.OldValueCell),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.NewValueCell),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.UserFlags),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.LastWriteTime),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.TxCachedSecurity),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.TxSecurityCell),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.UpdateEntireSecurity),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.PrepareDataPointer),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.SecurityData),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.ModifyKeysData),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.SetValueData),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.ValueData),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_CM_KCB_UOW.DiscardReplaceContext),
                    new ulong[]
                    {
                        112UL
                    }
                }
            };
            Register<_CM_KCB_UOW>((mem, ptr) => new _CM_KCB_UOW(mem, ptr), offsets);
        }
    }
}