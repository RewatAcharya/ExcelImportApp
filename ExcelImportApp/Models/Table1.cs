using System.ComponentModel.DataAnnotations;

namespace ExcelImportApp.Models
{
    public class Table1
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string DOB { get; set; }
        public string IsInjured { get; set; }
        public string Education { get; set; }
        public string Occupation { get; set; }
        public string Relation { get; set; }
        public string RelationDOB { get; set; }
        public string Index { get; set; }
        public string ParentTableName { get; set; }
        public string ParentIndex { get; set; }
        public string SubId { get; set; }
        public string SubUUID { get; set; }
        public string SubTime { get; set; }
        public string SubValidation { get; set; }
        public string SubNotes { get; set; }
        public string SubStatus { get; set; }
        public string SubBy { get; set; }
        public string SubVersion { get; set; }
        public string SubTags { get; set; }
    }
}
