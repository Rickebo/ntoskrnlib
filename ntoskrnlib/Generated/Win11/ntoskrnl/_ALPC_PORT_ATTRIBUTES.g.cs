#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _ALPC_PORT_ATTRIBUTES
    {
        [FieldOffset(0)]
        public uint Flags;
        [FieldOffset(4)]
        public _SECURITY_QUALITY_OF_SERVICE SecurityQos;
        [FieldOffset(16)]
        public ulong MaxMessageLength;
        [FieldOffset(24)]
        public ulong MemoryBandwidth;
        [FieldOffset(32)]
        public ulong MaxPoolUsage;
        [FieldOffset(40)]
        public ulong MaxSectionSize;
        [FieldOffset(48)]
        public ulong MaxViewSize;
        [FieldOffset(56)]
        public ulong MaxTotalSectionSize;
        [FieldOffset(64)]
        public uint DupObjectTypes;
        [FieldOffset(68)]
        public uint Reserved;
    }
}