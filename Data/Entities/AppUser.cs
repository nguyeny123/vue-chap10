using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using ECommerce.Data.Entities.Orders;
namespace ECommerce.Data.Entities
{
public class AppUser : IdentityUser<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string RefreshToken { get; set; }
    [NotMapped]
    public string FullName
    {
        get { return $"{FirstName} {LastName}"; }
    }
    public List<Orderss> Orders { get; set; } = new List<Orderss>();
}
}