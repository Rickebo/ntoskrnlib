using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_TRIM_STATE")]
    public sealed class _MI_SYSTEM_TRIM_STATE : DynamicStructure
    {
        public int ExpansionLock { get; }
        public int TrimInProgressCount { get; }
        public _KEVENT PeriodicWorkingSetEvent { get; }
        public _MI_VERIFIER_TRIM_STATE Verifier { get; }
        public uint[] TrimAllPageFaultCount { get; }
        public IntPtr EmptyAllThread { get; }
        public uint FaultedInSystemPage { get; }

        public _MI_SYSTEM_TRIM_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SYSTEM_TRIM_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SYSTEM_TRIM_STATE.ExpansionLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_TRIM_STATE.TrimInProgressCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_TRIM_STATE.PeriodicWorkingSetEvent),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_TRIM_STATE.Verifier),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_TRIM_STATE.TrimAllPageFaultCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_TRIM_STATE.EmptyAllThread),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_TRIM_STATE.FaultedInSystemPage),
                    new ulong[]
                    {
                        88UL
                    }
                }
            };
            Register<_MI_SYSTEM_TRIM_STATE>((mem, ptr) => new _MI_SYSTEM_TRIM_STATE(mem, ptr), offsets);
        }
    }
}