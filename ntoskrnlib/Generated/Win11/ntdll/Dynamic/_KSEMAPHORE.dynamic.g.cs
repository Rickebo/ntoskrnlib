using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KSEMAPHORE")]
    public sealed class _KSEMAPHORE : DynamicStructure
    {
        public _DISPATCHER_HEADER Header { get; }
        public int Limit { get; }

        public _KSEMAPHORE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSEMAPHORE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSEMAPHORE.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSEMAPHORE.Limit),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_KSEMAPHORE>((mem, ptr) => new _KSEMAPHORE(mem, ptr), offsets);
        }
    }
}