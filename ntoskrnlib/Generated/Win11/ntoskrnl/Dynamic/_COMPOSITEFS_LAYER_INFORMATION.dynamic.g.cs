using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_COMPOSITEFS_LAYER_INFORMATION")]
    public sealed class _COMPOSITEFS_LAYER_INFORMATION : DynamicStructure
    {
        public uint DeviceType { get; }
        public _unnamed_tag_ u { get; }

        public _COMPOSITEFS_LAYER_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _COMPOSITEFS_LAYER_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_COMPOSITEFS_LAYER_INFORMATION.DeviceType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_COMPOSITEFS_LAYER_INFORMATION.u),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_COMPOSITEFS_LAYER_INFORMATION>((mem, ptr) => new _COMPOSITEFS_LAYER_INFORMATION(mem, ptr), offsets);
        }
    }
}