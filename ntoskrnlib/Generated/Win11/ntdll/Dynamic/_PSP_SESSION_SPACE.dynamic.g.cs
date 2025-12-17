using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PSP_SESSION_SPACE")]
    public sealed class _PSP_SESSION_SPACE : DynamicStructure
    {
        public _PSP_SESSION_SPACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PSP_SESSION_SPACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_PSP_SESSION_SPACE>((mem, ptr) => new _PSP_SESSION_SPACE(mem, ptr), offsets);
        }
    }
}