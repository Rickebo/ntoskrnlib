#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _CM_COMPONENT_HASH
    {
        [FieldOffset(0)]
        public uint Hash;
    }
}