#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1056)]
    public partial struct _POP_PPM_PROFILE
    {
        [FieldOffset(0)]
        public IntPtr Name;
        [FieldOffset(8)]
        public byte Id;
        [FieldOffset(12)]
        public _GUID Guid;
        [FieldOffset(28)]
        public uint Flags;
        [FieldOffset(32)]
        public byte Priority;
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _PPM_ENGINE_SETTINGS[] Settings;
        [FieldOffset(1016)]
        public ulong StartTime;
        [FieldOffset(1024)]
        public ulong Count;
        [FieldOffset(1032)]
        public ulong MaxDuration;
        [FieldOffset(1040)]
        public ulong MinDuration;
        [FieldOffset(1048)]
        public ulong TotalDuration;
    }
}