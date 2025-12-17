using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PCAT_FIRMWARE_INFORMATION")]
    public sealed class _PCAT_FIRMWARE_INFORMATION : DynamicStructure
    {
        public uint PlaceHolder { get; }

        public _PCAT_FIRMWARE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PCAT_FIRMWARE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PCAT_FIRMWARE_INFORMATION.PlaceHolder),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PCAT_FIRMWARE_INFORMATION>((mem, ptr) => new _PCAT_FIRMWARE_INFORMATION(mem, ptr), offsets);
        }
    }
}