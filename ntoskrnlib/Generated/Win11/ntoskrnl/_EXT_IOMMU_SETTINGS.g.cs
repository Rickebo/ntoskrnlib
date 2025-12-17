#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _EXT_IOMMU_SETTINGS
    {
        [FieldOffset(0)]
        public _unnamed_tag_ EnabledCapabilities;
        [FieldOffset(8)]
        public uint TranslationPolicy;
        [FieldOffset(12)]
        public uint RemappingPolicy;
        [FieldOffset(16)]
        public uint RemappingTableEntries;
    }
}