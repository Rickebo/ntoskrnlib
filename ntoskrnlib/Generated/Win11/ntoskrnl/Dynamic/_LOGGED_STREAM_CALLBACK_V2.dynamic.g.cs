using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOGGED_STREAM_CALLBACK_V2")]
    public sealed class _LOGGED_STREAM_CALLBACK_V2 : DynamicStructure
    {
        public IntPtr LogHandleContext { get; }

        public _LOGGED_STREAM_CALLBACK_V2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOGGED_STREAM_CALLBACK_V2()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOGGED_STREAM_CALLBACK_V2.LogHandleContext),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_LOGGED_STREAM_CALLBACK_V2>((mem, ptr) => new _LOGGED_STREAM_CALLBACK_V2(mem, ptr), offsets);
        }
    }
}