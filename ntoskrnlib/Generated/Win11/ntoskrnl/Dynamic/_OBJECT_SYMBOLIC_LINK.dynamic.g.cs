using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_SYMBOLIC_LINK")]
    public sealed class _OBJECT_SYMBOLIC_LINK : DynamicStructure
    {
        public _LARGE_INTEGER CreationTime { get; }
        public _UNICODE_STRING LinkTarget { get; }
        public IntPtr Callback { get; }
        public IntPtr CallbackContext { get; }
        public uint DosDeviceDriveIndex { get; }
        public uint Flags { get; }
        public uint AccessMask { get; }
        public uint IntegrityLevel { get; }

        public _OBJECT_SYMBOLIC_LINK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_SYMBOLIC_LINK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_SYMBOLIC_LINK.CreationTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_SYMBOLIC_LINK.LinkTarget),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBJECT_SYMBOLIC_LINK.Callback),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBJECT_SYMBOLIC_LINK.CallbackContext),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OBJECT_SYMBOLIC_LINK.DosDeviceDriveIndex),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_OBJECT_SYMBOLIC_LINK.Flags),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_OBJECT_SYMBOLIC_LINK.AccessMask),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_OBJECT_SYMBOLIC_LINK.IntegrityLevel),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_OBJECT_SYMBOLIC_LINK>((mem, ptr) => new _OBJECT_SYMBOLIC_LINK(mem, ptr), offsets);
        }
    }
}