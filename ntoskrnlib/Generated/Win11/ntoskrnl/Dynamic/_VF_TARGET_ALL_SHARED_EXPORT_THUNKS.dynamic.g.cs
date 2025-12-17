using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_TARGET_ALL_SHARED_EXPORT_THUNKS")]
    public sealed class _VF_TARGET_ALL_SHARED_EXPORT_THUNKS : DynamicStructure
    {
        public IntPtr SharedExportThunks { get; }
        public IntPtr PoolSharedExportThunks { get; }
        public IntPtr XdvSharedExportThunks { get; }

        public _VF_TARGET_ALL_SHARED_EXPORT_THUNKS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_TARGET_ALL_SHARED_EXPORT_THUNKS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_TARGET_ALL_SHARED_EXPORT_THUNKS.SharedExportThunks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_TARGET_ALL_SHARED_EXPORT_THUNKS.PoolSharedExportThunks),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VF_TARGET_ALL_SHARED_EXPORT_THUNKS.XdvSharedExportThunks),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_VF_TARGET_ALL_SHARED_EXPORT_THUNKS>((mem, ptr) => new _VF_TARGET_ALL_SHARED_EXPORT_THUNKS(mem, ptr), offsets);
        }
    }
}