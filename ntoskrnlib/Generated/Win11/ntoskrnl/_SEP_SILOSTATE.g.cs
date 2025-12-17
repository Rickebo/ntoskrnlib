#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _SEP_SILOSTATE
    {
        [FieldOffset(0)]
        public IntPtr SystemLogonSession;
        [FieldOffset(8)]
        public IntPtr AnonymousLogonSession;
        [FieldOffset(16)]
        public IntPtr AnonymousLogonToken;
        [FieldOffset(24)]
        public IntPtr AnonymousLogonTokenNoEveryone;
        [FieldOffset(32)]
        public IntPtr UncSystemPaths;
        [FieldOffset(40)]
        public IntPtr NgenPaths;
    }
}