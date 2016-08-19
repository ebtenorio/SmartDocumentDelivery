using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartDocDeliveryLibrary.Interfaces;

namespace SmartDocDeliveryLibrary.DTOs
{
    public class DTOCycleFilename : ICycleFilename
    {

        private string m_CycleFilename;

        public string Filename
        {
            get
            {
                return this.m_CycleFilename;
            }
            set
            {
                this.m_CycleFilename = value;
            }
        }

    }

    public class DTOCycleFilenameList : List<DTOCycleFilename>, IDisposable
    {
        public void Dispose()
        {
        }
    }

}
