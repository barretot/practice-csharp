namespace MyFirstApi.Communication.Response
{
    public class ResponseRegisterUser
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = String.Empty;
    }
}
