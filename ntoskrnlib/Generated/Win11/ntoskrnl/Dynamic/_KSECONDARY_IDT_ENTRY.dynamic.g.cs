using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSECONDARY_IDT_ENTRY")]
    public sealed class _KSECONDARY_IDT_ENTRY : DynamicStructure
    {
        public ulong SpinLock { get; }
        public _KEVENT ConnectLock { get; }
        public byte LineMasked { get; }
        public IntPtr InterruptList { get; }

        public _KSECONDARY_IDT_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSECONDARY_IDT_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSECONDARY_IDT_ENTRY.SpinLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSECONDARY_IDT_ENTRY.ConnectLock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KSECONDARY_IDT_ENTRY.LineMasked),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KSECONDARY_IDT_ENTRY.InterruptList),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_KSECONDARY_IDT_ENTRY>((mem, ptr) => new _KSECONDARY_IDT_ENTRY(mem, ptr), offsets);
        }
    }
}