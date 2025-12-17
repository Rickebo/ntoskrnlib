#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _POWER_LIMIT_VALUE
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public uint DomainId;
        [FieldOffset(8)]
        public uint TargetValue;
        [FieldOffset(12)]
        public uint TimeParameter;
    }
}