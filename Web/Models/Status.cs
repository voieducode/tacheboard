namespace TacheBoard.Web.Models
{
    /// <summary>
    /// Represents a possible system status
    /// </summary>
    public class Status
    {
        public string Id { get; set; }
        public string Default { get; set; }  
        public string Description { get; set; }
        public string Level { get; set; }
        public string Image { get; set; }  
    }
}