using System;
using System.Collections.Generic;
using System.Text;

namespace _16iyun
{
    internal class Student
    {
        public int No;
        public string FullName;
        private string _groupNo;
        public string GroupNo
        {
            get { return _groupNo; }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;

                }
            }
        }
        public static int totalCount;
        public Student()
        {
            totalCount++;
            this.No = totalCount;
        }


        public bool CheckGroupNo(string groupNo)
        {

            if (groupNo.Length == 4 && Char.IsLetter(groupNo[0]))
            {
                for (int i = 1; i < groupNo.Length; i++)
                {
                    if (!Char.IsLetter(groupNo[i]))
                    {
                        return false;
                    }

                }
                return true;
            }
            return false;
        }
    }
}
