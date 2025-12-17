using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NON_PAGED_DEBUG_INFO")]
    public sealed class _NON_PAGED_DEBUG_INFO : DynamicStructure
    {
        public ushort Signature { get; }
        public ushort Flags { get; }
        public uint Size { get; }
        public ushort Machine { get; }
        public ushort Characteristics { get; }
        public uint TimeDateStamp { get; }
        public uint CheckSum { get; }
        public uint SizeOfImage { get; }
        public ulong ImageBase { get; }

        public _NON_PAGED_DEBUG_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NON_PAGED_DEBUG_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NON_PAGED_DEBUG_INFO.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NON_PAGED_DEBUG_INFO.Flags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_NON_PAGED_DEBUG_INFO.Size),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NON_PAGED_DEBUG_INFO.Machine),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NON_PAGED_DEBUG_INFO.Characteristics),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_NON_PAGED_DEBUG_INFO.TimeDateStamp),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_NON_PAGED_DEBUG_INFO.CheckSum),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NON_PAGED_DEBUG_INFO.SizeOfImage),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_NON_PAGED_DEBUG_INFO.ImageBase),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_NON_PAGED_DEBUG_INFO>((mem, ptr) => new _NON_PAGED_DEBUG_INFO(mem, ptr), offsets);
        }
    }
}