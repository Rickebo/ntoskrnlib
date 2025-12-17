using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_HANDLE_COUNT_DATABASE")]
    public sealed class _OBJECT_HANDLE_COUNT_DATABASE : DynamicStructure
    {
        public uint CountEntries { get; }
        public byte[] HandleCountEntries { get; }

        public _OBJECT_HANDLE_COUNT_DATABASE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_HANDLE_COUNT_DATABASE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_HANDLE_COUNT_DATABASE.CountEntries),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_HANDLE_COUNT_DATABASE.HandleCountEntries),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_OBJECT_HANDLE_COUNT_DATABASE>((mem, ptr) => new _OBJECT_HANDLE_COUNT_DATABASE(mem, ptr), offsets);
        }
    }
}