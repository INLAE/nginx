using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class Model2Controller : ControllerBase
{
    private static List<Model2> _models = new List<Model2>();

    [HttpGet]
    public ActionResult<List<Model2>> GetAll()
    {
        return _models;
    }

    [HttpGet("{id}")]
    public ActionResult<Model2> GetById(int id)
    {
        var existingModel = _models.FirstOrDefault(m => m.Id == id);
        if (existingModel == null)
        {
            return NotFound();
        }
        return existingModel;
    }

    [HttpPost]
    public ActionResult<Model2> Create(Model2 model)
    {
        model.Id = _models.Count + 1;
        _models.Add(model);
        return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Model2 model)
    {
        var existingModel = _models.FirstOrDefault(m => m.Id == id);
        if (existingModel == null)
        {
            return NotFound();
        }
        existingModel.Body = model.Body;
        return NoContent();
    }
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var existingModel = _models.FirstOrDefault(m => m.Id == id);
        if (existingModel == null)
        {
            return NotFound();
        }
        _models.Remove(existingModel);
        return NoContent();
    }
}