using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HANDLE_TABLE_ENTRY_INFO")]
    public sealed class _HANDLE_TABLE_ENTRY_INFO : DynamicStructure
    {
        public uint AuditMask { get; }
        public uint MaxRelativeAccessMask { get; }

        public _HANDLE_TABLE_ENTRY_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HANDLE_TABLE_ENTRY_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HANDLE_TABLE_ENTRY_INFO.AuditMask),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY_INFO.MaxRelativeAccessMask),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_HANDLE_TABLE_ENTRY_INFO>((mem, ptr) => new _HANDLE_TABLE_ENTRY_INFO(mem, ptr), offsets);
        }
    }
}