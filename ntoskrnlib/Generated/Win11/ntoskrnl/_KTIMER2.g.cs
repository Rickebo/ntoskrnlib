#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public partial struct _KTIMER2
    {
        [FieldOffset(0)]
        public _DISPATCHER_HEADER Header;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _RTL_BALANCED_NODE[] RbNodes;
        [FieldOffset(24)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(72)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] DueTime;
        [FieldOffset(88)]
        public long Period;
        [FieldOffset(96)]
        public IntPtr Callback;
        [FieldOffset(104)]
        public IntPtr CallbackContext;
        [FieldOffset(112)]
        public IntPtr DisableCallback;
        [FieldOffset(120)]
        public IntPtr DisableContext;
        [FieldOffset(128)]
        public byte AbsoluteSystemTime;
        [FieldOffset(129)]
        public byte TypeFlags;
        [FieldOffset(129)]
        public byte Unused;
        [FieldOffset(129)]
        public byte IdleResilient;
        [FieldOffset(129)]
        public byte HighResolution;
        [FieldOffset(129)]
        public byte NoWake;
        [FieldOffset(129)]
        public byte PseudoHighRes;
        [FieldOffset(129)]
        public byte AusterityResilient;
        [FieldOffset(129)]
        public byte Unused1;
        [FieldOffset(130)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] CollectionIndex;
    }
}