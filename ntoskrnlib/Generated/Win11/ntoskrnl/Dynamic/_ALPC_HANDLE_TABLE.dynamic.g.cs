using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ALPC_HANDLE_TABLE")]
    public sealed class _ALPC_HANDLE_TABLE : DynamicStructure
    {
        public IntPtr Handles { get; }
        public _EX_PUSH_LOCK Lock { get; }
        public ulong TotalHandles { get; }
        public uint Flags { get; }

        public _ALPC_HANDLE_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_HANDLE_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_HANDLE_TABLE.Handles),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ALPC_HANDLE_TABLE.Lock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ALPC_HANDLE_TABLE.TotalHandles),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ALPC_HANDLE_TABLE.Flags),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_ALPC_HANDLE_TABLE>((mem, ptr) => new _ALPC_HANDLE_TABLE(mem, ptr), offsets);
        }
    }
}