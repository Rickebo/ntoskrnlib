#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _MI_SYSTEM_NODE_AFFINITY_INFORMATION
    {
        [FieldOffset(0)]
        public IntPtr GroupAffinity;
        [FieldOffset(8)]
        public uint NumberOfDomains;
        [FieldOffset(12)]
        public uint GlobalDomainIndex;
        [FieldOffset(16)]
        public ushort GroupAffinityCount;
        [FieldOffset(18)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ushort[] ProcessorCount;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ushort[] UsableProcessorCount;
    }
}