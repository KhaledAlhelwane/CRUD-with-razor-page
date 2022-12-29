using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalProfit.Model
{
    public class User
    {
        public int Id { get; set; }
        public string ? Name { get; set; }
        public string ?type { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Display(Name="Monthly Pyment")]
        public double MonthlyPyment { get; set; }
        
        [Display(Name="all amount")]
        public double Allamount { get; set; }
        [Display(Name="Remaing Quantity")]
        public double RemainingQuantity { get; set; }
        [Display(Name="Preentage profit")]
        public float PrecentageProfit { get; set; }
    }
}
