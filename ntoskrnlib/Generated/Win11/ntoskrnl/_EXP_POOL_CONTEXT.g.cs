#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _EXP_POOL_CONTEXT
    {
        [FieldOffset(0)]
        public _EXP_POOL_CONTEXT_HEADER Header;
        [FieldOffset(8)]
        public RTL_HP_ENV_HANDLE EnvHandle;
        [FieldOffset(24)]
        public _EX_RUNDOWN_REF Rundown;
        [FieldOffset(32)]
        public _LIST_ENTRY PoolLink;
        [FieldOffset(48)]
        public ulong Tag;
        [FieldOffset(56)]
        public _UNICODE_STRING Name;
        [FieldOffset(72)]
        public uint NodeCount;
        [FieldOffset(80)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public IntPtr[] Node;
    }
}