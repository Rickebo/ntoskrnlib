#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _HAL_HV_DMA_CREATE_DOMAIN_INFO
    {
        [FieldOffset(0)]
        public _HAL_HV_DMA_DOMAIN_INFO DomainInfo;
        [FieldOffset(8)]
        public byte InheritPassthroughDomain;
        [FieldOffset(9)]
        public byte ForwardProgressRequired;
    }
}