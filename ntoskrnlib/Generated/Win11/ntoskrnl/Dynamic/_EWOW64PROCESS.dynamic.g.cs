using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EWOW64PROCESS")]
    public sealed class _EWOW64PROCESS : DynamicStructure
    {
        public IntPtr Peb { get; }
        public uint NtdllType { get; }

        public _EWOW64PROCESS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EWOW64PROCESS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EWOW64PROCESS.Peb),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EWOW64PROCESS.NtdllType),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_EWOW64PROCESS>((mem, ptr) => new _EWOW64PROCESS(mem, ptr), offsets);
        }
    }
}