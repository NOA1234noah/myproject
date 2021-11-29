using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bll
{
   
   public class NewGroup
    {
        StudentsCarPoolEntities1 Db = new StudentsCarPoolEntities1();
        public Group FindGroup(int s,int t)
        {
         Group IsExist=Db.Groups.ToList().Where(x => x.SourceId == s && x.TargetId == t).FirstOrDefault();
            if (IsExist != null)
                return IsExist;
            else
            //    Group g = new Group(SourceId = s, TargetId = t);
                Db.Groups.Add(g);

        }

        

    }
}
