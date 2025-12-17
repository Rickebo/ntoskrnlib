#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _NT_IORING_CQE
    {
        [FieldOffset(0)]
        public ulong UserData;
        [FieldOffset(0)]
        public ulong PaddingUserDataForWow;
        [FieldOffset(8)]
        public _IO_STATUS_BLOCK IoStatus;
    }
}