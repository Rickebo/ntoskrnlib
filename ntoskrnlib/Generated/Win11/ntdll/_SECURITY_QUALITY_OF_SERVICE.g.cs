#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _SECURITY_QUALITY_OF_SERVICE
    {
        [FieldOffset(0)]
        public uint Length;
        [FieldOffset(4)]
        public uint ImpersonationLevel;
        [FieldOffset(8)]
        public byte ContextTrackingMode;
        [FieldOffset(9)]
        public byte EffectiveOnly;
    }
}