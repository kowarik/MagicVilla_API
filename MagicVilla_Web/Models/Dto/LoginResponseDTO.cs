namespace MagicVilla_Web.Models.Dto
{
    public class LoginResponseDTO
    {
        public LocalUserDTO User { get; set; }
        public string Token { get; set; }
    }
}
