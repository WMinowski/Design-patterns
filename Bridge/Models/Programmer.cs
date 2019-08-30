using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Models
{
    abstract class Programmer
    {
        protected ILanguage language;

        public ILanguage Language
        {
            set { language = value; }
        }

        public Programmer(ILanguage lang)
        {
            language = lang;
        }

        public virtual void DoWork()
        {
            language.Build();

            language.Execute();
        }

        public abstract void EarnMoney();
    }
}
