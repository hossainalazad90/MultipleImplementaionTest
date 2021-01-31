using MultipleImplementaionTest.Models;
using MultipleImplementaionTest.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleImplementaionTest.Services.Implementation
{
    public abstract class IsolatedImplementation: IImplementation<IsolatedImplementation>
    {
        public  virtual Member Get(int id)
        {
            var list = new List<Member>
            {
               new Member{
                    Id=1,
                    Name="Isolated"
                }
            };
            return list.Where(f => f.Id == id).FirstOrDefault();
        }      

        public virtual  void Save(Member member)
        {
            throw new NotImplementedException();
        }

        public virtual  void Update(Member member)
        {
            var model = new Member();
        }
       
    }
}