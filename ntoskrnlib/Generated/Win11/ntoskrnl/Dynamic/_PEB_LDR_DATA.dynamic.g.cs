using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEB_LDR_DATA")]
    public sealed class _PEB_LDR_DATA : DynamicStructure
    {
        public uint Length { get; }
        public byte Initialized { get; }
        public IntPtr SsHandle { get; }
        public _LIST_ENTRY InLoadOrderModuleList { get; }
        public _LIST_ENTRY InMemoryOrderModuleList { get; }
        public _LIST_ENTRY InInitializationOrderModuleList { get; }
        public IntPtr EntryInProgress { get; }
        public byte ShutdownInProgress { get; }
        public IntPtr ShutdownThreadId { get; }

        public _PEB_LDR_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEB_LDR_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEB_LDR_DATA.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEB_LDR_DATA.Initialized),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PEB_LDR_DATA.SsHandle),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEB_LDR_DATA.InLoadOrderModuleList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PEB_LDR_DATA.InMemoryOrderModuleList),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PEB_LDR_DATA.InInitializationOrderModuleList),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PEB_LDR_DATA.EntryInProgress),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PEB_LDR_DATA.ShutdownInProgress),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PEB_LDR_DATA.ShutdownThreadId),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_PEB_LDR_DATA>((mem, ptr) => new _PEB_LDR_DATA(mem, ptr), offsets);
        }
    }
}