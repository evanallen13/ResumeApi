namespace ResumeApi.model
{
    public class modEducation
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string school { get; set; } = string.Empty;
        public string degree { get; set; } = string.Empty;
        public DateTime? startDate { get; set; } = null;
        public DateTime? endDate { get; set; } = null;
    }
}
