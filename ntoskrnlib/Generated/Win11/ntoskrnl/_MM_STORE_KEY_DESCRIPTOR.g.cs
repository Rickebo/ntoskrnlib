#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _MM_STORE_KEY_DESCRIPTOR
    {
        [FieldOffset(0)]
        public ulong ContainerKey;
        [FieldOffset(8)]
        public _MM_STORE_SUB_KEY_DESCRIPTOR SubKey;
    }
}