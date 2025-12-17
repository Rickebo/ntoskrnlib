using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IOP_FILE_OBJECT_EXTENSION")]
    public sealed class _IOP_FILE_OBJECT_EXTENSION : DynamicStructure
    {
        public _IOP_FILE_OBJECT_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOP_FILE_OBJECT_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_IOP_FILE_OBJECT_EXTENSION>((mem, ptr) => new _IOP_FILE_OBJECT_EXTENSION(mem, ptr), offsets);
        }
    }
}