using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KAPC")]
    public sealed class _KAPC : DynamicStructure
    {
        public byte Type { get; }
        public byte AllFlags { get; }
        public byte CallbackDataContext { get; }
        public byte Unused { get; }
        public byte Size { get; }
        public byte SpareByte1 { get; }
        public uint SpareLong0 { get; }
        public IntPtr Thread { get; }
        public _LIST_ENTRY ApcListEntry { get; }
        public IntPtr KernelRoutine { get; }
        public IntPtr RundownRoutine { get; }
        public IntPtr NormalRoutine { get; }
        public byte[] Reserved { get; }
        public IntPtr NormalContext { get; }
        public IntPtr SystemArgument1 { get; }
        public IntPtr SystemArgument2 { get; }
        public sbyte ApcStateIndex { get; }
        public sbyte ApcMode { get; }
        public byte Inserted { get; }

        public _KAPC(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KAPC()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KAPC.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KAPC.AllFlags),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_KAPC.CallbackDataContext),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_KAPC.Unused),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_KAPC.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_KAPC.SpareByte1),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_KAPC.SpareLong0),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KAPC.Thread),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KAPC.ApcListEntry),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KAPC.KernelRoutine),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KAPC.RundownRoutine),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KAPC.NormalRoutine),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KAPC.Reserved),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KAPC.NormalContext),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KAPC.SystemArgument1),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KAPC.SystemArgument2),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KAPC.ApcStateIndex),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_KAPC.ApcMode),
                    new ulong[]
                    {
                        81UL
                    }
                },
                {
                    nameof(_KAPC.Inserted),
                    new ulong[]
                    {
                        82UL
                    }
                }
            };
            Register<_KAPC>((mem, ptr) => new _KAPC(mem, ptr), offsets);
        }
    }
}