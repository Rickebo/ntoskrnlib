#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct tagSWITCH_CONTEXT_ATTRIBUTE
    {
        [FieldOffset(0)]
        public ulong ulContextUpdateCounter;
        [FieldOffset(8)]
        public int fAllowContextUpdate;
        [FieldOffset(12)]
        public int fEnableTrace;
        [FieldOffset(16)]
        public ulong EtwHandle;
    }
}