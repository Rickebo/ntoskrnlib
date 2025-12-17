#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _IO_STACK_LOCATION
    {
        [FieldOffset(0)]
        public byte MajorFunction;
        [FieldOffset(1)]
        public byte MinorFunction;
        [FieldOffset(2)]
        public byte Flags;
        [FieldOffset(3)]
        public byte Control;
        [FieldOffset(8)]
        public _unnamed_tag_ Parameters;
        [FieldOffset(40)]
        public IntPtr DeviceObject;
        [FieldOffset(48)]
        public IntPtr FileObject;
        [FieldOffset(56)]
        public IntPtr CompletionRoutine;
        [FieldOffset(64)]
        public IntPtr Context;
    }
}