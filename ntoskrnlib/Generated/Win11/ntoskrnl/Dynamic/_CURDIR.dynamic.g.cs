using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CURDIR")]
    public sealed class _CURDIR : DynamicStructure
    {
        public _UNICODE_STRING DosPath { get; }
        public IntPtr Handle { get; }

        public _CURDIR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CURDIR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CURDIR.DosPath),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CURDIR.Handle),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_CURDIR>((mem, ptr) => new _CURDIR(mem, ptr), offsets);
        }
    }
}