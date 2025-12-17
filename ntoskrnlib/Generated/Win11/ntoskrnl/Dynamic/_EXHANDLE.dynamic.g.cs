using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXHANDLE")]
    public sealed class _EXHANDLE : DynamicStructure
    {
        public uint TagBits { get; }
        public uint Index { get; }
        public IntPtr GenericHandleOverlay { get; }
        public ulong Value { get; }

        public _EXHANDLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXHANDLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXHANDLE.TagBits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXHANDLE.Index),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXHANDLE.GenericHandleOverlay),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXHANDLE.Value),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_EXHANDLE>((mem, ptr) => new _EXHANDLE(mem, ptr), offsets);
        }
    }
}