#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _MMPFNENTRY3
    {
        [FieldOffset(0)]
        public byte Priority;
        [FieldOffset(0)]
        public byte OnProtectedStandby;
        [FieldOffset(0)]
        public byte InPageError;
        [FieldOffset(0)]
        public byte SystemChargedPage;
        [FieldOffset(0)]
        public byte RemovalRequested;
        [FieldOffset(0)]
        public byte ParityError;
    }
}