using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ALPC_HANDLE_ENTRY")]
    public sealed class _ALPC_HANDLE_ENTRY : DynamicStructure
    {
        public IntPtr Object { get; }

        public _ALPC_HANDLE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_HANDLE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_HANDLE_ENTRY.Object),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ALPC_HANDLE_ENTRY>((mem, ptr) => new _ALPC_HANDLE_ENTRY(mem, ptr), offsets);
        }
    }
}