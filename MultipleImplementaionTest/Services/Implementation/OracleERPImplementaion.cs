using MultipleImplementaionTest.Models;
using MultipleImplementaionTest.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleImplementaionTest.Services.Implementation
{
    public class OracleERPImplementaion: IsolatedImplementation, IImplementation<OracleERPImplementaion>
    {
        public override  Member Get(int id)
        {
            var list = new List<Member>
            {
               new Member{
                    Id=3,
                    Name="OracleERPImplementaion"
                }
            };

            return list.Where(f => f.Id == id).FirstOrDefault();
        }
        

        public  override  void Save(Member member)
        {
            var st = "OracleERPImplementaion";
        }

        public override  void Update(Member member)
        {
            var model = new Member();
        }
    }
}