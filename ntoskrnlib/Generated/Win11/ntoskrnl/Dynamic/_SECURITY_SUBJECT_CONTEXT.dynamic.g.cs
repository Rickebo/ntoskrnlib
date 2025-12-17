using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SECURITY_SUBJECT_CONTEXT")]
    public sealed class _SECURITY_SUBJECT_CONTEXT : DynamicStructure
    {
        public IntPtr ClientToken { get; }
        public uint ImpersonationLevel { get; }
        public IntPtr PrimaryToken { get; }
        public IntPtr ProcessAuditId { get; }

        public _SECURITY_SUBJECT_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SECURITY_SUBJECT_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SECURITY_SUBJECT_CONTEXT.ClientToken),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SECURITY_SUBJECT_CONTEXT.ImpersonationLevel),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SECURITY_SUBJECT_CONTEXT.PrimaryToken),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SECURITY_SUBJECT_CONTEXT.ProcessAuditId),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_SECURITY_SUBJECT_CONTEXT>((mem, ptr) => new _SECURITY_SUBJECT_CONTEXT(mem, ptr), offsets);
        }
    }
}