using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreSample.DbModels
{
    public class IdCard
    {
        public int Id { get; set; }
        
        [MaxLength(10)]
        public string Type { get; set; }
        
        [MaxLength(24)]
        public string Ssn { get; set; }
        
        [MaxLength(24)]
        public string DocumentNumber { get; set; }
        
        public DateTime IssueDate { get; set; }
        
        public DateTime ExpiresDate { get; set; }
        
        public byte[] Image { get; set; }
        
        [MaxLength(255)]
        public string MimeType { get; set; }
        
        // Metadata
        public DateTime CreatedDate { get; set; }
        
        public DateTime UpdatedDate { get; set; }

        // References
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}