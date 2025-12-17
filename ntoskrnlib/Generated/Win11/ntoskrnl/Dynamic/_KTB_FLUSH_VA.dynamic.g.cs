using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTB_FLUSH_VA")]
    public sealed class _KTB_FLUSH_VA : DynamicStructure
    {
        public _unnamed_tag_ u1 { get; }

        public _KTB_FLUSH_VA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTB_FLUSH_VA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTB_FLUSH_VA.u1),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KTB_FLUSH_VA>((mem, ptr) => new _KTB_FLUSH_VA(mem, ptr), offsets);
        }
    }
}