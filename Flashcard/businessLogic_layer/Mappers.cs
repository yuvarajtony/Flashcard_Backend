using Model;
using EL = EntityLayer.Entities;

namespace BusinessLogicLayer
{
    public class Mappers
    {
        // model to entity 

        public EL.Flashcard MEmapper(flashcard_model model)
        {
            return new EL.Flashcard()
            {
                FlashcardId = model.flashcard_id,
                Question = model.question,
                Answer = model.answer
            };
        }

        // entity to model

        public flashcard_model EMmapper(EL.Flashcard entity)
        {
            return new flashcard_model()
            {
                flashcard_id = entity.FlashcardId,
                question = entity.Question,
                answer = entity.Answer
            };
        }
    }
}