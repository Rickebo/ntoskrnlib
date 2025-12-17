using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_LOAD_SYMBOLS64")]
    public sealed class _DBGKD_LOAD_SYMBOLS64 : DynamicStructure
    {
        public uint PathNameLength { get; }
        public ulong BaseOfDll { get; }
        public ulong ProcessId { get; }
        public uint CheckSum { get; }
        public uint SizeOfImage { get; }
        public byte UnloadSymbols { get; }

        public _DBGKD_LOAD_SYMBOLS64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_LOAD_SYMBOLS64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_LOAD_SYMBOLS64.PathNameLength),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_LOAD_SYMBOLS64.BaseOfDll),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_LOAD_SYMBOLS64.ProcessId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DBGKD_LOAD_SYMBOLS64.CheckSum),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DBGKD_LOAD_SYMBOLS64.SizeOfImage),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_DBGKD_LOAD_SYMBOLS64.UnloadSymbols),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_DBGKD_LOAD_SYMBOLS64>((mem, ptr) => new _DBGKD_LOAD_SYMBOLS64(mem, ptr), offsets);
        }
    }
}