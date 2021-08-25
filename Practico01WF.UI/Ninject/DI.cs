﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Practico01WF.UI.Ninject
{
    public class DI
    {
        private static StandardKernel _kernel;

        public static void Inicialize()
        {
            _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
        }

        public static T Create<T>()
        {
            return _kernel.Get<T>();
        }

    }
}