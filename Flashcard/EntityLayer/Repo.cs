using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Repo : IRepo
    {
        FlashcardDbContext context = new FlashcardDbContext();

        public Flashcard AddFlashcard(Flashcard flashcard)
        {
            context.Flashcards.Add(flashcard);
            context.SaveChanges();

            return flashcard;
        }
        public List<Flashcard> GetFlashcards()
        {
            return context.Flashcards.ToList();
        }

        public Flashcard GetFlashcardByID(int id)
        {
            var flashcards = context.Flashcards;
            var query = from cards in flashcards
                        where cards.FlashcardId == id
                        select cards;

            Flashcard flashcard = new Flashcard();

            foreach(var card in query)
            {
                flashcard = new Flashcard()
                {
                    FlashcardId = card.FlashcardId,
                    Question = card.Question,
                    Answer = card.Answer,
                };
            }

            return flashcard;
        }

        public Flashcard UpdateFlashcard(Flashcard flashcard)
        {
            context.Flashcards.Update(flashcard);
            context.SaveChanges();

            return flashcard;
        }

        public bool RemoveFlashcard(int id)
        {
            var cards = context.Flashcards.Where(i => i.FlashcardId == id).FirstOrDefault();    

            if (cards != null)
            {
                context.Flashcards.Remove(cards);
                context.SaveChanges();
                return true;
            }

            return false;
        }

    }
}
