using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class TestClass01
    {

        private string ClassMsg = string.Empty;
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public TestClass01 ()
        { 

        }

        public TestClass01(string msg)
        {
            this.ClassMsg = msg;

        }


        public string getMessage(string msg)
        {

            if(string.IsNullOrEmpty(this.ClassMsg))
                ClassMsg = msg;


            if (string.IsNullOrEmpty(msg) && string.IsNullOrEmpty(this.ClassMsg))
                ClassMsg = "There's no Message";

            return ClassMsg;
        }


    }
}
