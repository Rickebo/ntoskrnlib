using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KWAIT_CHAIN_ENTRY")]
    public sealed class _KWAIT_CHAIN_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr Thread { get; }
        public _KEVENT Event { get; }
        public IntPtr AbLockHandle { get; }

        public _KWAIT_CHAIN_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KWAIT_CHAIN_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KWAIT_CHAIN_ENTRY.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KWAIT_CHAIN_ENTRY.Thread),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KWAIT_CHAIN_ENTRY.Event),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KWAIT_CHAIN_ENTRY.AbLockHandle),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_KWAIT_CHAIN_ENTRY>((mem, ptr) => new _KWAIT_CHAIN_ENTRY(mem, ptr), offsets);
        }
    }
}