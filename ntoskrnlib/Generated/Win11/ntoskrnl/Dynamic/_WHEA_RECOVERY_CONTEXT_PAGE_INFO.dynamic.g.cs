using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_RECOVERY_CONTEXT_PAGE_INFO")]
    public sealed class _WHEA_RECOVERY_CONTEXT_PAGE_INFO : DynamicStructure
    {
        public uint ComponentTag { get; }
        public int PageStatus { get; }
        public uint ActionTaken { get; }
        public _WHEA_IN_USE_PAGE_NOTIFY_FLAGS NotifyFlags { get; }
        public byte ImmediateSuccess { get; }
        public ushort Reserved { get; }
        public _WHEA_RECOVERY_CONTEXT_ACTION_TAKEN_ADDITIONAL_INFO ActionTakenAdditionalInfo { get; }

        public _WHEA_RECOVERY_CONTEXT_PAGE_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_RECOVERY_CONTEXT_PAGE_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_RECOVERY_CONTEXT_PAGE_INFO.ComponentTag),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_RECOVERY_CONTEXT_PAGE_INFO.PageStatus),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_RECOVERY_CONTEXT_PAGE_INFO.ActionTaken),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_RECOVERY_CONTEXT_PAGE_INFO.NotifyFlags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WHEA_RECOVERY_CONTEXT_PAGE_INFO.ImmediateSuccess),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(_WHEA_RECOVERY_CONTEXT_PAGE_INFO.Reserved),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_WHEA_RECOVERY_CONTEXT_PAGE_INFO.ActionTakenAdditionalInfo),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_WHEA_RECOVERY_CONTEXT_PAGE_INFO>((mem, ptr) => new _WHEA_RECOVERY_CONTEXT_PAGE_INFO(mem, ptr), offsets);
        }
    }
}