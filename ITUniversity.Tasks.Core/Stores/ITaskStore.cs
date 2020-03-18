using ITUniversity.Tasks.Entities;

namespace ITUniversity.Tasks.Stores
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITaskStore
    {
        /// <summary>
        /// Добавление задачи
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        TaskBase Save(TaskBase task);

        /// <summary>
        /// Обновление задачи
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TaskBase Update(TaskBase entity);

        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <param name="id"></param>
        void Delete(long id);

        /// <summary>
        /// Получение задачи по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TaskBase Get(long id);
    }
}