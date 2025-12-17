using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_IMAGE_ADDITIONAL_FLAGS")]
    public sealed class _MI_IMAGE_ADDITIONAL_FLAGS : DynamicStructure
    {
        public uint SizeOfHeader { get; }
        public uint FilesystemWantsRva { get; }

        public _MI_IMAGE_ADDITIONAL_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_IMAGE_ADDITIONAL_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_IMAGE_ADDITIONAL_FLAGS.SizeOfHeader),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_IMAGE_ADDITIONAL_FLAGS.FilesystemWantsRva),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_IMAGE_ADDITIONAL_FLAGS>((mem, ptr) => new _MI_IMAGE_ADDITIONAL_FLAGS(mem, ptr), offsets);
        }
    }
}