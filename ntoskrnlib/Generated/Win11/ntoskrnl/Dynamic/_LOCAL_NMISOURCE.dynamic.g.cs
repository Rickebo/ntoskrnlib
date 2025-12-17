using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOCAL_NMISOURCE")]
    public sealed class _LOCAL_NMISOURCE : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public byte ProcessorID { get; }
        public ushort Flags { get; }
        public byte LINTIN { get; }

        public _LOCAL_NMISOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOCAL_NMISOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOCAL_NMISOURCE.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOCAL_NMISOURCE.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_LOCAL_NMISOURCE.ProcessorID),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_LOCAL_NMISOURCE.Flags),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_LOCAL_NMISOURCE.LINTIN),
                    new ulong[]
                    {
                        5UL
                    }
                }
            };
            Register<_LOCAL_NMISOURCE>((mem, ptr) => new _LOCAL_NMISOURCE(mem, ptr), offsets);
        }
    }
}