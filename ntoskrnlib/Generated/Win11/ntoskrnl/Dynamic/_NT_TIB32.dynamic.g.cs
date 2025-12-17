using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_TIB32")]
    public sealed class _NT_TIB32 : DynamicStructure
    {
        public uint ExceptionList { get; }
        public uint StackBase { get; }
        public uint StackLimit { get; }
        public uint SubSystemTib { get; }
        public uint FiberData { get; }
        public uint Version { get; }
        public uint ArbitraryUserPointer { get; }
        public uint Self { get; }

        public _NT_TIB32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_TIB32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_TIB32.ExceptionList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_TIB32.StackBase),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NT_TIB32.StackLimit),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NT_TIB32.SubSystemTib),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_NT_TIB32.FiberData),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_TIB32.Version),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_TIB32.ArbitraryUserPointer),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_NT_TIB32.Self),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_NT_TIB32>((mem, ptr) => new _NT_TIB32(mem, ptr), offsets);
        }
    }
}