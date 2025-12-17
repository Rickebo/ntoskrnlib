#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _WHEA_ERROR_RECORD_HEADER_FLAGS
    {
        [FieldOffset(0)]
        public uint Recovered;
        [FieldOffset(0)]
        public uint PreviousError;
        [FieldOffset(0)]
        public uint Simulated;
        [FieldOffset(0)]
        public uint DeviceDriver;
        [FieldOffset(0)]
        public uint CriticalEvent;
        [FieldOffset(0)]
        public uint PersistPfn;
        [FieldOffset(0)]
        public uint SectionsTruncated;
        [FieldOffset(0)]
        public uint RecoveryInProgress;
        [FieldOffset(0)]
        public uint Throttle;
        [FieldOffset(0)]
        public uint Reserved;
        [FieldOffset(0)]
        public uint AsULONG;
    }
}