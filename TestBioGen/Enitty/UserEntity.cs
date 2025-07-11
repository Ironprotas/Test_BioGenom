namespace TestBioGen.Enitty;

public class UserEntity
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public UserQuestionnaireEnity Questionnaires { get; set; } 
    public List<UserHealthStatistics> HealthStatistics { get; set; } = new List<UserHealthStatistics>();
    ///
    /// etc.
    /// 
}