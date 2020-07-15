using System;

namespace demo.domain.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public int? CreatedUserId { get; set; }
        public int? ModifiedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public void SetModifier(int userId)
        {
            this.ModifiedDate = DateTime.Now;
            this.ModifiedUserId = userId;
            this.CreatedDate = DateTime.Now;
            this.CreatedUserId = userId;
        }

        public void SetUpdateModifier(int userId)
        {
            this.ModifiedDate = DateTime.Now;
            this.ModifiedUserId = userId;
        }

        public void SetDeleteModifier(int userId)
        {
            this.ModifiedUserId = userId;
            this.ModifiedDate = DateTime.Now;
            this.IsDeleted = true;
        }
    }
}
