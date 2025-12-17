#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 2080)]
    public partial struct _KSTATIC_AFFINITY_BLOCK
    {
        [FieldOffset(0)]
        public _KAFFINITY_EX KeFlushTbAffinity;
        [FieldOffset(0)]
        public _KAFFINITY_EX KeFlushWbAffinity;
        [FieldOffset(0)]
        public _KAFFINITY_EX KeSlistRollbackAffinity;
        [FieldOffset(0)]
        public _KAFFINITY_EX KeSyncContextAffinity;
        [FieldOffset(0)]
        public _KAFFINITY_EX KeRcuAffinity;
        [FieldOffset(264)]
        public _KAFFINITY_EX KeFlushTbDeepIdleAffinity;
        [FieldOffset(528)]
        public _KAFFINITY_EX KeIpiSendAffinity;
        [FieldOffset(792)]
        public _KAFFINITY_EX KeIpiSendIpiSet;
        [FieldOffset(1056)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public ulong[] Padding;
    }
}