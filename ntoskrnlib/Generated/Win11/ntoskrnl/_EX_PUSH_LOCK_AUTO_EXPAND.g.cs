#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _EX_PUSH_LOCK_AUTO_EXPAND
    {
        [FieldOffset(0)]
        public _EX_PUSH_LOCK LocalLock;
        [FieldOffset(8)]
        public _EX_PUSH_LOCK_AUTO_EXPAND_STATE State;
        [FieldOffset(12)]
        public uint Stats;
    }
}