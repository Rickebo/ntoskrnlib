#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _CLIENT_ID32
    {
        [FieldOffset(0)]
        public uint UniqueProcess;
        [FieldOffset(4)]
        public uint UniqueThread;
    }
}