#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _AMD_MCA_IPID
    {
        [FieldOffset(0)]
        public ulong InstanceId;
        [FieldOffset(0)]
        public ulong HardwareId;
        [FieldOffset(0)]
        public ulong Reserved;
        [FieldOffset(0)]
        public ulong McaType;
        [FieldOffset(0)]
        public ulong AsUINT64;
    }
}