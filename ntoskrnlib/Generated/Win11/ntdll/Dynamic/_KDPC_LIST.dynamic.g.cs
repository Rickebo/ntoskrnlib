using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KDPC_LIST")]
    public sealed class _KDPC_LIST : DynamicStructure
    {
        public _SINGLE_LIST_ENTRY ListHead { get; }
        public IntPtr LastEntry { get; }

        public _KDPC_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KDPC_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KDPC_LIST.ListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KDPC_LIST.LastEntry),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_KDPC_LIST>((mem, ptr) => new _KDPC_LIST(mem, ptr), offsets);
        }
    }
}