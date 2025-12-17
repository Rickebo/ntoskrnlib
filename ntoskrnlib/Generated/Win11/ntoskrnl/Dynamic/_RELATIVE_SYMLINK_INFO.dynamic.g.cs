using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RELATIVE_SYMLINK_INFO")]
    public sealed class _RELATIVE_SYMLINK_INFO : DynamicStructure
    {
        public ushort ExposedNamespaceLength { get; }
        public ushort Flags { get; }
        public ushort DeviceNameLength { get; }
        public ushort Reserved { get; }
        public IntPtr InteriorMountPoint { get; }
        public _UNICODE_STRING OpenedName { get; }

        public _RELATIVE_SYMLINK_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RELATIVE_SYMLINK_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RELATIVE_SYMLINK_INFO.ExposedNamespaceLength),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RELATIVE_SYMLINK_INFO.Flags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_RELATIVE_SYMLINK_INFO.DeviceNameLength),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RELATIVE_SYMLINK_INFO.Reserved),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_RELATIVE_SYMLINK_INFO.InteriorMountPoint),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RELATIVE_SYMLINK_INFO.OpenedName),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_RELATIVE_SYMLINK_INFO>((mem, ptr) => new _RELATIVE_SYMLINK_INFO(mem, ptr), offsets);
        }
    }
}