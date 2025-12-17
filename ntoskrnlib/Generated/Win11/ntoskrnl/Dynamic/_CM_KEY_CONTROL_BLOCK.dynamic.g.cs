using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_KEY_CONTROL_BLOCK")]
    public sealed class _CM_KEY_CONTROL_BLOCK : DynamicStructure
    {
        public ulong RefCount { get; }
        public uint ExtFlags { get; }
        public uint Freed { get; }
        public uint Discarded { get; }
        public uint HiveUnloaded { get; }
        public uint Decommissioned { get; }
        public uint SpareExtFlag { get; }
        public uint TotalLevels { get; }
        public _CM_KEY_HASH KeyHash { get; }
        public _CM_PATH_HASH ConvKey { get; }
        public IntPtr NextHash { get; }
        public IntPtr KeyHive { get; }
        public uint KeyCell { get; }
        public _EX_PUSH_LOCK KcbPushlock { get; }
        public IntPtr Owner { get; }
        public int SharedCount { get; }
        public byte DelayedDeref { get; }
        public byte DelayedClose { get; }
        public byte Parking { get; }
        public byte LayerSemantics { get; }
        public short LayerHeight { get; }
        public uint Spare1 { get; }
        public IntPtr ParentKcb { get; }
        public IntPtr NameBlock { get; }
        public IntPtr CachedSecurity { get; }
        public _CHILD_LIST ValueList { get; }
        public IntPtr LinkTarget { get; }
        public IntPtr IndexHint { get; }
        public uint HashKey { get; }
        public uint SubKeyCount { get; }
        public _LIST_ENTRY KeyBodyListHead { get; }
        public _LIST_ENTRY ClonedListEntry { get; }
        public byte[] KeyBodyArray { get; }
        public _LARGE_INTEGER KcbLastWriteTime { get; }
        public ushort KcbMaxNameLen { get; }
        public ushort KcbMaxValueNameLen { get; }
        public uint KcbMaxValueDataLen { get; }
        public uint KcbUserFlags { get; }
        public uint KcbVirtControlFlags { get; }
        public uint KcbDebug { get; }
        public uint Flags { get; }
        public uint Spare3 { get; }
        public IntPtr LayerInfo { get; }
        public IntPtr RealKeyName { get; }
        public _LIST_ENTRY KCBUoWListHead { get; }
        public _LIST_ENTRY DelayQueueEntry { get; }
        public IntPtr Stolen { get; }
        public IntPtr TransKCBOwner { get; }
        public _CM_INTENT_LOCK KCBLock { get; }
        public _CM_INTENT_LOCK KeyLock { get; }
        public _CHILD_LIST TransValueCache { get; }
        public IntPtr TransValueListOwner { get; }
        public IntPtr FullKCBName { get; }
        public ulong FullKCBNameStale { get; }
        public ulong Reserved { get; }
        public ulong SequenceNumber { get; }

        public _CM_KEY_CONTROL_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_KEY_CONTROL_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.RefCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.ExtFlags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.Freed),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.Discarded),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.HiveUnloaded),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.Decommissioned),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.SpareExtFlag),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.TotalLevels),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KeyHash),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.ConvKey),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.NextHash),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KeyHive),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KeyCell),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KcbPushlock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.Owner),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.SharedCount),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.DelayedDeref),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.DelayedClose),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.Parking),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.LayerSemantics),
                    new ulong[]
                    {
                        65UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.LayerHeight),
                    new ulong[]
                    {
                        66UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.Spare1),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.ParentKcb),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.NameBlock),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.CachedSecurity),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.ValueList),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.LinkTarget),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.IndexHint),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.HashKey),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.SubKeyCount),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KeyBodyListHead),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.ClonedListEntry),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KeyBodyArray),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KcbLastWriteTime),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KcbMaxNameLen),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KcbMaxValueNameLen),
                    new ulong[]
                    {
                        178UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KcbMaxValueDataLen),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KcbUserFlags),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KcbVirtControlFlags),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KcbDebug),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.Flags),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.Spare3),
                    new ulong[]
                    {
                        188UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.LayerInfo),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.RealKeyName),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KCBUoWListHead),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.DelayQueueEntry),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.Stolen),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.TransKCBOwner),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KCBLock),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.KeyLock),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.TransValueCache),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.TransValueListOwner),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.FullKCBName),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.FullKCBNameStale),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.Reserved),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_CM_KEY_CONTROL_BLOCK.SequenceNumber),
                    new ulong[]
                    {
                        304UL
                    }
                }
            };
            Register<_CM_KEY_CONTROL_BLOCK>((mem, ptr) => new _CM_KEY_CONTROL_BLOCK(mem, ptr), offsets);
        }
    }
}