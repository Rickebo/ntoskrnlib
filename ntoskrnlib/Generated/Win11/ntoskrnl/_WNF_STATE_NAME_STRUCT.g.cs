#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _WNF_STATE_NAME_STRUCT
    {
        [FieldOffset(0)]
        public ulong Version;
        [FieldOffset(0)]
        public ulong NameLifetime;
        [FieldOffset(0)]
        public ulong DataScope;
        [FieldOffset(0)]
        public ulong PermanentData;
        [FieldOffset(0)]
        public ulong Sequence;
    }
}