using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KEVENT")]
    public sealed class _KEVENT : DynamicStructure
    {
        public _DISPATCHER_HEADER Header { get; }

        public _KEVENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KEVENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KEVENT.Header),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KEVENT>((mem, ptr) => new _KEVENT(mem, ptr), offsets);
        }
    }
}