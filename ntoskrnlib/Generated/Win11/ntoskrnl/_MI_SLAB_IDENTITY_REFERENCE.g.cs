#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MI_SLAB_IDENTITY_REFERENCE
    {
        [FieldOffset(0)]
        public long ReferenceCount;
    }
}