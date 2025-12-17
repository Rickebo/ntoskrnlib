using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_RECOVERY_CONTEXT_ACTION_TAKEN_ADDITIONAL_INFO")]
    public sealed class _WHEA_RECOVERY_CONTEXT_ACTION_TAKEN_ADDITIONAL_INFO : DynamicStructure
    {
        public _unnamed_tag_ Bits { get; }
        public ulong AsULONG64 { get; }

        public _WHEA_RECOVERY_CONTEXT_ACTION_TAKEN_ADDITIONAL_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_RECOVERY_CONTEXT_ACTION_TAKEN_ADDITIONAL_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_RECOVERY_CONTEXT_ACTION_TAKEN_ADDITIONAL_INFO.Bits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_RECOVERY_CONTEXT_ACTION_TAKEN_ADDITIONAL_INFO.AsULONG64),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_RECOVERY_CONTEXT_ACTION_TAKEN_ADDITIONAL_INFO>((mem, ptr) => new _WHEA_RECOVERY_CONTEXT_ACTION_TAKEN_ADDITIONAL_INFO(mem, ptr), offsets);
        }
    }
}