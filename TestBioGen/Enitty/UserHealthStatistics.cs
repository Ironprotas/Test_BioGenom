namespace TestBioGen.Enitty;

public class UserHealthStatistics
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public UserEntity User { get; set; }
    public DateTime AddAt { get; set; }
    public double VitamineC { get; set; }
    public double VitamineD { get; set; }
    public double Water { get; set; }
    ///
    /// etc
    /// 
}