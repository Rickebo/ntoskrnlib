using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEP_CACHED_HANDLES_ENTRY_DESCRIPTOR")]
    public sealed class _SEP_CACHED_HANDLES_ENTRY_DESCRIPTOR : DynamicStructure
    {
        public uint DescriptorType { get; }
        public IntPtr PackageSid { get; }
        public _UNICODE_STRING IsolationPrefix { get; }

        public _SEP_CACHED_HANDLES_ENTRY_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_CACHED_HANDLES_ENTRY_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEP_CACHED_HANDLES_ENTRY_DESCRIPTOR.DescriptorType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEP_CACHED_HANDLES_ENTRY_DESCRIPTOR.PackageSid),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SEP_CACHED_HANDLES_ENTRY_DESCRIPTOR.IsolationPrefix),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_SEP_CACHED_HANDLES_ENTRY_DESCRIPTOR>((mem, ptr) => new _SEP_CACHED_HANDLES_ENTRY_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}