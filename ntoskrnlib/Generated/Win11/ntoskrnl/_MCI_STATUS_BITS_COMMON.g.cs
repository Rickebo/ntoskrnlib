#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MCI_STATUS_BITS_COMMON
    {
        [FieldOffset(0)]
        public ulong McaErrorCode;
        [FieldOffset(0)]
        public ulong ModelErrorCode;
        [FieldOffset(0)]
        public ulong Reserved;
        [FieldOffset(0)]
        public ulong ContextCorrupt;
        [FieldOffset(0)]
        public ulong AddressValid;
        [FieldOffset(0)]
        public ulong MiscValid;
        [FieldOffset(0)]
        public ulong ErrorEnabled;
        [FieldOffset(0)]
        public ulong UncorrectedError;
        [FieldOffset(0)]
        public ulong StatusOverFlow;
        [FieldOffset(0)]
        public ulong Valid;
    }
}