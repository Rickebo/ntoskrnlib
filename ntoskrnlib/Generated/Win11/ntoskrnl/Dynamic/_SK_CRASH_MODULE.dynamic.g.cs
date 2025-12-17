using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SK_CRASH_MODULE")]
    public sealed class _SK_CRASH_MODULE : DynamicStructure
    {
        public short[] ImageName { get; }
        public uint SizeOfImage { get; }
        public uint TimeDateStamp { get; }

        public _SK_CRASH_MODULE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SK_CRASH_MODULE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SK_CRASH_MODULE.ImageName),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SK_CRASH_MODULE.SizeOfImage),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_SK_CRASH_MODULE.TimeDateStamp),
                    new ulong[]
                    {
                        68UL
                    }
                }
            };
            Register<_SK_CRASH_MODULE>((mem, ptr) => new _SK_CRASH_MODULE(mem, ptr), offsets);
        }
    }
}