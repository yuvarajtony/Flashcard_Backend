using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogicLayer;
using Model;

namespace FlashCardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlashCardController : ControllerBase
    {
        ILogic logic;

        public FlashCardController(ILogic logic)
        {
            this.logic = logic;
        }


        [HttpPost("AddFlashcard")]
        public IActionResult AddFlashCard([FromBody] flashcard_model flashcard)
        {
            try
            {
                var flash = logic.AddFlashcard(flashcard);
                return Ok(flash);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut("UpdateFlashcard/{id}")]
        public IActionResult UpdateFlashcard([FromBody] flashcard_model flashcard,[FromRoute] int id)
        {
            try
            {
                if (id != null)
                {
                    logic.UpdateFlashcard(flashcard, id);
                    return Ok(flashcard);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("GelAllFlashcard")]
        public IActionResult GetAllFlashcard()
        {
            try
            {
                var flash = logic.GetFlashcards();

                if(flash.Count() > 0)
                {
                    return Ok(flash);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("GetFlashcardbyID/{id}")]
        public IActionResult GetAllFlashcardbyID([FromRoute] int id)
        {
            try
            {
                var flash = logic.GetFlashcardByID(id);
                return Ok(flash);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("DeleteFlashCard/{id}")]
        public IActionResult DeleteFlashcard([FromRoute] int id)
        {
            try
            {
                var flash = logic.RemoveFlashcard(id);
                if(flash)
                {
                    return Ok("Deleted");
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
