using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EX_PUSH_LOCK_AUTO_EXPAND")]
    public sealed class _EX_PUSH_LOCK_AUTO_EXPAND : DynamicStructure
    {
        public _EX_PUSH_LOCK LocalLock { get; }
        public _EX_PUSH_LOCK_AUTO_EXPAND_STATE State { get; }
        public uint Stats { get; }

        public _EX_PUSH_LOCK_AUTO_EXPAND(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_PUSH_LOCK_AUTO_EXPAND()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EX_PUSH_LOCK_AUTO_EXPAND.LocalLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_PUSH_LOCK_AUTO_EXPAND.State),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EX_PUSH_LOCK_AUTO_EXPAND.Stats),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_EX_PUSH_LOCK_AUTO_EXPAND>((mem, ptr) => new _EX_PUSH_LOCK_AUTO_EXPAND(mem, ptr), offsets);
        }
    }
}