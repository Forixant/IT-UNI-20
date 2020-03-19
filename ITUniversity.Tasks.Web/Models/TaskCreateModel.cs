using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ITUniversity.Tasks.Web.Models
{
    /// <summary>
    /// Модель создания задачи
    /// </summary>
    public class TaskCreateModel
    {
        /// <summary>
        /// Создание экземпляра класса
        /// </summary>
        public static TaskCreateModel New
        {
            get { return new TaskCreateModel(); }
        }

        /// <summary>
        /// Тема
        /// </summary>
        [Required(ErrorMessage ="Заполните обязательное поле")]

        public string Subject
        {
            get;
            set;
        }

        /// <summary>
        /// Описание
        /// </summary>
        public string Descr
        {
            get;
            set;
        }
    }
}