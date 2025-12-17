using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NONOPAQUE_OPLOCK")]
    public sealed class _NONOPAQUE_OPLOCK : DynamicStructure
    {
        public IntPtr IrpExclusiveOplock { get; }
        public IntPtr FileObject { get; }
        public IntPtr ExclusiveOplockOwner { get; }
        public IntPtr ExclusiveOplockOwnerThread { get; }
        public byte WaiterPriority { get; }
        public _LIST_ENTRY IrpOplocksR { get; }
        public _LIST_ENTRY IrpOplocksRH { get; }
        public _LIST_ENTRY RHBreakQueue { get; }
        public _LIST_ENTRY WaitingIrps { get; }
        public _LIST_ENTRY DelayAckFileObjectQueue { get; }
        public _LIST_ENTRY AtomicQueue { get; }
        public IntPtr DeleterParentKey { get; }
        public uint OplockState { get; }
        public IntPtr FastMutex { get; }
        public _OPLOCK_TELEMETRY TelemetryData { get; }
        public IntPtr AckTimeout { get; }

        public _NONOPAQUE_OPLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NONOPAQUE_OPLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NONOPAQUE_OPLOCK.IrpExclusiveOplock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.FileObject),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.ExclusiveOplockOwner),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.ExclusiveOplockOwnerThread),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.WaiterPriority),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.IrpOplocksR),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.IrpOplocksRH),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.RHBreakQueue),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.WaitingIrps),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.DelayAckFileObjectQueue),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.AtomicQueue),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.DeleterParentKey),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.OplockState),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.FastMutex),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.TelemetryData),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_NONOPAQUE_OPLOCK.AckTimeout),
                    new ulong[]
                    {
                        176UL
                    }
                }
            };
            Register<_NONOPAQUE_OPLOCK>((mem, ptr) => new _NONOPAQUE_OPLOCK(mem, ptr), offsets);
        }
    }
}