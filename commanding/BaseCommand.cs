using System;

namespace GFramework.core.Commanding
{
    public abstract class BaseCommand
    {

        protected BaseCommand(string ExecutedBy)
        {
            this.ExecutedBy = ExecutedBy;
        }



        public bool Executed { get; set; }



        public DateTime ExecutedOn { get; set; }



        public string ExecutedBy { get; set; }

    }
}
