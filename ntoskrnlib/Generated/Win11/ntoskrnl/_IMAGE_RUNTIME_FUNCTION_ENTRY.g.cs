#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _IMAGE_RUNTIME_FUNCTION_ENTRY
    {
        [FieldOffset(0)]
        public uint BeginAddress;
        [FieldOffset(4)]
        public uint EndAddress;
        [FieldOffset(8)]
        public uint UnwindInfoAddress;
        [FieldOffset(8)]
        public uint UnwindData;
    }
}