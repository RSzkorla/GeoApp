using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GeoAppServer.BLL
{
  public class QuestionReader
  {
    public List<Question> GenerateQuestions()
    {
      using (StreamReader r = new StreamReader(Path.Combine("wwwroot", "questions", "questions.json")))
        return JsonConvert.DeserializeObject<List<Question>>(r.ReadToEnd());
    }
  }
}
