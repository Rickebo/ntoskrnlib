using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KLOCK_ENTRIES")]
    public sealed class _KLOCK_ENTRIES : DynamicStructure
    {
        public IntPtr Thread { get; }
        public ushort AvailableEntryBitmap { get; }
        public ushort OrphanedEntryBitmap { get; }
        public byte EntryCount { get; }
        public byte[] Padding0 { get; }
        public byte[] Entries { get; }

        public _KLOCK_ENTRIES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KLOCK_ENTRIES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KLOCK_ENTRIES.Thread),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRIES.AvailableEntryBitmap),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRIES.OrphanedEntryBitmap),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRIES.EntryCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRIES.Padding0),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRIES.Entries),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_KLOCK_ENTRIES>((mem, ptr) => new _KLOCK_ENTRIES(mem, ptr), offsets);
        }
    }
}