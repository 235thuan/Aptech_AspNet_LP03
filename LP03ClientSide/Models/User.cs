using System.ComponentModel.DataAnnotations;

namespace LP03ClientSide.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập tên")]
        [StringLength(50,ErrorMessage ="Độ dài tối đa 50 ký tự")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập email")]
        [EmailAddress(ErrorMessage ="Điền đúng định dạng email@example.com")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập tuổi")]
        [Range(1,100,ErrorMessage ="Tuổi từ 1 đến 100")]
        public int Age { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập số điện thoại")]
        [Phone(ErrorMessage ="Vui lòng nhập đúng định dạng")]
        public string PhoneNumber {  get; set; }
        [Required(ErrorMessage ="Vui lòng nhập địa chỉ")]
        [StringLength(100,ErrorMessage ="Độ dài tối đa 100 ký tự")]
        public string Address { get; set; }
        public ICollection<Work> Works { get; set; }
    }
}
