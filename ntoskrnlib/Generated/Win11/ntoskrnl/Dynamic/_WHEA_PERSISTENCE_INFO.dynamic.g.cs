using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_PERSISTENCE_INFO")]
    public sealed class _WHEA_PERSISTENCE_INFO : DynamicStructure
    {
        public ulong Signature { get; }
        public ulong Length { get; }
        public ulong Identifier { get; }
        public ulong Attributes { get; }
        public ulong DoNotLog { get; }
        public ulong Reserved { get; }
        public ulong AsULONGLONG { get; }

        public _WHEA_PERSISTENCE_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_PERSISTENCE_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_PERSISTENCE_INFO.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PERSISTENCE_INFO.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PERSISTENCE_INFO.Identifier),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PERSISTENCE_INFO.Attributes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PERSISTENCE_INFO.DoNotLog),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PERSISTENCE_INFO.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PERSISTENCE_INFO.AsULONGLONG),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_PERSISTENCE_INFO>((mem, ptr) => new _WHEA_PERSISTENCE_INFO(mem, ptr), offsets);
        }
    }
}