﻿using System.Collections.Generic;
using ITUniversity.Tasks.Entities;
using ITUniversity.Tasks.Stores;

namespace ITUniversity.Tasks.Managers
{
    /// <inheritdoc/>
    public class TaskManager : ITaskManager
    {
        private readonly ITaskStore taskStore;

        public TaskManager(ITaskStore taskStore)
        {
            this.taskStore = taskStore;
        }

        /// <inheritdoc/>
        public TaskBase Create(TaskBase task)
        {
            return taskStore.Save(task);
        }

        /// <inheritdoc/>
        public TaskBase Create(string subject)
        {
            var task = new TaskBase { Subject = subject };
            return taskStore.Save(task);
        }

        public ICollection<TaskBase> GetAll()
        {
            return taskStore.GetAll();
        }
    }
}