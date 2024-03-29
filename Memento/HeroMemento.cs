﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    // Memento
    class HeroMemento
    {
        public int Patrons { get; private set; }

        public int Lives { get; private set; }

        public HeroMemento(int patrons, int lives)
        {
            this.Patrons = patrons;

            this.Lives = lives;
        }
    }
}
