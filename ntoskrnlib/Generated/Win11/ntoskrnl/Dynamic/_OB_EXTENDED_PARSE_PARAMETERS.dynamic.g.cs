using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OB_EXTENDED_PARSE_PARAMETERS")]
    public sealed class _OB_EXTENDED_PARSE_PARAMETERS : DynamicStructure
    {
        public ushort Length { get; }
        public uint RestrictedAccessMask { get; }
        public IntPtr Silo { get; }

        public _OB_EXTENDED_PARSE_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OB_EXTENDED_PARSE_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OB_EXTENDED_PARSE_PARAMETERS.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OB_EXTENDED_PARSE_PARAMETERS.RestrictedAccessMask),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_OB_EXTENDED_PARSE_PARAMETERS.Silo),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_OB_EXTENDED_PARSE_PARAMETERS>((mem, ptr) => new _OB_EXTENDED_PARSE_PARAMETERS(mem, ptr), offsets);
        }
    }
}