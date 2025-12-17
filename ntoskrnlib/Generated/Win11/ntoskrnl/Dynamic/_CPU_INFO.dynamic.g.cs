using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CPU_INFO")]
    public sealed class _CPU_INFO : DynamicStructure
    {
        public uint[] AsUINT32 { get; }
        public uint Eax { get; }
        public uint Ebx { get; }
        public uint Ecx { get; }
        public uint Edx { get; }

        public _CPU_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CPU_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CPU_INFO.AsUINT32),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CPU_INFO.Eax),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CPU_INFO.Ebx),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CPU_INFO.Ecx),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CPU_INFO.Edx),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_CPU_INFO>((mem, ptr) => new _CPU_INFO(mem, ptr), offsets);
        }
    }
}