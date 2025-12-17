#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _MCGEN_TRACE_CONTEXT
    {
        [FieldOffset(0)]
        public ulong RegistrationHandle;
        [FieldOffset(8)]
        public ulong Logger;
        [FieldOffset(16)]
        public ulong MatchAnyKeyword;
        [FieldOffset(24)]
        public ulong MatchAllKeyword;
        [FieldOffset(32)]
        public uint Flags;
        [FieldOffset(36)]
        public uint IsEnabled;
        [FieldOffset(40)]
        public byte Level;
        [FieldOffset(41)]
        public byte Reserve;
        [FieldOffset(42)]
        public ushort EnableBitsCount;
        [FieldOffset(48)]
        public IntPtr EnableBitMask;
        [FieldOffset(56)]
        public IntPtr EnableKeyWords;
        [FieldOffset(64)]
        public IntPtr EnableLevel;
    }
}