using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KCLOCK_INCREMENT_TRACE")]
    public sealed class _KCLOCK_INCREMENT_TRACE : DynamicStructure
    {
        public uint ActualIncrement { get; }
        public uint RequestedIncrement { get; }
        public ulong InterruptTime { get; }
        public ulong PerformanceCounter { get; }
        public byte OneShot { get; }

        public _KCLOCK_INCREMENT_TRACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KCLOCK_INCREMENT_TRACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KCLOCK_INCREMENT_TRACE.ActualIncrement),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KCLOCK_INCREMENT_TRACE.RequestedIncrement),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KCLOCK_INCREMENT_TRACE.InterruptTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KCLOCK_INCREMENT_TRACE.PerformanceCounter),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KCLOCK_INCREMENT_TRACE.OneShot),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_KCLOCK_INCREMENT_TRACE>((mem, ptr) => new _KCLOCK_INCREMENT_TRACE(mem, ptr), offsets);
        }
    }
}