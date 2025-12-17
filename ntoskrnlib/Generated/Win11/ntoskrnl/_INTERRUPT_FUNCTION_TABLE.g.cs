#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public partial struct _INTERRUPT_FUNCTION_TABLE
    {
        [FieldOffset(0)]
        public IntPtr InitializeLocalUnit;
        [FieldOffset(8)]
        public IntPtr InitializeIoUnit;
        [FieldOffset(16)]
        public IntPtr SetPriority;
        [FieldOffset(24)]
        public IntPtr GetLocalUnitError;
        [FieldOffset(32)]
        public IntPtr ClearLocalUnitError;
        [FieldOffset(40)]
        public IntPtr GetLogicalId;
        [FieldOffset(48)]
        public IntPtr SetLogicalId;
        [FieldOffset(56)]
        public IntPtr AcceptAndGetSource;
        [FieldOffset(64)]
        public IntPtr EndOfInterrupt;
        [FieldOffset(72)]
        public IntPtr FastEndOfInterrupt;
        [FieldOffset(80)]
        public IntPtr SetLineState;
        [FieldOffset(88)]
        public IntPtr RequestInterrupt;
        [FieldOffset(96)]
        public IntPtr StartProcessor;
        [FieldOffset(104)]
        public IntPtr GenerateMessage;
        [FieldOffset(112)]
        public IntPtr ConvertId;
        [FieldOffset(120)]
        public IntPtr SaveLocalInterrupts;
        [FieldOffset(128)]
        public IntPtr ReplayLocalInterrupts;
        [FieldOffset(136)]
        public IntPtr DeinitializeLocalUnit;
        [FieldOffset(144)]
        public IntPtr DeinitializeIoUnit;
        [FieldOffset(152)]
        public IntPtr QueryAndGetSource;
        [FieldOffset(160)]
        public IntPtr DeactivateInterrupt;
        [FieldOffset(168)]
        public IntPtr DirectedEndOfInterrupt;
        [FieldOffset(176)]
        public IntPtr QueryLocalUnitInfo;
        [FieldOffset(184)]
        public IntPtr QueryPendingState;
        [FieldOffset(192)]
        public IntPtr CaptureGlobalCrashdumpState;
        [FieldOffset(200)]
        public IntPtr CaptureProcessorCrashdumpState;
    }
}