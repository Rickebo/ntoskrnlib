using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_MEMORY_ERROR_SECTION")]
    public sealed class _WHEA_MEMORY_ERROR_SECTION : DynamicStructure
    {
        public _WHEA_MEMORY_ERROR_SECTION_VALIDBITS ValidBits { get; }
        public _WHEA_ERROR_STATUS ErrorStatus { get; }
        public ulong PhysicalAddress { get; }
        public ulong PhysicalAddressMask { get; }
        public ushort Node { get; }
        public ushort Card { get; }
        public ushort Module { get; }
        public ushort Bank { get; }
        public ushort Device { get; }
        public ushort Row { get; }
        public ushort Column { get; }
        public ushort BitPosition { get; }
        public ulong RequesterId { get; }
        public ulong ResponderId { get; }
        public ulong TargetId { get; }
        public byte ErrorType { get; }
        public byte Extended { get; }
        public ushort RankNumber { get; }
        public ushort CardHandle { get; }
        public ushort ModuleHandle { get; }

        public _WHEA_MEMORY_ERROR_SECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_MEMORY_ERROR_SECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.ValidBits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.ErrorStatus),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.PhysicalAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.PhysicalAddressMask),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.Node),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.Card),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.Module),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.Bank),
                    new ulong[]
                    {
                        38UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.Device),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.Row),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.Column),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.BitPosition),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.RequesterId),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.ResponderId),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.TargetId),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.ErrorType),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.Extended),
                    new ulong[]
                    {
                        73UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.RankNumber),
                    new ulong[]
                    {
                        74UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.CardHandle),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_WHEA_MEMORY_ERROR_SECTION.ModuleHandle),
                    new ulong[]
                    {
                        78UL
                    }
                }
            };
            Register<_WHEA_MEMORY_ERROR_SECTION>((mem, ptr) => new _WHEA_MEMORY_ERROR_SECTION(mem, ptr), offsets);
        }
    }
}