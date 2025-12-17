using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RELATION_LIST")]
    public sealed class _RELATION_LIST : DynamicStructure
    {
        public IntPtr DeviceObjectList { get; }
        public byte Sorted { get; }

        public _RELATION_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RELATION_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RELATION_LIST.DeviceObjectList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RELATION_LIST.Sorted),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_RELATION_LIST>((mem, ptr) => new _RELATION_LIST(mem, ptr), offsets);
        }
    }
}