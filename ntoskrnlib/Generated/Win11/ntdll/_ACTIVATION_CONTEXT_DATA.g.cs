#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _ACTIVATION_CONTEXT_DATA
    {
        [FieldOffset(0)]
        public uint Magic;
        [FieldOffset(4)]
        public uint HeaderSize;
        [FieldOffset(8)]
        public uint FormatVersion;
        [FieldOffset(12)]
        public uint TotalSize;
        [FieldOffset(16)]
        public uint DefaultTocOffset;
        [FieldOffset(20)]
        public uint ExtendedTocOffset;
        [FieldOffset(24)]
        public uint AssemblyRosterOffset;
        [FieldOffset(28)]
        public uint Flags;
    }
}