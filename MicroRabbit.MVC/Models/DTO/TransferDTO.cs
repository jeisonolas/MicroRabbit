namespace MicroRabbit.MVC.Models.DTO
{
    public class TransferDTO
    {
        public int ToAccount { get; set; }
        public int FromAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
