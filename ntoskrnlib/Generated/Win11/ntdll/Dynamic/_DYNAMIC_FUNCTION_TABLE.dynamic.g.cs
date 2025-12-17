using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_DYNAMIC_FUNCTION_TABLE")]
    public sealed class _DYNAMIC_FUNCTION_TABLE : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr FunctionTable { get; }
        public _LARGE_INTEGER TimeStamp { get; }
        public ulong MinimumAddress { get; }
        public ulong MaximumAddress { get; }
        public ulong BaseAddress { get; }
        public IntPtr Callback { get; }
        public IntPtr Context { get; }
        public IntPtr OutOfProcessCallbackDll { get; }
        public uint Type { get; }
        public uint EntryCount { get; }
        public _RTL_BALANCED_NODE TreeNodeMin { get; }
        public _RTL_BALANCED_NODE TreeNodeMax { get; }

        public _DYNAMIC_FUNCTION_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DYNAMIC_FUNCTION_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DYNAMIC_FUNCTION_TABLE.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DYNAMIC_FUNCTION_TABLE.FunctionTable),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DYNAMIC_FUNCTION_TABLE.TimeStamp),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DYNAMIC_FUNCTION_TABLE.MinimumAddress),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DYNAMIC_FUNCTION_TABLE.MaximumAddress),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DYNAMIC_FUNCTION_TABLE.BaseAddress),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DYNAMIC_FUNCTION_TABLE.Callback),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DYNAMIC_FUNCTION_TABLE.Context),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DYNAMIC_FUNCTION_TABLE.OutOfProcessCallbackDll),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DYNAMIC_FUNCTION_TABLE.Type),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_DYNAMIC_FUNCTION_TABLE.EntryCount),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_DYNAMIC_FUNCTION_TABLE.TreeNodeMin),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_DYNAMIC_FUNCTION_TABLE.TreeNodeMax),
                    new ulong[]
                    {
                        112UL
                    }
                }
            };
            Register<_DYNAMIC_FUNCTION_TABLE>((mem, ptr) => new _DYNAMIC_FUNCTION_TABLE(mem, ptr), offsets);
        }
    }
}