#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MI_PFN_FLAGS
    {
        [FieldOffset(0)]
        public ushort ReferenceCount;
        [FieldOffset(2)]
        public byte PageLocation;
        [FieldOffset(2)]
        public byte WriteInProgress;
        [FieldOffset(2)]
        public byte Modified;
        [FieldOffset(2)]
        public byte ReadInProgress;
        [FieldOffset(2)]
        public byte CacheAttribute;
        [FieldOffset(3)]
        public byte Priority;
        [FieldOffset(3)]
        public byte OnProtectedStandby;
        [FieldOffset(3)]
        public byte InPageError;
        [FieldOffset(3)]
        public byte SystemChargedPage;
        [FieldOffset(3)]
        public byte RemovalRequested;
        [FieldOffset(3)]
        public byte ParityError;
        [FieldOffset(0)]
        public uint EntireField;
    }
}