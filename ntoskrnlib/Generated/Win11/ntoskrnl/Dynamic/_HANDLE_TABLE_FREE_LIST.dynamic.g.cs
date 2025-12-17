using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HANDLE_TABLE_FREE_LIST")]
    public sealed class _HANDLE_TABLE_FREE_LIST : DynamicStructure
    {
        public _EX_PUSH_LOCK FreeListLock { get; }
        public IntPtr FirstFreeHandleEntry { get; }
        public IntPtr LastFreeHandleEntry { get; }
        public int HandleCount { get; }
        public uint HighWaterMark { get; }

        public _HANDLE_TABLE_FREE_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HANDLE_TABLE_FREE_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HANDLE_TABLE_FREE_LIST.FreeListLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_FREE_LIST.FirstFreeHandleEntry),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_FREE_LIST.LastFreeHandleEntry),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_FREE_LIST.HandleCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_FREE_LIST.HighWaterMark),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_HANDLE_TABLE_FREE_LIST>((mem, ptr) => new _HANDLE_TABLE_FREE_LIST(mem, ptr), offsets);
        }
    }
}