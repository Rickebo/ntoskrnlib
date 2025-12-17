using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ALPC_COMPLETION_LIST")]
    public sealed class _ALPC_COMPLETION_LIST : DynamicStructure
    {
        public _LIST_ENTRY Entry { get; }
        public IntPtr OwnerProcess { get; }
        public _EX_PUSH_LOCK CompletionListLock { get; }
        public IntPtr Mdl { get; }
        public IntPtr UserVa { get; }
        public IntPtr UserLimit { get; }
        public IntPtr DataUserVa { get; }
        public IntPtr SystemVa { get; }
        public ulong TotalSize { get; }
        public IntPtr Header { get; }
        public IntPtr List { get; }
        public ulong ListSize { get; }
        public IntPtr Bitmap { get; }
        public ulong BitmapSize { get; }
        public IntPtr Data { get; }
        public ulong DataSize { get; }
        public uint BitmapLimit { get; }
        public uint BitmapNextHint { get; }
        public uint ConcurrencyCount { get; }
        public uint AttributeFlags { get; }
        public uint AttributeSize { get; }

        public _ALPC_COMPLETION_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_COMPLETION_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_COMPLETION_LIST.Entry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.OwnerProcess),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.CompletionListLock),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.Mdl),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.UserVa),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.UserLimit),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.DataUserVa),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.SystemVa),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.TotalSize),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.Header),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.List),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.ListSize),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.Bitmap),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.BitmapSize),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.Data),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.DataSize),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.BitmapLimit),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.BitmapNextHint),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.ConcurrencyCount),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.AttributeFlags),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST.AttributeSize),
                    new ulong[]
                    {
                        152UL
                    }
                }
            };
            Register<_ALPC_COMPLETION_LIST>((mem, ptr) => new _ALPC_COMPLETION_LIST(mem, ptr), offsets);
        }
    }
}