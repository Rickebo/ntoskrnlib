using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SE_AUDIT_PROCESS_CREATION_INFO")]
    public sealed class _SE_AUDIT_PROCESS_CREATION_INFO : DynamicStructure
    {
        public IntPtr ImageFileName { get; }

        public _SE_AUDIT_PROCESS_CREATION_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SE_AUDIT_PROCESS_CREATION_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SE_AUDIT_PROCESS_CREATION_INFO.ImageFileName),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_SE_AUDIT_PROCESS_CREATION_INFO>((mem, ptr) => new _SE_AUDIT_PROCESS_CREATION_INFO(mem, ptr), offsets);
        }
    }
}