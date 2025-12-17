#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 6)]
    public partial struct FEATURE_LOGGED_TRAITS
    {
        [FieldOffset(0)]
        public ushort version;
        [FieldOffset(2)]
        public ushort baseVersion;
        [FieldOffset(4)]
        public byte stage;
    }
}