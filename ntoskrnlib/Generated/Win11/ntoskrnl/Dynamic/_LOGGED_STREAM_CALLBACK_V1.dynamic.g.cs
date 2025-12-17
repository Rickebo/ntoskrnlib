using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOGGED_STREAM_CALLBACK_V1")]
    public sealed class _LOGGED_STREAM_CALLBACK_V1 : DynamicStructure
    {
        public IntPtr LogHandle { get; }
        public IntPtr FlushToLsnRoutine { get; }

        public _LOGGED_STREAM_CALLBACK_V1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOGGED_STREAM_CALLBACK_V1()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOGGED_STREAM_CALLBACK_V1.LogHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOGGED_STREAM_CALLBACK_V1.FlushToLsnRoutine),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_LOGGED_STREAM_CALLBACK_V1>((mem, ptr) => new _LOGGED_STREAM_CALLBACK_V1(mem, ptr), offsets);
        }
    }
}