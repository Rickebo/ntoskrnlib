using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KLOCK_ENTRY_LOCK_STATE")]
    public sealed class _KLOCK_ENTRY_LOCK_STATE : DynamicStructure
    {
        public ulong CrossThreadReleasable { get; }
        public ulong Busy { get; }
        public ulong Reserved { get; }
        public ulong InTree { get; }
        public IntPtr LockState { get; }

        public _KLOCK_ENTRY_LOCK_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KLOCK_ENTRY_LOCK_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KLOCK_ENTRY_LOCK_STATE.CrossThreadReleasable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY_LOCK_STATE.Busy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY_LOCK_STATE.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY_LOCK_STATE.InTree),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY_LOCK_STATE.LockState),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KLOCK_ENTRY_LOCK_STATE>((mem, ptr) => new _KLOCK_ENTRY_LOCK_STATE(mem, ptr), offsets);
        }
    }
}