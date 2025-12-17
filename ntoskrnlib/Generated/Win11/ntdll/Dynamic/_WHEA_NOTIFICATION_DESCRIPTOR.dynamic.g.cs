using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_NOTIFICATION_DESCRIPTOR")]
    public sealed class _WHEA_NOTIFICATION_DESCRIPTOR : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public _WHEA_NOTIFICATION_FLAGS Flags { get; }
        public _unnamed_tag_ u { get; }

        public _WHEA_NOTIFICATION_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_NOTIFICATION_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_NOTIFICATION_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_NOTIFICATION_DESCRIPTOR.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_WHEA_NOTIFICATION_DESCRIPTOR.Flags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_WHEA_NOTIFICATION_DESCRIPTOR.u),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_WHEA_NOTIFICATION_DESCRIPTOR>((mem, ptr) => new _WHEA_NOTIFICATION_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}