using MultipleImplementaionTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleImplementaionTest.Services.Interface
{
  public  interface IImplementation<T> where T:class 
    {
        void Save(Member member);
        Member Get(int id);
        void Update(Member member);
    }
}
