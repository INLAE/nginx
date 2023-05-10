using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class Model1Controller : ControllerBase
{
    private static List<Model1> _models = new List<Model1>();

    [HttpGet]
    public ActionResult<List<Model1>> GetAll()
    {
        return _models;
    }

    [HttpGet("{id}")]
    public ActionResult<Model1> GetById(int id)
    {
        var existingModel = _models.FirstOrDefault(m => m.Id == id);
        if (existingModel == null)
        {
            return NotFound();
        }
        return existingModel;
    }

    [HttpPost]
    public ActionResult<Model1> Create(Model1 model)
    {
        model.Id = _models.Count + 1;
        _models.Add(model);
        return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Model1 model)
    {
        var existingModel = _models.FirstOrDefault(m => m.Id == id);
        if (existingModel == null)
        {
            return NotFound();
        }
        existingModel.Description = model.Description;
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