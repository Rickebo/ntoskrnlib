using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SCSI_REQUEST_BLOCK")]
    public sealed class _SCSI_REQUEST_BLOCK : DynamicStructure
    {
        public _SCSI_REQUEST_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SCSI_REQUEST_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_SCSI_REQUEST_BLOCK>((mem, ptr) => new _SCSI_REQUEST_BLOCK(mem, ptr), offsets);
        }
    }
}