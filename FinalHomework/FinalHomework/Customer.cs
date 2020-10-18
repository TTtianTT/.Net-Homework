namespace OrderManagementDatabase
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Customer
    {
        //key
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"Customer name:{Name}   Customer address:{Address}";
        }
    }
}