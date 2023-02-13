﻿using System;
using System.Collections.Generic;
using System.Text;

namespace task123
{
    internal interface ICourse
    {
        Group[] AddGroup(Group groups);
        Group GetGroupByNo(string no);
        Group[] GetGroupsByPointRange(int minPoint, int maxPoint);
        Group[] Search(string search);
    }
}