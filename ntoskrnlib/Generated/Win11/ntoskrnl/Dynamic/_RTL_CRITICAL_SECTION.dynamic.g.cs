using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_CRITICAL_SECTION")]
    public sealed class _RTL_CRITICAL_SECTION : DynamicStructure
    {
        public IntPtr DebugInfo { get; }
        public int LockCount { get; }
        public int RecursionCount { get; }
        public IntPtr OwningThread { get; }
        public IntPtr LockSemaphore { get; }
        public ulong SpinCount { get; }

        public _RTL_CRITICAL_SECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_CRITICAL_SECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_CRITICAL_SECTION.DebugInfo),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_CRITICAL_SECTION.LockCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_CRITICAL_SECTION.RecursionCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_RTL_CRITICAL_SECTION.OwningThread),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_CRITICAL_SECTION.LockSemaphore),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTL_CRITICAL_SECTION.SpinCount),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_RTL_CRITICAL_SECTION>((mem, ptr) => new _RTL_CRITICAL_SECTION(mem, ptr), offsets);
        }
    }
}