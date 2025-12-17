using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_STRING64")]
    public sealed class _STRING64 : DynamicStructure
    {
        public ushort Length { get; }
        public ushort MaximumLength { get; }
        public ulong Buffer { get; }

        public _STRING64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _STRING64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_STRING64.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STRING64.MaximumLength),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_STRING64.Buffer),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_STRING64>((mem, ptr) => new _STRING64(mem, ptr), offsets);
        }
    }
}