﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_BackEnd.Model
{
    public class MessageCollection<T> where T : class
    {
        public string message { get; set; }

        public T model { get; set; }
    }
}
