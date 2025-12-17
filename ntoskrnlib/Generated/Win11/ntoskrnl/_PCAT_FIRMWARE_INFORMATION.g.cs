#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _PCAT_FIRMWARE_INFORMATION
    {
        [FieldOffset(0)]
        public uint PlaceHolder;
    }
}