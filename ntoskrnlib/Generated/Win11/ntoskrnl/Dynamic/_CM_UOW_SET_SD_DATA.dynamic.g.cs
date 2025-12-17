using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_UOW_SET_SD_DATA")]
    public sealed class _CM_UOW_SET_SD_DATA : DynamicStructure
    {
        public uint SecurityCell { get; }
        public IntPtr Hive { get; }

        public _CM_UOW_SET_SD_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_UOW_SET_SD_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_UOW_SET_SD_DATA.SecurityCell),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_UOW_SET_SD_DATA.Hive),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CM_UOW_SET_SD_DATA>((mem, ptr) => new _CM_UOW_SET_SD_DATA(mem, ptr), offsets);
        }
    }
}