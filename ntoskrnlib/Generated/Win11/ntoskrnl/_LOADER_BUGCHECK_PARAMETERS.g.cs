#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _LOADER_BUGCHECK_PARAMETERS
    {
        [FieldOffset(0)]
        public uint BugcheckCode;
        [FieldOffset(8)]
        public ulong BugcheckParameter1;
        [FieldOffset(16)]
        public ulong BugcheckParameter2;
        [FieldOffset(24)]
        public ulong BugcheckParameter3;
        [FieldOffset(32)]
        public ulong BugcheckParameter4;
    }
}