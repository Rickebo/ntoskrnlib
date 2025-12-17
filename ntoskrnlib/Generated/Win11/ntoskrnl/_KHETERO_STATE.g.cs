#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _KHETERO_STATE
    {
        [FieldOffset(0)]
        public byte Qos;
        [FieldOffset(0)]
        public byte WorkloadClass;
        [FieldOffset(0)]
        public byte RunningType;
        [FieldOffset(0)]
        public byte AllFields;
    }
}