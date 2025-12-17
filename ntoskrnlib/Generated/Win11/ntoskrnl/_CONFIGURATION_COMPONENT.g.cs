#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _CONFIGURATION_COMPONENT
    {
        [FieldOffset(0)]
        public uint Class;
        [FieldOffset(4)]
        public uint Type;
        [FieldOffset(8)]
        public _DEVICE_FLAGS Flags;
        [FieldOffset(12)]
        public ushort Version;
        [FieldOffset(14)]
        public ushort Revision;
        [FieldOffset(16)]
        public uint Key;
        [FieldOffset(20)]
        public uint AffinityMask;
        [FieldOffset(20)]
        public ushort Group;
        [FieldOffset(22)]
        public ushort GroupIndex;
        [FieldOffset(24)]
        public uint ConfigurationDataLength;
        [FieldOffset(28)]
        public uint IdentifierLength;
        [FieldOffset(32)]
        public IntPtr Identifier;
    }
}