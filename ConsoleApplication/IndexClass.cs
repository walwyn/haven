using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{

    //索引器
    public class IndexClass
    {

        private string[] strs = new string[6];
        /// <summary>
        /// 加索引器
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public string this[int i]
        {
            get { return strs[i]; }
            set { strs[i] = value; }
        }

        /// <summary>
        /// 字符串进行索引
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int this[string name] 
        {
            get {
                int index = -1;
                for (int i = 0; i < strs.Length; i++) 
                {
                    if (strs[i] == name) 
                    {
                        index = i;
                        break;
                    }
                }

                    return index;
            }
            set { }
        }

    }
}
