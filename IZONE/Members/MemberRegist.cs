using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Members
{
    public class MemberRegist
    {
        public MemberRegist()
        {

        }

        public List<Member> Regist()
        {
            var MemberListType = from Member in Assembly.GetExecutingAssembly().GetTypes()
                                 where Member.IsClass && Member.IsSubclassOf(typeof(Member))
                                 select Member;

            List<Member> MemberList = new List<Member>();

            foreach (Type MemberType in MemberListType)
            {
                Type[] emptyType = Type.EmptyTypes; // 파라미터가 없는 생성자의 경우 사용.
                ConstructorInfo emptyConstructor = MemberType.GetConstructor(emptyType); // 파라미터가 없는 생성자를 가져옴.
                MemberList.Add((Member)emptyConstructor.Invoke(new object[] { }));
            }

            return MemberList;
        }
    }
}
