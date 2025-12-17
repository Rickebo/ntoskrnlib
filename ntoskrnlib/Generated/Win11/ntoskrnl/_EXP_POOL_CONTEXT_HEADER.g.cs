#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _EXP_POOL_CONTEXT_HEADER
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public uint ContextType;
    }
}