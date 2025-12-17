using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTIMER_EXPIRATION_TRACE")]
    public sealed class _KTIMER_EXPIRATION_TRACE : DynamicStructure
    {
        public ulong InterruptTime { get; }
        public _LARGE_INTEGER PerformanceCounter { get; }

        public _KTIMER_EXPIRATION_TRACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTIMER_EXPIRATION_TRACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTIMER_EXPIRATION_TRACE.InterruptTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTIMER_EXPIRATION_TRACE.PerformanceCounter),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_KTIMER_EXPIRATION_TRACE>((mem, ptr) => new _KTIMER_EXPIRATION_TRACE(mem, ptr), offsets);
        }
    }
}