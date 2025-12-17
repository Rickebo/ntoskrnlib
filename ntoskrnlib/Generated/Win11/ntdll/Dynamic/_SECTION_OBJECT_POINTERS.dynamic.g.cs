using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SECTION_OBJECT_POINTERS")]
    public sealed class _SECTION_OBJECT_POINTERS : DynamicStructure
    {
        public IntPtr DataSectionObject { get; }
        public IntPtr SharedCacheMap { get; }
        public IntPtr ImageSectionObject { get; }

        public _SECTION_OBJECT_POINTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SECTION_OBJECT_POINTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SECTION_OBJECT_POINTERS.DataSectionObject),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SECTION_OBJECT_POINTERS.SharedCacheMap),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SECTION_OBJECT_POINTERS.ImageSectionObject),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_SECTION_OBJECT_POINTERS>((mem, ptr) => new _SECTION_OBJECT_POINTERS(mem, ptr), offsets);
        }
    }
}