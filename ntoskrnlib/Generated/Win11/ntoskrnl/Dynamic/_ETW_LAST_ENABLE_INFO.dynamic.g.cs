using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_LAST_ENABLE_INFO")]
    public sealed class _ETW_LAST_ENABLE_INFO : DynamicStructure
    {
        public _LARGE_INTEGER EnableFlags { get; }
        public ushort LoggerId { get; }
        public byte Level { get; }
        public byte Enabled { get; }
        public byte InternalFlag { get; }

        public _ETW_LAST_ENABLE_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_LAST_ENABLE_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_LAST_ENABLE_INFO.EnableFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_LAST_ENABLE_INFO.LoggerId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_LAST_ENABLE_INFO.Level),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_ETW_LAST_ENABLE_INFO.Enabled),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_ETW_LAST_ENABLE_INFO.InternalFlag),
                    new ulong[]
                    {
                        11UL
                    }
                }
            };
            Register<_ETW_LAST_ENABLE_INFO>((mem, ptr) => new _ETW_LAST_ENABLE_INFO(mem, ptr), offsets);
        }
    }
}