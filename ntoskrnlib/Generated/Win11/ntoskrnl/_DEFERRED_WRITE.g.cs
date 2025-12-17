#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct _DEFERRED_WRITE
    {
        [FieldOffset(0)]
        public short NodeTypeCode;
        [FieldOffset(2)]
        public short NodeByteSize;
        [FieldOffset(8)]
        public IntPtr FileObject;
        [FieldOffset(16)]
        public uint BytesToWrite;
        [FieldOffset(24)]
        public _LIST_ENTRY DeferredWriteLinks;
        [FieldOffset(40)]
        public IntPtr Event;
        [FieldOffset(48)]
        public IntPtr PostRoutine;
        [FieldOffset(56)]
        public IntPtr Context1;
        [FieldOffset(64)]
        public IntPtr Context2;
        [FieldOffset(72)]
        public IntPtr Partition;
        [FieldOffset(80)]
        public IntPtr PrivateVolumeCacheMap;
        [FieldOffset(88)]
        public byte SoftThrottle;
        [FieldOffset(96)]
        public _LARGE_INTEGER TimeAdded;
    }
}