using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROCLOCALAPIC")]
    public sealed class _PROCLOCALAPIC : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public byte ACPIProcessorID { get; }
        public byte APICID { get; }
        public uint Flags { get; }

        public _PROCLOCALAPIC(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCLOCALAPIC()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCLOCALAPIC.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCLOCALAPIC.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_PROCLOCALAPIC.ACPIProcessorID),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PROCLOCALAPIC.APICID),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_PROCLOCALAPIC.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_PROCLOCALAPIC>((mem, ptr) => new _PROCLOCALAPIC(mem, ptr), offsets);
        }
    }
}