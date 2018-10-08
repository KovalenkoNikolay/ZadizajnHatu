using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataRepository.DbEntities.Users
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        public string LoginName { get; set; } //Email
        public string PhoneNumber { get; set; }
        public DateTime RegisteredDate { get; set; }
        public Guid DesignerId { get; set; }
        public Guid ClientId { get; set; }

        public Designer Designer { get; set; }
        public Client Client { get; set; }
    }
}

// Designer
//UserId
//LoginName
//FirstName
//LastName
//OR
//Company
//Description
//Price:
//Чертежи
//Чертежи+Визуализация
//Дизайн проект+Авторский надзор
//Check
//Чертежи
//Чертежи+Визуализация
//Дизайн проект+Авторский надзор
//Avatar
//Contact Info: 
//Phone Numbers, 
//Links: Pinterest, Behance, Twitter, Facebook, Site, Instagramm
//Place: Country, City, Addresse
//Email


// Client
//UserId
//Login
//Phone Number

// Task
// Max price
// Description
//Чертежи
//Чертежи+Визуализация
//Дизайн проект+Авторский надзор
//Plan photo
//Status