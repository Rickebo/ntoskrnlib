#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MM_STORE_KEY
    {
        [FieldOffset(0)]
        public uint EntireKey;
    }
}