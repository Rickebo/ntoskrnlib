#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _PS_PROTECTION
    {
        [FieldOffset(0)]
        public byte Level;
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(0)]
        public byte Audit;
        [FieldOffset(0)]
        public byte Signer;
    }
}