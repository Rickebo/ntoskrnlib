using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PCW_DATA")]
    public sealed class _PCW_DATA : DynamicStructure
    {
        public IntPtr Data { get; }
        public uint Size { get; }

        public _PCW_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PCW_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PCW_DATA.Data),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PCW_DATA.Size),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PCW_DATA>((mem, ptr) => new _PCW_DATA(mem, ptr), offsets);
        }
    }
}