using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_ERROR_SOURCE_CONFIGURATION_DD")]
    public sealed class _WHEA_ERROR_SOURCE_CONFIGURATION_DD : DynamicStructure
    {
        public IntPtr Initialize { get; }
        public IntPtr Uninitialize { get; }
        public IntPtr Correct { get; }

        public _WHEA_ERROR_SOURCE_CONFIGURATION_DD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_ERROR_SOURCE_CONFIGURATION_DD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_ERROR_SOURCE_CONFIGURATION_DD.Initialize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_SOURCE_CONFIGURATION_DD.Uninitialize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_SOURCE_CONFIGURATION_DD.Correct),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_WHEA_ERROR_SOURCE_CONFIGURATION_DD>((mem, ptr) => new _WHEA_ERROR_SOURCE_CONFIGURATION_DD(mem, ptr), offsets);
        }
    }
}