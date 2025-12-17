using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DUMMY_FILE_OBJECT")]
    public sealed class _DUMMY_FILE_OBJECT : DynamicStructure
    {
        public _OBJECT_HEADER ObjectHeader { get; }
        public sbyte[] FileObjectBody { get; }

        public _DUMMY_FILE_OBJECT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DUMMY_FILE_OBJECT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DUMMY_FILE_OBJECT.ObjectHeader),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DUMMY_FILE_OBJECT.FileObjectBody),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_DUMMY_FILE_OBJECT>((mem, ptr) => new _DUMMY_FILE_OBJECT(mem, ptr), offsets);
        }
    }
}