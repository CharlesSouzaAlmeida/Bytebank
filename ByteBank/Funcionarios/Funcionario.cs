﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        // 0 - funcionário
        // 1 - diretor
        // 2 -designer

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        //Criando construtor 

        public double GetBonificacao()
        {

            return Salario * 0.10;
        }
    }
}
