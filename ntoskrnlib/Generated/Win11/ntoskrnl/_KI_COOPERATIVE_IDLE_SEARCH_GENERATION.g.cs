#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _KI_COOPERATIVE_IDLE_SEARCH_GENERATION
    {
        [FieldOffset(0)]
        public _KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID GenerationId;
        [FieldOffset(8)]
        public ushort AllocatedTargetEntries;
        [FieldOffset(10)]
        public ushort ActiveTargetEntries;
        [FieldOffset(12)]
        public uint Spare;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] ExtensionStart;
    }
}