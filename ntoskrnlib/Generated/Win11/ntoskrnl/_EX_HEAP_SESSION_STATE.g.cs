#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 14592)]
    public partial struct _EX_HEAP_SESSION_STATE
    {
        [FieldOffset(0)]
        public _RTLP_HP_HEAP_MANAGER HeapManager;
        [FieldOffset(14560)]
        public RTL_HP_ENV_HANDLE PagedEnv;
        [FieldOffset(14576)]
        public IntPtr PagedHeap;
        [FieldOffset(14584)]
        public IntPtr SpecialPoolHeap;
    }
}