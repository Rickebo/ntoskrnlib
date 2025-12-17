#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial struct _KALPC_VIEW
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ViewListEntry;
        [FieldOffset(16)]
        public IntPtr Region;
        [FieldOffset(24)]
        public IntPtr OwnerPort;
        [FieldOffset(32)]
        public IntPtr OwnerProcess;
        [FieldOffset(40)]
        public IntPtr Address;
        [FieldOffset(48)]
        public ulong Size;
        [FieldOffset(56)]
        public IntPtr SecureViewHandle;
        [FieldOffset(64)]
        public IntPtr WriteAccessHandle;
        [FieldOffset(72)]
        public _unnamed_tag_ u1;
        [FieldOffset(76)]
        public uint NumberOfOwnerMessages;
        [FieldOffset(80)]
        public _LIST_ENTRY ProcessViewListEntry;
    }
}