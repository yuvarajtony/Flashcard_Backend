using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface ILogic
    {
        /// <summary>
        /// used to get all flashcards from database
        /// </summary>
        /// <returns>return all flashcards</returns>
        public List<flashcard_model> GetFlashcards();

        /// <summary>
        /// used to get single flashcard from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>return single flashcard</returns>
        public flashcard_model GetFlashcardByID(int id);

        /// <summary>
        /// used to insert flashcard into database
        /// </summary>
        /// <param name="flashcard"></param>
        /// <returns>return the inserted flashcard</returns>
        public flashcard_model AddFlashcard(flashcard_model flashcard);

        /// <summary>
        ///  used to update flashcard based on ID
        /// </summary>
        /// <param name="flashcard"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public flashcard_model UpdateFlashcard(flashcard_model flashcard, int id);

        /// <summary>
        /// used to delete flashcard in database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>return true if deleted else flase</returns>
        public bool RemoveFlashcard(int id);
    }
}
