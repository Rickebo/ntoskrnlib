#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _KAPC
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte AllFlags;
        [FieldOffset(1)]
        public byte CallbackDataContext;
        [FieldOffset(1)]
        public byte Unused;
        [FieldOffset(2)]
        public byte Size;
        [FieldOffset(3)]
        public byte SpareByte1;
        [FieldOffset(4)]
        public uint SpareLong0;
        [FieldOffset(8)]
        public IntPtr Thread;
        [FieldOffset(16)]
        public _LIST_ENTRY ApcListEntry;
        [FieldOffset(32)]
        public IntPtr KernelRoutine;
        [FieldOffset(40)]
        public IntPtr RundownRoutine;
        [FieldOffset(48)]
        public IntPtr NormalRoutine;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public IntPtr[] Reserved;
        [FieldOffset(56)]
        public IntPtr NormalContext;
        [FieldOffset(64)]
        public IntPtr SystemArgument1;
        [FieldOffset(72)]
        public IntPtr SystemArgument2;
        [FieldOffset(80)]
        public sbyte ApcStateIndex;
        [FieldOffset(81)]
        public sbyte ApcMode;
        [FieldOffset(82)]
        public byte Inserted;
    }
}