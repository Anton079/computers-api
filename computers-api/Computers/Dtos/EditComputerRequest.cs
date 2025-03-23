namespace computers_api.Computers.Dtos
{
    public class EditComputerRequest
    {
        public string Type {  get; set; }

        public string Model {  get; set; }

        public int? Price {  get; set; }
    }
}
