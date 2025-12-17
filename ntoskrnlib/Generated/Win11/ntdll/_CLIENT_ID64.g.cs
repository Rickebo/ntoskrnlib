#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _CLIENT_ID64
    {
        [FieldOffset(0)]
        public ulong UniqueProcess;
        [FieldOffset(8)]
        public ulong UniqueThread;
    }
}