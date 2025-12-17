using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PLATFORM_INTERRUPT")]
    public sealed class _PLATFORM_INTERRUPT : DynamicStructure
    {
        public byte Type { get; }
        public byte Length { get; }
        public ushort Flags { get; }
        public byte InterruptType { get; }
        public byte APICID { get; }
        public byte ACPIEID { get; }
        public byte IOSAPICVector { get; }
        public uint GlobalVector { get; }
        public uint Reserved { get; }

        public _PLATFORM_INTERRUPT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PLATFORM_INTERRUPT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PLATFORM_INTERRUPT.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PLATFORM_INTERRUPT.Length),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_PLATFORM_INTERRUPT.Flags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PLATFORM_INTERRUPT.InterruptType),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PLATFORM_INTERRUPT.APICID),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_PLATFORM_INTERRUPT.ACPIEID),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_PLATFORM_INTERRUPT.IOSAPICVector),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_PLATFORM_INTERRUPT.GlobalVector),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PLATFORM_INTERRUPT.Reserved),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_PLATFORM_INTERRUPT>((mem, ptr) => new _PLATFORM_INTERRUPT(mem, ptr), offsets);
        }
    }
}