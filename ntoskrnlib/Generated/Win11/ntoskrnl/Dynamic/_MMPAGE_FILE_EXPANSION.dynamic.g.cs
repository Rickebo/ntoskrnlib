using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPAGE_FILE_EXPANSION")]
    public sealed class _MMPAGE_FILE_EXPANSION : DynamicStructure
    {
        public IntPtr Segment { get; }
        public _LIST_ENTRY DereferenceList { get; }
        public IntPtr Partition { get; }
        public ulong RequestedExpansionSize { get; }
        public ulong ActualExpansion { get; }
        public _KEVENT Event { get; }
        public int InProgress { get; }
        public _unnamed_tag_ u1 { get; }
        public IntPtr ActiveEntry { get; }

        public _MMPAGE_FILE_EXPANSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPAGE_FILE_EXPANSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPAGE_FILE_EXPANSION.Segment),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION.DereferenceList),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION.Partition),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION.RequestedExpansionSize),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION.ActualExpansion),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION.Event),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION.InProgress),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION.u1),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_MMPAGE_FILE_EXPANSION.ActiveEntry),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_MMPAGE_FILE_EXPANSION>((mem, ptr) => new _MMPAGE_FILE_EXPANSION(mem, ptr), offsets);
        }
    }
}