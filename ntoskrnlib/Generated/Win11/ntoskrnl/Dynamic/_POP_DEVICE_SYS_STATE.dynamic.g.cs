using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_DEVICE_SYS_STATE")]
    public sealed class _POP_DEVICE_SYS_STATE : DynamicStructure
    {
        public byte IrpMinor { get; }
        public uint SystemState { get; }
        public ulong SpinLock { get; }
        public IntPtr Thread { get; }
        public IntPtr AbortEvent { get; }
        public IntPtr ReadySemaphore { get; }
        public IntPtr FinishedSemaphore { get; }
        public _PO_DEVICE_NOTIFY_ORDER Order { get; }
        public _LIST_ENTRY Pending { get; }
        public int Status { get; }
        public IntPtr FailedDevice { get; }
        public byte Waking { get; }
        public byte Cancelled { get; }
        public byte IgnoreErrors { get; }
        public byte IgnoreNotImplemented { get; }
        public byte TimeRefreshLockAcquired { get; }

        public _POP_DEVICE_SYS_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_DEVICE_SYS_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_DEVICE_SYS_STATE.IrpMinor),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.SystemState),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.SpinLock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.Thread),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.AbortEvent),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.ReadySemaphore),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.FinishedSemaphore),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.Order),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.Pending),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.Status),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.FailedDevice),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.Waking),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.Cancelled),
                    new ulong[]
                    {
                        465UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.IgnoreErrors),
                    new ulong[]
                    {
                        466UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.IgnoreNotImplemented),
                    new ulong[]
                    {
                        467UL
                    }
                },
                {
                    nameof(_POP_DEVICE_SYS_STATE.TimeRefreshLockAcquired),
                    new ulong[]
                    {
                        468UL
                    }
                }
            };
            Register<_POP_DEVICE_SYS_STATE>((mem, ptr) => new _POP_DEVICE_SYS_STATE(mem, ptr), offsets);
        }
    }
}