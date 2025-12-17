using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_OBJECT_NAME_INFORMATION")]
    public sealed class _OBJECT_NAME_INFORMATION : DynamicStructure
    {
        public _UNICODE_STRING Name { get; }

        public _OBJECT_NAME_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_NAME_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_NAME_INFORMATION.Name),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_OBJECT_NAME_INFORMATION>((mem, ptr) => new _OBJECT_NAME_INFORMATION(mem, ptr), offsets);
        }
    }
}