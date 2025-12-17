#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _FILE_GET_QUOTA_INFORMATION
    {
        [FieldOffset(0)]
        public uint NextEntryOffset;
        [FieldOffset(4)]
        public uint SidLength;
        [FieldOffset(8)]
        public _SID Sid;
    }
}