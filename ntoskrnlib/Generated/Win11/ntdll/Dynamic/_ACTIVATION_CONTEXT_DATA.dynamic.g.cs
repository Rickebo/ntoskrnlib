using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ACTIVATION_CONTEXT_DATA")]
    public sealed class _ACTIVATION_CONTEXT_DATA : DynamicStructure
    {
        public uint Magic { get; }
        public uint HeaderSize { get; }
        public uint FormatVersion { get; }
        public uint TotalSize { get; }
        public uint DefaultTocOffset { get; }
        public uint ExtendedTocOffset { get; }
        public uint AssemblyRosterOffset { get; }
        public uint Flags { get; }

        public _ACTIVATION_CONTEXT_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ACTIVATION_CONTEXT_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ACTIVATION_CONTEXT_DATA.Magic),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_DATA.HeaderSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_DATA.FormatVersion),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_DATA.TotalSize),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_DATA.DefaultTocOffset),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_DATA.ExtendedTocOffset),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_DATA.AssemblyRosterOffset),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_DATA.Flags),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_ACTIVATION_CONTEXT_DATA>((mem, ptr) => new _ACTIVATION_CONTEXT_DATA(mem, ptr), offsets);
        }
    }
}