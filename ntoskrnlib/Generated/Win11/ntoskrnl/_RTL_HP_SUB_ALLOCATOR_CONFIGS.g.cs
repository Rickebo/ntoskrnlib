#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _RTL_HP_SUB_ALLOCATOR_CONFIGS
    {
        [FieldOffset(0)]
        public _RTL_HP_LFH_CONFIG LfhConfigs;
        [FieldOffset(4)]
        public _RTL_HP_VS_CONFIG VsConfigs;
    }
}