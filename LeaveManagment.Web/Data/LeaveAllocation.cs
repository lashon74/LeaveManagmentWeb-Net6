using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagment.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public string? NumberOfDays { get; set; }
        //For foreign key
        [ForeignKey("LeaveTypeId")]
        public LeaveType? LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public string? EmployeeId { get; set; }

    }
}
