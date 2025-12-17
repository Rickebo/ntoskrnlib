#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _tlgProvider_t
    {
        [FieldOffset(0)]
        public uint LevelPlus1;
        [FieldOffset(8)]
        public IntPtr ProviderMetadataPtr;
        [FieldOffset(16)]
        public ulong KeywordAny;
        [FieldOffset(24)]
        public ulong KeywordAll;
        [FieldOffset(32)]
        public ulong RegHandle;
        [FieldOffset(40)]
        public IntPtr EnableCallback;
        [FieldOffset(48)]
        public IntPtr CallbackContext;
    }
}