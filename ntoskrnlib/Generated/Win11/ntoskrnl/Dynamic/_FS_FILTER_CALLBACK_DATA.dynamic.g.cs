using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FS_FILTER_CALLBACK_DATA")]
    public sealed class _FS_FILTER_CALLBACK_DATA : DynamicStructure
    {
        public uint SizeOfFsFilterCallbackData { get; }
        public byte Operation { get; }
        public byte Reserved { get; }
        public IntPtr DeviceObject { get; }
        public IntPtr FileObject { get; }
        public _FS_FILTER_PARAMETERS Parameters { get; }

        public _FS_FILTER_CALLBACK_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FS_FILTER_CALLBACK_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FS_FILTER_CALLBACK_DATA.SizeOfFsFilterCallbackData),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACK_DATA.Operation),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACK_DATA.Reserved),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACK_DATA.DeviceObject),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACK_DATA.FileObject),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FS_FILTER_CALLBACK_DATA.Parameters),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_FS_FILTER_CALLBACK_DATA>((mem, ptr) => new _FS_FILTER_CALLBACK_DATA(mem, ptr), offsets);
        }
    }
}