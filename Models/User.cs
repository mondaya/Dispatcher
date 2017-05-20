namespace Dispatcher.Models
{
    public class User : BaseEntity
    {

     public string firstName;

     public string lastName;

     public string email;

     public int userTypeId;

     public UserType userType;


    }
}