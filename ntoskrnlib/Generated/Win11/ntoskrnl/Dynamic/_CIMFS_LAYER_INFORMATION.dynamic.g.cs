using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CIMFS_LAYER_INFORMATION")]
    public sealed class _CIMFS_LAYER_INFORMATION : DynamicStructure
    {
        public _GUID TargetVolume { get; }
        public IntPtr CimFiles { get; }
        public uint CimFilesCount { get; }
        public uint MountFlags { get; }
        public byte ParentIsVsmb { get; }
        public IntPtr ParentDeviceArcName { get; }

        public _CIMFS_LAYER_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CIMFS_LAYER_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CIMFS_LAYER_INFORMATION.TargetVolume),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CIMFS_LAYER_INFORMATION.CimFiles),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CIMFS_LAYER_INFORMATION.CimFilesCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CIMFS_LAYER_INFORMATION.MountFlags),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_CIMFS_LAYER_INFORMATION.ParentIsVsmb),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CIMFS_LAYER_INFORMATION.ParentDeviceArcName),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_CIMFS_LAYER_INFORMATION>((mem, ptr) => new _CIMFS_LAYER_INFORMATION(mem, ptr), offsets);
        }
    }
}