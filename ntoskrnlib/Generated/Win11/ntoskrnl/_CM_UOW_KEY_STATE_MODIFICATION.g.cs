#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _CM_UOW_KEY_STATE_MODIFICATION
    {
        [FieldOffset(0)]
        public uint RefCount;
        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] SubKeyListCount;
        [FieldOffset(12)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] NewSubKeyList;
    }
}