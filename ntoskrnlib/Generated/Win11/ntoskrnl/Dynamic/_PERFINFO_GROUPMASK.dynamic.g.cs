using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PERFINFO_GROUPMASK")]
    public sealed class _PERFINFO_GROUPMASK : DynamicStructure
    {
        public uint[] Masks { get; }

        public _PERFINFO_GROUPMASK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PERFINFO_GROUPMASK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PERFINFO_GROUPMASK.Masks),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PERFINFO_GROUPMASK>((mem, ptr) => new _PERFINFO_GROUPMASK(mem, ptr), offsets);
        }
    }
}