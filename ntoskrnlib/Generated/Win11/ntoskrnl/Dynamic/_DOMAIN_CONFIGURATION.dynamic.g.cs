using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DOMAIN_CONFIGURATION")]
    public sealed class _DOMAIN_CONFIGURATION : DynamicStructure
    {
        public uint Type { get; }
        public _DOMAIN_CONFIGURATION_ARM64 Arm64 { get; }
        public _DOMAIN_CONFIGURATION_X64 X64 { get; }

        public _DOMAIN_CONFIGURATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DOMAIN_CONFIGURATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DOMAIN_CONFIGURATION.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DOMAIN_CONFIGURATION.Arm64),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DOMAIN_CONFIGURATION.X64),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DOMAIN_CONFIGURATION>((mem, ptr) => new _DOMAIN_CONFIGURATION(mem, ptr), offsets);
        }
    }
}