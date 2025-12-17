using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_REG_ENTRY")]
    public sealed class _ETW_REG_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY RegList { get; }
        public _LIST_ENTRY GroupRegList { get; }
        public IntPtr GuidEntry { get; }
        public IntPtr GroupEntry { get; }
        public IntPtr ReplyQueue { get; }
        public byte[] ReplySlot { get; }
        public IntPtr Caller { get; }
        public uint SessionId { get; }
        public IntPtr Process { get; }
        public IntPtr CallbackContext { get; }
        public IntPtr Callback { get; }
        public ushort Index { get; }
        public ushort Flags { get; }
        public ushort DbgKernelRegistration { get; }
        public ushort DbgUserRegistration { get; }
        public ushort DbgReplyRegistration { get; }
        public ushort DbgClassicRegistration { get; }
        public ushort DbgSessionSpaceRegistration { get; }
        public ushort DbgModernRegistration { get; }
        public ushort DbgClosed { get; }
        public ushort DbgInserted { get; }
        public ushort DbgWow64 { get; }
        public ushort DbgUseDescriptorType { get; }
        public ushort DbgDropProviderTraits { get; }
        public byte EnableMask { get; }
        public byte GroupEnableMask { get; }
        public byte HostEnableMask { get; }
        public byte HostGroupEnableMask { get; }
        public IntPtr Traits { get; }

        public _ETW_REG_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_REG_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_REG_ENTRY.RegList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.GroupRegList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.GuidEntry),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.GroupEntry),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.ReplyQueue),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.ReplySlot),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.Caller),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.SessionId),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.Process),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.CallbackContext),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.Callback),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.Index),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.Flags),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.DbgKernelRegistration),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.DbgUserRegistration),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.DbgReplyRegistration),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.DbgClassicRegistration),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.DbgSessionSpaceRegistration),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.DbgModernRegistration),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.DbgClosed),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.DbgInserted),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.DbgWow64),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.DbgUseDescriptorType),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.DbgDropProviderTraits),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.EnableMask),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.GroupEnableMask),
                    new ulong[]
                    {
                        101UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.HostEnableMask),
                    new ulong[]
                    {
                        102UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.HostGroupEnableMask),
                    new ulong[]
                    {
                        103UL
                    }
                },
                {
                    nameof(_ETW_REG_ENTRY.Traits),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_ETW_REG_ENTRY>((mem, ptr) => new _ETW_REG_ENTRY(mem, ptr), offsets);
        }
    }
}