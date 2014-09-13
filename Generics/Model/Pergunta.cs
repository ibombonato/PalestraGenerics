﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Interfaces;

namespace Generics.Model
{
    public class Pergunta : IBlacklistEntity
    {
        public int Id { get; set; }
        public string Texto { get; set; }
    }
}
