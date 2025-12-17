using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MM_SHARED_VAD_FLAGS")]
    public sealed class _MM_SHARED_VAD_FLAGS : DynamicStructure
    {
        public uint Lock { get; }
        public uint LockContended { get; }
        public uint DeleteInProgress { get; }
        public uint NoChange { get; }
        public uint VadType { get; }
        public uint Protection { get; }
        public uint PreferredNode { get; }
        public uint PageSize { get; }
        public uint PrivateMemoryAlwaysClear { get; }
        public uint PrivateFixup { get; }
        public uint HotPatchState { get; }

        public _MM_SHARED_VAD_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MM_SHARED_VAD_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MM_SHARED_VAD_FLAGS.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_SHARED_VAD_FLAGS.LockContended),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_SHARED_VAD_FLAGS.DeleteInProgress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_SHARED_VAD_FLAGS.NoChange),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_SHARED_VAD_FLAGS.VadType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_SHARED_VAD_FLAGS.Protection),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_SHARED_VAD_FLAGS.PreferredNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_SHARED_VAD_FLAGS.PageSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_SHARED_VAD_FLAGS.PrivateMemoryAlwaysClear),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_SHARED_VAD_FLAGS.PrivateFixup),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_SHARED_VAD_FLAGS.HotPatchState),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MM_SHARED_VAD_FLAGS>((mem, ptr) => new _MM_SHARED_VAD_FLAGS(mem, ptr), offsets);
        }
    }
}