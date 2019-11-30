using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikNauczyciela.Model
{
    public class Task
    {
        #region Proprties
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Hashtag> Hashtags { get; set; }
        public TaskType Type { get; set; }
        #endregion

        #region Constructor
        public Task(TaskType type, string name)
        {
            this.Type = type;
            this.Name = name;
            Hashtags = new List<Hashtag>();
        }

        public Task(TaskType type, string name, string description): this(type,name)
        {
            this.Description = description;
        }
        #endregion

        #region Methods

        #endregion
    }
}
