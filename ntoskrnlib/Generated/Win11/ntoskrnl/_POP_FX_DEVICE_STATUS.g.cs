#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _POP_FX_DEVICE_STATUS
    {
        [FieldOffset(0)]
        public int Value;
        [FieldOffset(0)]
        public uint SystemTransition;
        [FieldOffset(0)]
        public uint PepD0Notify;
        [FieldOffset(0)]
        public uint IdleTimerOn;
        [FieldOffset(0)]
        public uint IgnoreIdleTimeout;
        [FieldOffset(0)]
        public uint IrpInUse;
        [FieldOffset(0)]
        public uint IrpPending;
        [FieldOffset(0)]
        public uint DPNRDeviceNotified;
        [FieldOffset(0)]
        public uint DPNRReceivedFromPep;
        [FieldOffset(0)]
        public uint IrpFirstPendingIndex;
        [FieldOffset(0)]
        public uint IrpLastPendingIndex;
        [FieldOffset(0)]
        public uint SIrpBlocked;
        [FieldOffset(0)]
        public uint BlockFastResume;
        [FieldOffset(0)]
        public uint DirectedPoweredDown;
        [FieldOffset(0)]
        public uint DirectedTransitionInProgress;
        [FieldOffset(0)]
        public uint Reserved;
    }
}