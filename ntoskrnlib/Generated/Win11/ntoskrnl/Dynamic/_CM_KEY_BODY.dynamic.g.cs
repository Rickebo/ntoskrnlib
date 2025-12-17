using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_KEY_BODY")]
    public sealed class _CM_KEY_BODY : DynamicStructure
    {
        public uint Type { get; }
        public ushort AccessCheckedLayerHeight { get; }
        public IntPtr KeyControlBlock { get; }
        public IntPtr NotifyBlock { get; }
        public IntPtr ProcessID { get; }
        public _LIST_ENTRY KeyBodyList { get; }
        public uint Flags { get; }
        public uint HandleTags { get; }
        public _CM_TRANS_PTR Trans { get; }
        public IntPtr KtmUow { get; }
        public _LIST_ENTRY ContextListHead { get; }
        public IntPtr EnumerationResumeContext { get; }
        public uint RestrictedAccessMask { get; }
        public uint LastSearchedIndex { get; }
        public IntPtr LockedMemoryMdls { get; }

        public _CM_KEY_BODY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_KEY_BODY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_KEY_BODY.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.AccessCheckedLayerHeight),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.KeyControlBlock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.NotifyBlock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.ProcessID),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.KeyBodyList),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.Flags),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.HandleTags),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.Trans),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.KtmUow),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.ContextListHead),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.EnumerationResumeContext),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.RestrictedAccessMask),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.LastSearchedIndex),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_CM_KEY_BODY.LockedMemoryMdls),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_CM_KEY_BODY>((mem, ptr) => new _CM_KEY_BODY(mem, ptr), offsets);
        }
    }
}