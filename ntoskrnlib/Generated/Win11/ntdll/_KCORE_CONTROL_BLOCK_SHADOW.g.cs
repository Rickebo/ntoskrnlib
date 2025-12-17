#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _KCORE_CONTROL_BLOCK_SHADOW
    {
        [FieldOffset(0)]
        public ulong Lock;
        [FieldOffset(8)]
        public ulong CurrentIsolationDomain;
        [FieldOffset(16)]
        public ulong NextIsolationDomain;
        [FieldOffset(24)]
        public byte TotalProcessors;
        [FieldOffset(25)]
        public byte IdleProcessors;
        [FieldOffset(26)]
        public byte NewDomainProcessors;
        [FieldOffset(27)]
        public byte Spare;
        [FieldOffset(28)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _KCCB_SHADOW_PROCESSOR_STATE[] ProcessorStates;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] InterruptTargets;
    }
}