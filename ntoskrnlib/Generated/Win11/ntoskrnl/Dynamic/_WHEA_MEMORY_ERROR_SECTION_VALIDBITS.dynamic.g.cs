using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_MEMORY_ERROR_SECTION_VALIDBITS")]
    public sealed class _WHEA_MEMORY_ERROR_SECTION_VALIDBITS : DynamicStructure
    {
        public ulong ErrorStatus { get; }
        public ulong PhysicalAddress { get; }
        public ulong PhysicalAddressMask { get; }
        public ulong Node { get; }
        public ulong Card { get; }
        public ulong Module { get; }
        public ulong Bank { get; }
        public ulong Device { get; }
        public ulong Row { get; }
        public ulong Column { get; }
        public ulong BitPosition { get; }
        public ulong RequesterId { get; }
        public ulong ResponderId { get; }
        public ulong TargetId { get; }
        public ulong ErrorType { get; }
        public ulong RankNumber { get; }
        public ulong CardHandle { get; }
        public ulong ModuleHandle { get; }
        public ulong ExtendedRow { get; }
        public ulong BankGroup { get; }
        public ulong BankAddress { get; }
        public ulong ChipIdentification { get; }
        public ulong Reserved { get; }
        public ulong ValidBits { get; }

        public _WHEA_MEMORY_ERROR_SECTION_VALIDBITS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_MEMORY_ERROR_SECTION_VALIDBITS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.ErrorStatus),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.PhysicalAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.PhysicalAddressMask),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.Node),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.Card),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.Module),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.Bank),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.Device),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.Row),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.Column),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.BitPosition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.RequesterId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.ResponderId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.TargetId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.ErrorType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.RankNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.CardHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.ModuleHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.ExtendedRow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.BankGroup),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.BankAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.ChipIdentification),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION_VALIDBITS.ValidBits),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_MEMORY_ERROR_SECTION_VALIDBITS>((mem, ptr) => new _WHEA_MEMORY_ERROR_SECTION_VALIDBITS(mem, ptr), offsets);
        }
    }
}