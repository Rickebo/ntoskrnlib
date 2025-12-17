using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMVAD_FLAGS2")]
    public sealed class _MMVAD_FLAGS2 : DynamicStructure
    {
        public uint Large { get; }
        public uint TrimBehind { get; }
        public uint Inherit { get; }
        public uint NoValidationNeeded { get; }
        public uint PrivateDemandZero { get; }
        public uint ImageMappingExtended { get; }
        public uint Spare { get; }
        public uint LongFlags { get; }

        public _MMVAD_FLAGS2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMVAD_FLAGS2()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMVAD_FLAGS2.Large),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS2.TrimBehind),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS2.Inherit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS2.NoValidationNeeded),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS2.PrivateDemandZero),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS2.ImageMappingExtended),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS2.Spare),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD_FLAGS2.LongFlags),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMVAD_FLAGS2>((mem, ptr) => new _MMVAD_FLAGS2(mem, ptr), offsets);
        }
    }
}