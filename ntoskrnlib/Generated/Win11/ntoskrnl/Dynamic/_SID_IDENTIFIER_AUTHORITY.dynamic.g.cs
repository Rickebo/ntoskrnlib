using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SID_IDENTIFIER_AUTHORITY")]
    public sealed class _SID_IDENTIFIER_AUTHORITY : DynamicStructure
    {
        public byte[] Value { get; }

        public _SID_IDENTIFIER_AUTHORITY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SID_IDENTIFIER_AUTHORITY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SID_IDENTIFIER_AUTHORITY.Value),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_SID_IDENTIFIER_AUTHORITY>((mem, ptr) => new _SID_IDENTIFIER_AUTHORITY(mem, ptr), offsets);
        }
    }
}