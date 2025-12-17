using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_XPF_NMI_DESCRIPTOR")]
    public sealed class _WHEA_XPF_NMI_DESCRIPTOR : DynamicStructure
    {
        public ushort Type { get; }
        public byte Enabled { get; }

        public _WHEA_XPF_NMI_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_XPF_NMI_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_XPF_NMI_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_XPF_NMI_DESCRIPTOR.Enabled),
                    new ulong[]
                    {
                        2UL
                    }
                }
            };
            Register<_WHEA_XPF_NMI_DESCRIPTOR>((mem, ptr) => new _WHEA_XPF_NMI_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}