#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _KTRANSACTION_HISTORY
    {
        [FieldOffset(0)]
        public uint RecordType;
        [FieldOffset(4)]
        public uint Payload;
    }
}