using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_SEP_LOGON_SESSION_REFERENCES")]
    public sealed class SepLogonSessionReferences : DynamicStructure
    {
        public SepLogonSessionReferences(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepLogonSessionReferences>();
        }
    }
}