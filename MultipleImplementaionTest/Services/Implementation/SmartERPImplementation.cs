using MultipleImplementaionTest.Models;
using MultipleImplementaionTest.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleImplementaionTest.Services.Implementation
{
    public class SmartERPImplementation : IsolatedImplementation, IImplementation<SmartERPImplementation>
    {
        //public override  Member Get(int id)
        //{
        //    var list = new List<Member>
        //    {
        //       new Member{
        //            Id=2,
        //            Name="SmartERPImplementation"
        //        }
        //    };

        //    return list.Where(f => f.Id == id).FirstOrDefault();
        //}

        
        public  override void Save(Member member)
        {
            var st = "SmartERPImplementation";
        }

        public override void Update(Member member)
        {
            throw new NotImplementedException();
        }
    }
}