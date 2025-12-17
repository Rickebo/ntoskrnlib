using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NB10")]
    public sealed class _NB10 : DynamicStructure
    {
        public uint Signature { get; }
        public uint Offset { get; }
        public uint TimeStamp { get; }
        public uint Age { get; }
        public sbyte[] PdbName { get; }

        public _NB10(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NB10()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NB10.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NB10.Offset),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NB10.TimeStamp),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NB10.Age),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_NB10.PdbName),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_NB10>((mem, ptr) => new _NB10(mem, ptr), offsets);
        }
    }
}