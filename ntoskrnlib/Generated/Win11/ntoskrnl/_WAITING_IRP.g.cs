#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _WAITING_IRP
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Links;
        [FieldOffset(16)]
        public IntPtr Irp;
        [FieldOffset(24)]
        public IntPtr CompletionRoutine;
        [FieldOffset(32)]
        public IntPtr Context;
        [FieldOffset(40)]
        public IntPtr Event;
        [FieldOffset(48)]
        public uint Information;
        [FieldOffset(52)]
        public byte BreakAllRH;
        [FieldOffset(53)]
        public byte OplockBreakNotify;
        [FieldOffset(56)]
        public IntPtr FileObject;
    }
}