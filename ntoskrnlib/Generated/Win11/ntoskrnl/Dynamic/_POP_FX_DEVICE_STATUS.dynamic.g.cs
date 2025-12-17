using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_DEVICE_STATUS")]
    public sealed class _POP_FX_DEVICE_STATUS : DynamicStructure
    {
        public int Value { get; }
        public uint SystemTransition { get; }
        public uint PepD0Notify { get; }
        public uint IdleTimerOn { get; }
        public uint IgnoreIdleTimeout { get; }
        public uint IrpInUse { get; }
        public uint IrpPending { get; }
        public uint DPNRDeviceNotified { get; }
        public uint DPNRReceivedFromPep { get; }
        public uint IrpFirstPendingIndex { get; }
        public uint IrpLastPendingIndex { get; }
        public uint SIrpBlocked { get; }
        public uint BlockFastResume { get; }
        public uint DirectedPoweredDown { get; }
        public uint DirectedTransitionInProgress { get; }
        public uint Reserved { get; }

        public _POP_FX_DEVICE_STATUS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_DEVICE_STATUS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_DEVICE_STATUS.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.SystemTransition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.PepD0Notify),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.IdleTimerOn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.IgnoreIdleTimeout),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.IrpInUse),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.IrpPending),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.DPNRDeviceNotified),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.DPNRReceivedFromPep),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.IrpFirstPendingIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.IrpLastPendingIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.SIrpBlocked),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.BlockFastResume),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.DirectedPoweredDown),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.DirectedTransitionInProgress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_STATUS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_POP_FX_DEVICE_STATUS>((mem, ptr) => new _POP_FX_DEVICE_STATUS(mem, ptr), offsets);
        }
    }
}