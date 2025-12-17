#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _TXN_PARAMETER_BLOCK
    {
        [FieldOffset(0)]
        public ushort Length;
        [FieldOffset(2)]
        public ushort TxFsContext;
        [FieldOffset(8)]
        public IntPtr TransactionObject;
    }
}