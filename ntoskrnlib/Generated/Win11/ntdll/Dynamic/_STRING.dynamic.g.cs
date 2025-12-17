using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_STRING")]
    public sealed class _STRING : DynamicStructure
    {
        public ushort Length { get; }
        public ushort MaximumLength { get; }
        public IntPtr Buffer { get; }

        public _STRING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _STRING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_STRING.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STRING.MaximumLength),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_STRING.Buffer),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_STRING>((mem, ptr) => new _STRING(mem, ptr), offsets);
        }
    }
}