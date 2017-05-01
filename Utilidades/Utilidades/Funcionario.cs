using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
        public class Funcionario
        {
        public String matricula { get; set; }
            public String PIS { get; set; }
            public String nome { get; set; }
            public Boolean isUsaLeitorBiometrico { get; set; }

        public Funcionario(String PIS)
        {
            this.PIS = PIS;
        }

            public Funcionario( String matricula, String PIS, String nome, Boolean isUsaLeitorBiometrico)

            {
                this.matricula = matricula;
            this.PIS = PIS;
            this.nome = nome;
                this.isUsaLeitorBiometrico = isUsaLeitorBiometrico;
            }

            public static bool IsPis(string pis)
            {

                int[] multiplicador = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma;
                int resto;
                String newpis = pis.Remove(0, 1);

                if (newpis.Trim().Length != 11)
                {
                    return false;
                }

                newpis = newpis.Trim();
                newpis = newpis.Replace("-", "").Replace(".", "").PadLeft(11, '0');
                soma = 0;

                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(newpis[i].ToString()) * multiplicador[i];
                }
                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                return newpis.EndsWith(resto.ToString());

            }

            public Boolean validPIS
            {
                get
                {
                    return IsPis(PIS);
                }
                set
                {

                }
            }
        }
    }

