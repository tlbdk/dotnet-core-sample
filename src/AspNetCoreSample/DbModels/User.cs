using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreSample.DbModels {
    public class User {
        public int Id { get; set; }
        
        [MaxLength(255)]
        public string FirstName { get; set; }
        
        [MaxLength(255)]
        public string LastName { get; set; }
        
        [MaxLength(255)]
        public string Email { get; set; }
        
        [MaxLength(255)]
        public string Phone { get; set; }

        public List<IdCard> IdCards { get; set; }
    }
}