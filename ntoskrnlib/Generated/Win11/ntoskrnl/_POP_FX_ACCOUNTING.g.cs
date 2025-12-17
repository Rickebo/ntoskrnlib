#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public partial struct _POP_FX_ACCOUNTING
    {
        [FieldOffset(0)]
        public ulong Lock;
        [FieldOffset(8)]
        public byte Active;
        [FieldOffset(12)]
        public uint DripsRequiredState;
        [FieldOffset(16)]
        public uint AccountingMode;
        [FieldOffset(24)]
        public ulong ActiveStamp;
        [FieldOffset(32)]
        public _POP_FX_ACTIVE_TIME_ACCOUNTING CsActiveTimeAccounting;
        [FieldOffset(128)]
        public _POP_FX_ACTIVE_TIME_ACCOUNTING CsCriticalActiveTimeAccounting;
    }
}