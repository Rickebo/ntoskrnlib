#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _WHEA_EVENT_LOG_ENTRY_HEADER
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public uint Version;
        [FieldOffset(8)]
        public uint Length;
        [FieldOffset(12)]
        public uint Type;
        [FieldOffset(16)]
        public uint OwnerTag;
        [FieldOffset(20)]
        public uint Id;
        [FieldOffset(24)]
        public _WHEA_EVENT_LOG_ENTRY_FLAGS Flags;
        [FieldOffset(28)]
        public uint PayloadLength;
    }
}