using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SK_CRASH_MINIDUMP")]
    public sealed class _SK_CRASH_MINIDUMP : DynamicStructure
    {
        public uint Size { get; }
        public uint Version { get; }
        public uint ModuleCount { get; }
        public uint FrameCount { get; }
        public byte[] Modules { get; }
        public byte[] StackFrames { get; }

        public _SK_CRASH_MINIDUMP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SK_CRASH_MINIDUMP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SK_CRASH_MINIDUMP.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SK_CRASH_MINIDUMP.Version),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_SK_CRASH_MINIDUMP.ModuleCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SK_CRASH_MINIDUMP.FrameCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_SK_CRASH_MINIDUMP.Modules),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SK_CRASH_MINIDUMP.StackFrames),
                    new ulong[]
                    {
                        1168UL
                    }
                }
            };
            Register<_SK_CRASH_MINIDUMP>((mem, ptr) => new _SK_CRASH_MINIDUMP(mem, ptr), offsets);
        }
    }
}