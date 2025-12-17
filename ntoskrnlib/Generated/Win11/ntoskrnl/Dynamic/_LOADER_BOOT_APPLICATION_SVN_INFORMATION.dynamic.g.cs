using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOADER_BOOT_APPLICATION_SVN_INFORMATION")]
    public sealed class _LOADER_BOOT_APPLICATION_SVN_INFORMATION : DynamicStructure
    {
        public _LARGE_INTEGER BootStlCreationTime { get; }
        public uint HiberrsmMinSvn { get; }

        public _LOADER_BOOT_APPLICATION_SVN_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOADER_BOOT_APPLICATION_SVN_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOADER_BOOT_APPLICATION_SVN_INFORMATION.BootStlCreationTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_BOOT_APPLICATION_SVN_INFORMATION.HiberrsmMinSvn),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_LOADER_BOOT_APPLICATION_SVN_INFORMATION>((mem, ptr) => new _LOADER_BOOT_APPLICATION_SVN_INFORMATION(mem, ptr), offsets);
        }
    }
}