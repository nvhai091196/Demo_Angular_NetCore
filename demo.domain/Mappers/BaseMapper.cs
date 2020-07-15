using demo.domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demo.domain.Mappers
{
    public class BaseMapper<T> : IEntityTypeConfiguration<T> where T : BaseModel
    {
        protected string TableName { get; set; }
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.ToTable(TableName);
            builder.Property(g => g.Id).IsRequired();
        }
    }
}
