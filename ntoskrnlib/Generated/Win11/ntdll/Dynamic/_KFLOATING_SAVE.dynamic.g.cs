using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KFLOATING_SAVE")]
    public sealed class _KFLOATING_SAVE : DynamicStructure
    {
        public uint Dummy { get; }

        public _KFLOATING_SAVE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KFLOATING_SAVE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KFLOATING_SAVE.Dummy),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KFLOATING_SAVE>((mem, ptr) => new _KFLOATING_SAVE(mem, ptr), offsets);
        }
    }
}