using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_PRIORITY_INFO")]
    public sealed class _IO_PRIORITY_INFO : DynamicStructure
    {
        public uint Size { get; }
        public uint ThreadPriority { get; }
        public uint PagePriority { get; }
        public uint IoPriority { get; }

        public _IO_PRIORITY_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_PRIORITY_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_PRIORITY_INFO.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_PRIORITY_INFO.ThreadPriority),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IO_PRIORITY_INFO.PagePriority),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IO_PRIORITY_INFO.IoPriority),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_IO_PRIORITY_INFO>((mem, ptr) => new _IO_PRIORITY_INFO(mem, ptr), offsets);
        }
    }
}