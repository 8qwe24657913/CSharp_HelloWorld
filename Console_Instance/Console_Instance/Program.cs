﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Instance {
    class Program {
        static void Main(string[] args) {
            var hello = new HelloWorld("Hello");
            hello.Show(args);
        }
    }
}