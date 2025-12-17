using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CC_ASYNC_READ_CONTEXT")]
    public sealed class _CC_ASYNC_READ_CONTEXT : DynamicStructure
    {
        public IntPtr CompletionRoutine { get; }
        public IntPtr Context { get; }
        public IntPtr Mdl { get; }
        public sbyte RequestorMode { get; }
        public uint NestingLevel { get; }

        public _CC_ASYNC_READ_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CC_ASYNC_READ_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CC_ASYNC_READ_CONTEXT.CompletionRoutine),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CC_ASYNC_READ_CONTEXT.Context),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CC_ASYNC_READ_CONTEXT.Mdl),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CC_ASYNC_READ_CONTEXT.RequestorMode),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CC_ASYNC_READ_CONTEXT.NestingLevel),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_CC_ASYNC_READ_CONTEXT>((mem, ptr) => new _CC_ASYNC_READ_CONTEXT(mem, ptr), offsets);
        }
    }
}