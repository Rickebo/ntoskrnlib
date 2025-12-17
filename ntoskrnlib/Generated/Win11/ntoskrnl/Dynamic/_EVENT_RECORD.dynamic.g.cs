using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EVENT_RECORD")]
    public sealed class _EVENT_RECORD : DynamicStructure
    {
        public _EVENT_HEADER EventHeader { get; }
        public _ETW_BUFFER_CONTEXT BufferContext { get; }
        public ushort ExtendedDataCount { get; }
        public ushort UserDataLength { get; }
        public IntPtr ExtendedData { get; }
        public IntPtr UserData { get; }
        public IntPtr UserContext { get; }

        public _EVENT_RECORD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EVENT_RECORD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EVENT_RECORD.EventHeader),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EVENT_RECORD.BufferContext),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_EVENT_RECORD.ExtendedDataCount),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_EVENT_RECORD.UserDataLength),
                    new ulong[]
                    {
                        86UL
                    }
                },
                {
                    nameof(_EVENT_RECORD.ExtendedData),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_EVENT_RECORD.UserData),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_EVENT_RECORD.UserContext),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_EVENT_RECORD>((mem, ptr) => new _EVENT_RECORD(mem, ptr), offsets);
        }
    }
}