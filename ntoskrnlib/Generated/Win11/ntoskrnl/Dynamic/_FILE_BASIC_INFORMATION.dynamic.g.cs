using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FILE_BASIC_INFORMATION")]
    public sealed class _FILE_BASIC_INFORMATION : DynamicStructure
    {
        public _LARGE_INTEGER CreationTime { get; }
        public _LARGE_INTEGER LastAccessTime { get; }
        public _LARGE_INTEGER LastWriteTime { get; }
        public _LARGE_INTEGER ChangeTime { get; }
        public uint FileAttributes { get; }

        public _FILE_BASIC_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FILE_BASIC_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FILE_BASIC_INFORMATION.CreationTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FILE_BASIC_INFORMATION.LastAccessTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FILE_BASIC_INFORMATION.LastWriteTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FILE_BASIC_INFORMATION.ChangeTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FILE_BASIC_INFORMATION.FileAttributes),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_FILE_BASIC_INFORMATION>((mem, ptr) => new _FILE_BASIC_INFORMATION(mem, ptr), offsets);
        }
    }
}