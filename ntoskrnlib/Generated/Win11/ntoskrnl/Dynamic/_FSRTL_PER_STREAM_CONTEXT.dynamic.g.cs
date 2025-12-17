using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FSRTL_PER_STREAM_CONTEXT")]
    public sealed class _FSRTL_PER_STREAM_CONTEXT : DynamicStructure
    {
        public _LIST_ENTRY Links { get; }
        public IntPtr OwnerId { get; }
        public IntPtr InstanceId { get; }
        public IntPtr FreeCallback { get; }

        public _FSRTL_PER_STREAM_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FSRTL_PER_STREAM_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FSRTL_PER_STREAM_CONTEXT.Links),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FSRTL_PER_STREAM_CONTEXT.OwnerId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FSRTL_PER_STREAM_CONTEXT.InstanceId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FSRTL_PER_STREAM_CONTEXT.FreeCallback),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_FSRTL_PER_STREAM_CONTEXT>((mem, ptr) => new _FSRTL_PER_STREAM_CONTEXT(mem, ptr), offsets);
        }
    }
}