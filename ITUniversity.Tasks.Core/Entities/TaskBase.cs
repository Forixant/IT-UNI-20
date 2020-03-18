using System;

using ITUniversity.Tasks.Enums;

namespace ITUniversity.Tasks.Entities
                                {
    /// <summary>
    /// Базовый класс задач
    /// </summary>
    public class TaskBase
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Тема
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Descr { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public TaskStatus Status { get; set; }

        /// <summary>
        /// Перегрузка проверки на равенство
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        /// <returns></returns>
        public static bool operator ==(TaskBase obj1, TaskBase obj2)
        {
            if (obj1.Id == obj2.Id &&
                obj1.Subject == obj2.Subject &&
                obj1.Descr == obj2.Descr &&
                obj1.CreationDate == obj2.CreationDate &&
                obj1.Status == obj2.Status)
                return true;
            return false;
        }

        /// <summary>
        /// Обязательная перегрузка проверки на неравенство
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        /// <returns></returns>
        public static bool operator !=(TaskBase obj1, TaskBase obj2)
        {
            if (obj1.Id == obj2.Id &&
                obj1.Subject == obj2.Subject &&
                obj1.Descr == obj2.Descr &&
                obj1.CreationDate == obj2.CreationDate &&
                obj1.Status == obj2.Status)
                return false;
            return true;
        }
    }
}