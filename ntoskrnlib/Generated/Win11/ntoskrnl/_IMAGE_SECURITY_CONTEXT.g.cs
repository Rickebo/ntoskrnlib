#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _IMAGE_SECURITY_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr PageHashes;
        [FieldOffset(0)]
        public ulong Value;
        [FieldOffset(0)]
        public ulong SecurityBeingCreated;
        [FieldOffset(0)]
        public ulong SecurityMandatory;
        [FieldOffset(0)]
        public ulong PageHashPointer;
    }
}