#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _WHEA_EVENT_LOG_ENTRY_FLAGS
    {
        [FieldOffset(0)]
        public uint Reserved1;
        [FieldOffset(0)]
        public uint LogInternalEtw;
        [FieldOffset(0)]
        public uint LogBlackbox;
        [FieldOffset(0)]
        public uint LogSel;
        [FieldOffset(0)]
        public uint RawSel;
        [FieldOffset(0)]
        public uint NoFormat;
        [FieldOffset(0)]
        public uint Driver;
        [FieldOffset(0)]
        public uint Reserved2;
        [FieldOffset(0)]
        public uint AsULONG;
    }
}