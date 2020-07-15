using demo.domain.Models.Administration;

namespace demo.domain.Mappers.Administration
{
public class UserMapper : BaseMapper<User>
{
    public UserMapper()
    {
        this.TableName = "ADM_Users";
    }
}
}