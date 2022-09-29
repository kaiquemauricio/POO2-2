﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPOO13
{
    class TriRetan
    {
        private int a;
        private int b;
        private int c;
        private string ns;

        #region construtores

        public TriRetan()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }

        public TriRetan(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        #endregion

        #region getset
        public void setA(int x)
        {
            this.a = x;
        }

        public void setB(int x)
        {
            this.b = x;
        }

        public void setC(int x)
        {
            this.c = x;
        }

        public int getA()
        {
            return this.a;
        }

        public int getB()
        {
            return this.b;
        }

        public int getC()
        {
            return this.c;
        }

        public string getNs()
        {
            return this.ns;
        }
        #endregion

        #region If/Else
        public void trianguloRetangular()
        {
            if (Math.Pow(this.a, 2) == Math.Pow(this.b, 2) + Math.Pow(this.c, 2))
            {
                this.ns = ("ABC Formam Triângulo retângulo");
            }
            else
            {
                if (Math.Pow(this.b, 2) == Math.Pow(this.a, 2) + Math.Pow(this.c, 2))
                {
                    this.ns = ("ABC Formam Triângulo retângulo");
                }
                else
                {
                    if (Math.Pow(this.c, 2) == Math.Pow(this.b, 2) + Math.Pow(this.a, 2))
                    {
                        this.ns = ("ABC Formam Triângulo retângulo");
                    }
                    else
                    {
                        this.ns = ("Não formam Triângulo Retângulo");
                    }
                }
            }
        }
        #endregion
    }
}
