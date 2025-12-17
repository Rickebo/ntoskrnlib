#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 19)]
    public partial struct _tlgProviderMetadata_t
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public _GUID ProviderId;
        [FieldOffset(17)]
        public ushort RemainingSize;
    }
}