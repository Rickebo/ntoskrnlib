using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_UNICODE_STRING")]
    public sealed class _UNICODE_STRING : DynamicStructure
    {
        public ushort Length { get; }
        public ushort MaximumLength { get; }
        public IntPtr Buffer { get; }

        public _UNICODE_STRING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _UNICODE_STRING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_UNICODE_STRING.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_UNICODE_STRING.MaximumLength),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_UNICODE_STRING.Buffer),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_UNICODE_STRING>((mem, ptr) => new _UNICODE_STRING(mem, ptr), offsets);
        }
    }
}