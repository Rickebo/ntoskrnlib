using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEAP_ERROR_SOURCE_TABLE")]
    public sealed class _WHEAP_ERROR_SOURCE_TABLE : DynamicStructure
    {
        public uint Signature { get; }
        public int Count { get; }
        public uint NextId { get; }
        public _LIST_ENTRY Items { get; }
        public _KEVENT InsertLock { get; }

        public _WHEAP_ERROR_SOURCE_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEAP_ERROR_SOURCE_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEAP_ERROR_SOURCE_TABLE.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE_TABLE.Count),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE_TABLE.NextId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE_TABLE.Items),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE_TABLE.InsertLock),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_WHEAP_ERROR_SOURCE_TABLE>((mem, ptr) => new _WHEAP_ERROR_SOURCE_TABLE(mem, ptr), offsets);
        }
    }
}