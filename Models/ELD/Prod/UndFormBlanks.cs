using System;
using System.Collections.Generic;

namespace DataRepository.Models.ELD.Prod
{
    public partial class UndFormBlanks
    {
        public int BlanksId { get; set; }

        public int? FormTransId { get; set; }

        public string BlankNo { get; set; }

        public string BlankText { get; set; }

        public DateTime? LastChangedDate { get; set; }

        public string LastChangedId { get; set; }

        public string Ano { get; set; }

        public DateTime? Adate { get; set; }

        public string Fno { get; set; }

        public byte[] RowVersion { get; set; }

        public string BlankTextRtf { get; set; }

        public UndFormTrans FormTrans { get; set; }
    }
}
