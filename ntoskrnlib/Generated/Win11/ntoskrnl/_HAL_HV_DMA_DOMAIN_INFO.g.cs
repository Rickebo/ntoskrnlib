#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _HAL_HV_DMA_DOMAIN_INFO
    {
        [FieldOffset(0)]
        public uint DomainId;
        [FieldOffset(4)]
        public byte IsStage1;
    }
}