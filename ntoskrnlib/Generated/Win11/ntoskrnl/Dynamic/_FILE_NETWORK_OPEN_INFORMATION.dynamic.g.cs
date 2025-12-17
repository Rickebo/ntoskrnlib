using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FILE_NETWORK_OPEN_INFORMATION")]
    public sealed class _FILE_NETWORK_OPEN_INFORMATION : DynamicStructure
    {
        public _LARGE_INTEGER CreationTime { get; }
        public _LARGE_INTEGER LastAccessTime { get; }
        public _LARGE_INTEGER LastWriteTime { get; }
        public _LARGE_INTEGER ChangeTime { get; }
        public _LARGE_INTEGER AllocationSize { get; }
        public _LARGE_INTEGER EndOfFile { get; }
        public uint FileAttributes { get; }

        public _FILE_NETWORK_OPEN_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FILE_NETWORK_OPEN_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FILE_NETWORK_OPEN_INFORMATION.CreationTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FILE_NETWORK_OPEN_INFORMATION.LastAccessTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FILE_NETWORK_OPEN_INFORMATION.LastWriteTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FILE_NETWORK_OPEN_INFORMATION.ChangeTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FILE_NETWORK_OPEN_INFORMATION.AllocationSize),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_FILE_NETWORK_OPEN_INFORMATION.EndOfFile),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_FILE_NETWORK_OPEN_INFORMATION.FileAttributes),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_FILE_NETWORK_OPEN_INFORMATION>((mem, ptr) => new _FILE_NETWORK_OPEN_INFORMATION(mem, ptr), offsets);
        }
    }
}