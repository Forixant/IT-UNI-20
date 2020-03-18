using System.Collections.Generic;
using System.Linq;

using ITUniversity.Tasks.Entities;

namespace ITUniversity.Tasks.Stores
{
    public class TaskMemoryStore : ITaskStore
    {
        private List<TaskBase> tasks;

        private long counter;

        public TaskMemoryStore()
        {
            this.tasks = new List<TaskBase>();
        }

        public void Delete(long id)
        {
            //удаление элемента по id из list
            tasks.Remove(tasks.FirstOrDefault(item => item.Id == id));
        }

        public TaskBase Get(long id)
        {
            //получение элемента по id из list
            return tasks.FirstOrDefault(item => item.Id == id);
        }

        public TaskBase Save(TaskBase task)
        {
            var saved = tasks.FirstOrDefault(item => item == task);
            if (saved != null)
            {
                return saved;
            }
            task.Id = counter++;
            tasks.Add(task);
            return task;
        }

        public TaskBase Update(TaskBase entity)
        {
            var saved = tasks.FirstOrDefault(item => item == entity);
            if (saved != null)//если такая задача присутствует
            {
                //обновляем поля
                saved.Subject = entity.Subject;
                saved.CreationDate = entity.CreationDate;
                saved.Status = entity.Status;
                saved.Descr = entity.Descr;
                //возвращаем изменённую задачу
                return tasks.FirstOrDefault(item => item == saved);
            }
            return null;
        }
    }
}