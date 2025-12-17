#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _DMA_REQUEST_LINE_BINDING_DESCRIPTION
    {
        [FieldOffset(0)]
        public uint RequestLine;
        [FieldOffset(4)]
        public uint ChannelNumber;
    }
}