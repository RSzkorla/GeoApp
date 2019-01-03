using System;
using System.Collections.Generic;
using System.Linq;
using GeoAppServer.BLL;
using Microsoft.AspNetCore.Mvc;

namespace GeoAppServer.Controllers
{
  [Route("api/[controller]")]
  public class QuestionController : Controller
  {
    private static readonly List<Question> _questions = GenerateQuestions();

    private static List<Question> GenerateQuestions()
    {
      var list = new List<Question>();
      for (var i = 0; i < 5; i++)
        list.Add(new Question {QuestionText = "Pytanie " + i});
      return list;
    }

    // GET api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new[] {"value1", "value2"};
    }

    [HttpGet("get")]
    public string GetRandomQuestion()
    {
      return _questions.ElementAt(new Random().Next(_questions.Count)).ToString();
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }
  }
}