using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_COPY_INFORMATION")]
    public sealed class _COPY_INFORMATION : DynamicStructure
    {
        public IntPtr SourceFileObject { get; }
        public long SourceFileOffset { get; }

        public _COPY_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _COPY_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_COPY_INFORMATION.SourceFileObject),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_COPY_INFORMATION.SourceFileOffset),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_COPY_INFORMATION>((mem, ptr) => new _COPY_INFORMATION(mem, ptr), offsets);
        }
    }
}