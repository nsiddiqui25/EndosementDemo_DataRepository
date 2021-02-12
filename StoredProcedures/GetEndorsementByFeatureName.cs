using System.ComponentModel.DataAnnotations;

namespace DataRepository.StoredProcedures
{
    public class GetEndorsementByFeatureName
    {
        [Key]
        public int FORM_VERSION_ID { get; set; }

        //public string FeatureName { get; set; }

        //public string State { get; set; }

        //public string CompanyPaper { get; set; }

        //public string FormSeries { get; set; }
    }
}
