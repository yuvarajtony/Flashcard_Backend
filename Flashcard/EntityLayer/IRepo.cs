using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entities;

namespace EntityLayer
{
    interface IRepo
    {
        /// <summary>
        /// used to get all flashcards from database
        /// </summary>
        /// <returns>return all flashcards</returns>
        public List<Flashcard> GetFlashcards();

        /// <summary>
        /// used to get single flashcard from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>return single flashcard</returns>
        public Flashcard GetFlashcardByID(int id);

        /// <summary>
        /// used to insert flashcard into database
        /// </summary>
        /// <param name="flashcard"></param>
        /// <returns>return the inserted flashcard</returns>
        public Flashcard AddFlashcard(Flashcard flashcard);

        /// <summary>
        /// used to update flashcard based on ID
        /// </summary>
        /// <param name="flashcard"></param>
        /// <returns>return the updated flashcard</returns>
        public Flashcard UpdateFlashcard(Flashcard flashcard);
        
        /// <summary>
        /// used to delete flashcard in database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>return true if deleted else flase</returns>
        public bool RemoveFlashcard(int id);

    }
}
