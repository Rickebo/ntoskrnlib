using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HIVE_LIST_ENTRY")]
    public sealed class _HIVE_LIST_ENTRY : DynamicStructure
    {
        public IntPtr FileName { get; }
        public IntPtr BaseName { get; }
        public IntPtr RegRootName { get; }
        public IntPtr CmHive { get; }
        public uint HHiveFlags { get; }
        public uint CmHiveFlags { get; }
        public uint CmKcbCacheSize { get; }
        public IntPtr CmHive2 { get; }
        public byte HiveMounted { get; }
        public byte ThreadFinished { get; }
        public byte ThreadStarted { get; }
        public byte Allocate { get; }
        public byte WinPERequired { get; }
        public _KEVENT StartEvent { get; }
        public _KEVENT FinishedEvent { get; }
        public _KEVENT MountLock { get; }
        public _EX_PUSH_LOCK MountCallbackLock { get; }
        public _EX_PUSH_LOCK CallbackListLock { get; }
        public _LIST_ENTRY CallbackListHead { get; }
        public _UNICODE_STRING FilePath { get; }

        public _HIVE_LIST_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HIVE_LIST_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HIVE_LIST_ENTRY.FileName),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.BaseName),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.RegRootName),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.CmHive),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.HHiveFlags),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.CmHiveFlags),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.CmKcbCacheSize),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.CmHive2),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.HiveMounted),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.ThreadFinished),
                    new ulong[]
                    {
                        57UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.ThreadStarted),
                    new ulong[]
                    {
                        58UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.Allocate),
                    new ulong[]
                    {
                        59UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.WinPERequired),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.StartEvent),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.FinishedEvent),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.MountLock),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.MountCallbackLock),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.CallbackListLock),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.CallbackListHead),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_HIVE_LIST_ENTRY.FilePath),
                    new ulong[]
                    {
                        168UL
                    }
                }
            };
            Register<_HIVE_LIST_ENTRY>((mem, ptr) => new _HIVE_LIST_ENTRY(mem, ptr), offsets);
        }
    }
}