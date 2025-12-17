using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HANDLE_TRACE_DB_ENTRY")]
    public sealed class _HANDLE_TRACE_DB_ENTRY : DynamicStructure
    {
        public _CLIENT_ID ClientId { get; }
        public IntPtr Handle { get; }
        public uint Type { get; }
        public byte[] StackTrace { get; }

        public _HANDLE_TRACE_DB_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HANDLE_TRACE_DB_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HANDLE_TRACE_DB_ENTRY.ClientId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_TRACE_DB_ENTRY.Handle),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HANDLE_TRACE_DB_ENTRY.Type),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HANDLE_TRACE_DB_ENTRY.StackTrace),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_HANDLE_TRACE_DB_ENTRY>((mem, ptr) => new _HANDLE_TRACE_DB_ENTRY(mem, ptr), offsets);
        }
    }
}