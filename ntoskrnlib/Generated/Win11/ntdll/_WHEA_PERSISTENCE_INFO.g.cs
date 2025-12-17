#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _WHEA_PERSISTENCE_INFO
    {
        [FieldOffset(0)]
        public ulong Signature;
        [FieldOffset(0)]
        public ulong Length;
        [FieldOffset(0)]
        public ulong Identifier;
        [FieldOffset(0)]
        public ulong Attributes;
        [FieldOffset(0)]
        public ulong DoNotLog;
        [FieldOffset(0)]
        public ulong Reserved;
        [FieldOffset(0)]
        public ulong AsULONGLONG;
    }
}