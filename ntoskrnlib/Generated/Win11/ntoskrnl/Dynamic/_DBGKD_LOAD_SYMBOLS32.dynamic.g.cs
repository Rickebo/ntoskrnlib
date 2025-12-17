using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_LOAD_SYMBOLS32")]
    public sealed class _DBGKD_LOAD_SYMBOLS32 : DynamicStructure
    {
        public uint PathNameLength { get; }
        public uint BaseOfDll { get; }
        public uint ProcessId { get; }
        public uint CheckSum { get; }
        public uint SizeOfImage { get; }
        public byte UnloadSymbols { get; }

        public _DBGKD_LOAD_SYMBOLS32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_LOAD_SYMBOLS32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_LOAD_SYMBOLS32.PathNameLength),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_LOAD_SYMBOLS32.BaseOfDll),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_LOAD_SYMBOLS32.ProcessId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_LOAD_SYMBOLS32.CheckSum),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DBGKD_LOAD_SYMBOLS32.SizeOfImage),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DBGKD_LOAD_SYMBOLS32.UnloadSymbols),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_DBGKD_LOAD_SYMBOLS32>((mem, ptr) => new _DBGKD_LOAD_SYMBOLS32(mem, ptr), offsets);
        }
    }
}