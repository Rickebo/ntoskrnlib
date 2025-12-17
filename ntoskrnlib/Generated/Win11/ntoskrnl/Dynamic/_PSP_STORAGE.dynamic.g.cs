using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PSP_STORAGE")]
    public sealed class _PSP_STORAGE : DynamicStructure
    {
        public _PSP_STORAGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PSP_STORAGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_PSP_STORAGE>((mem, ptr) => new _PSP_STORAGE(mem, ptr), offsets);
        }
    }
}