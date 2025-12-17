using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_NMISOURCE")]
    public sealed class _IO_NMISOURCE : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public ushort Flags { get; }
        public uint GlobalSystemInterruptVector { get; }

        public _IO_NMISOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_NMISOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_NMISOURCE.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_NMISOURCE.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_IO_NMISOURCE.Flags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IO_NMISOURCE.GlobalSystemInterruptVector),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_IO_NMISOURCE>((mem, ptr) => new _IO_NMISOURCE(mem, ptr), offsets);
        }
    }
}