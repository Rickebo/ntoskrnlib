#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 832)]
    public partial struct tagSWITCH_CONTEXT_DATA
    {
        [FieldOffset(0)]
        public ulong ullOsMaxVersionTested;
        [FieldOffset(8)]
        public uint ulTargetPlatform;
        [FieldOffset(16)]
        public ulong ullContextMinimum;
        [FieldOffset(24)]
        public _GUID guPlatform;
        [FieldOffset(40)]
        public _GUID guMinPlatform;
        [FieldOffset(56)]
        public uint ulContextSource;
        [FieldOffset(60)]
        public uint ulElementCount;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public _GUID[] guElements;
    }
}