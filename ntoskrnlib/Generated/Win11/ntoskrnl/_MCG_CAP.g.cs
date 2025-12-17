#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MCG_CAP
    {
        [FieldOffset(0)]
        public ulong CountField;
        [FieldOffset(0)]
        public ulong ControlMsrPresent;
        [FieldOffset(0)]
        public ulong ExtendedMsrsPresent;
        [FieldOffset(0)]
        public ulong SignalingExtensionPresent;
        [FieldOffset(0)]
        public ulong ThresholdErrorStatusPresent;
        [FieldOffset(0)]
        public ulong Reserved;
        [FieldOffset(0)]
        public ulong ExtendedRegisterCount;
        [FieldOffset(0)]
        public ulong SoftwareErrorRecoverySupported;
        [FieldOffset(0)]
        public ulong EnhancedMachineCheckCapability;
        [FieldOffset(0)]
        public ulong ExtendedErrorLogging;
        [FieldOffset(0)]
        public ulong LocalMachineCheckException;
        [FieldOffset(0)]
        public ulong QuadPart;
    }
}