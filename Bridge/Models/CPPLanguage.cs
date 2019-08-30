using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Models
{
    class CPPLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("С помощью компилятора C++ компилируем программу в бинарный код");
        }

        public void Execute()
        {
            Console.WriteLine("Запускаем исполняемый файл программы");
        }
    }
}
