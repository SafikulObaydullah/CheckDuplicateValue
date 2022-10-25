namespace CheckDuplicateValue.Models
{
   public class MessageHelper
   {
      public int Id { get; set; }   
      public string Message { get; set; }
      public int Status { get; set; }
      public DateTime Created { get; set; } = DateTime.Now;
   }
}
