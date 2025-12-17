using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CALL_HASH_ENTRY")]
    public sealed class _CALL_HASH_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr CallersAddress { get; }
        public IntPtr CallersCaller { get; }
        public uint CallCount { get; }

        public _CALL_HASH_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CALL_HASH_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CALL_HASH_ENTRY.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CALL_HASH_ENTRY.CallersAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CALL_HASH_ENTRY.CallersCaller),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CALL_HASH_ENTRY.CallCount),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_CALL_HASH_ENTRY>((mem, ptr) => new _CALL_HASH_ENTRY(mem, ptr), offsets);
        }
    }
}