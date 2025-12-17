using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_DIRECTORY")]
    public sealed class _OBJECT_DIRECTORY : DynamicStructure
    {
        public byte[] HashBuckets { get; }
        public _EX_PUSH_LOCK Lock { get; }
        public IntPtr DeviceMap { get; }
        public IntPtr ShadowDirectory { get; }
        public IntPtr NamespaceEntry { get; }
        public IntPtr SessionObject { get; }
        public uint Flags { get; }
        public uint SessionId { get; }

        public _OBJECT_DIRECTORY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_DIRECTORY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_DIRECTORY.HashBuckets),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_DIRECTORY.Lock),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_OBJECT_DIRECTORY.DeviceMap),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_OBJECT_DIRECTORY.ShadowDirectory),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_OBJECT_DIRECTORY.NamespaceEntry),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_OBJECT_DIRECTORY.SessionObject),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_OBJECT_DIRECTORY.Flags),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_OBJECT_DIRECTORY.SessionId),
                    new ulong[]
                    {
                        340UL
                    }
                }
            };
            Register<_OBJECT_DIRECTORY>((mem, ptr) => new _OBJECT_DIRECTORY(mem, ptr), offsets);
        }
    }
}