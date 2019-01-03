namespace GeoAppServer.BLL
{
  public class Question
  {
    public string QuestionText { get; set; } = "Pytanie";
    public string CorrectAnswer { get; set; } = "Poprawna odpowiedż";
    public string WrongAnswer1 { get; set; } = "Zła odpowiedź";
    public string WrongAnswer2 { get; set; } = "Zła odpowiedź";
    public string WrongAnswer3 { get; set; } = "Zła odpowiedź";

    public override string ToString()
    {
      string sep = ";";
      return QuestionText + sep +
             CorrectAnswer + sep +
             WrongAnswer1 + sep +
             WrongAnswer2 + sep +
             WrongAnswer3;
    }
  }
}