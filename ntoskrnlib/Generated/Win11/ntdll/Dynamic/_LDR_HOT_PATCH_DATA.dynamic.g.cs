using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_LDR_HOT_PATCH_DATA")]
    public sealed class _LDR_HOT_PATCH_DATA : DynamicStructure
    {
        public uint Version { get; }
        public IntPtr PatchLoadLibrary { get; }
        public IntPtr PatchGetProcAddress { get; }

        public _LDR_HOT_PATCH_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LDR_HOT_PATCH_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LDR_HOT_PATCH_DATA.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LDR_HOT_PATCH_DATA.PatchLoadLibrary),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LDR_HOT_PATCH_DATA.PatchGetProcAddress),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_LDR_HOT_PATCH_DATA>((mem, ptr) => new _LDR_HOT_PATCH_DATA(mem, ptr), offsets);
        }
    }
}