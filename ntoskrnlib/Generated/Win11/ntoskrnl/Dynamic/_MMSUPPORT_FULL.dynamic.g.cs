using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMSUPPORT_FULL")]
    public sealed class _MMSUPPORT_FULL : DynamicStructure
    {
        public _MMSUPPORT_INSTANCE Instance { get; }
        public _MMSUPPORT_SHARED Shared { get; }

        public _MMSUPPORT_FULL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMSUPPORT_FULL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMSUPPORT_FULL.Instance),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FULL.Shared),
                    new ulong[]
                    {
                        192UL
                    }
                }
            };
            Register<_MMSUPPORT_FULL>((mem, ptr) => new _MMSUPPORT_FULL(mem, ptr), offsets);
        }
    }
}