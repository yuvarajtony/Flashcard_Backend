using Model;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;
using EntityLayer.Entities;

namespace BusinessLogicLayer
{
    public class Logic : ILogic
    {
        Mappers map = new Mappers();
        Repo repo = new Repo();
        FlashcardDbContext context = new FlashcardDbContext();

        public flashcard_model AddFlashcard(flashcard_model flashcard)
        {
            return map.EMmapper(repo.AddFlashcard(map.MEmapper(flashcard)));  
        }

        public flashcard_model GetFlashcardByID(int id)
        {
            return map.EMmapper(repo.GetFlashcardByID(id));
        }

        public List<flashcard_model> GetFlashcards()
        {
            List<flashcard_model> flash = new List<flashcard_model>();

            foreach(var i in repo.GetFlashcards())
            {
                flash.Add(map.EMmapper(i));
            }

            return flash;
        }

        public bool RemoveFlashcard(int id)
        {
            return repo.RemoveFlashcard(id);
        }

        public flashcard_model UpdateFlashcard(flashcard_model flashcard, int id)
        {
            var flash = flashcardbyid(id);

            flash.FlashcardId = flashcard.flashcard_id;
            flash.Question = flashcard.question;
            flash.Answer = flashcard.answer;

            return map.EMmapper(repo.UpdateFlashcard(flash));
        }

        public Flashcard flashcardbyid(int id)
        {
            return context.Flashcards.Where(i => i.FlashcardId == id).FirstOrDefault();
        }
    }
}
