using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CVDD")]
    public sealed class _CVDD : DynamicStructure
    {
        public uint Signature { get; }
        public _NB10 NB10 { get; }
        public _RSDS RsDs { get; }

        public _CVDD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CVDD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CVDD.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CVDD.NB10),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CVDD.RsDs),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_CVDD>((mem, ptr) => new _CVDD(mem, ptr), offsets);
        }
    }
}