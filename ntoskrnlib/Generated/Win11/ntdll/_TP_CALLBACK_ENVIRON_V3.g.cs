#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _TP_CALLBACK_ENVIRON_V3
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(8)]
        public IntPtr Pool;
        [FieldOffset(16)]
        public IntPtr CleanupGroup;
        [FieldOffset(24)]
        public IntPtr CleanupGroupCancelCallback;
        [FieldOffset(32)]
        public IntPtr RaceDll;
        [FieldOffset(40)]
        public IntPtr ActivationContext;
        [FieldOffset(48)]
        public IntPtr FinalizationCallback;
        [FieldOffset(56)]
        public _unnamed_tag_ u;
        [FieldOffset(60)]
        public uint CallbackPriority;
        [FieldOffset(64)]
        public uint Size;
    }
}