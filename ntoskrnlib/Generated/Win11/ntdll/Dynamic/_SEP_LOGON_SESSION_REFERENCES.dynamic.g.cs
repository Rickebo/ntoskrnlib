using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SEP_LOGON_SESSION_REFERENCES")]
    public sealed class _SEP_LOGON_SESSION_REFERENCES : DynamicStructure
    {
        public _SEP_LOGON_SESSION_REFERENCES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_LOGON_SESSION_REFERENCES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_SEP_LOGON_SESSION_REFERENCES>((mem, ptr) => new _SEP_LOGON_SESSION_REFERENCES(mem, ptr), offsets);
        }
    }
}