using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IZONE.Anniversarys
{
    public class AnniRegist
    {
        public AnniRegist()
        {

        }

        public List<Anniversary> Regist()
        {
            var AnniversaryListType = from Anniversary in Assembly.GetExecutingAssembly().GetTypes()
                                      where Anniversary.IsClass && Anniversary.IsSubclassOf(typeof(Anniversary))
                                      select Anniversary;

            List<Anniversary> AnniversaryList = new List<Anniversary>();

            foreach (Type Anniversary in AnniversaryListType)
            {
                Type[] emptyType = Type.EmptyTypes; // 파라미터가 없는 생성자의 경우 사용.
                ConstructorInfo emptyConstructor = Anniversary.GetConstructor(emptyType); // 파라미터가 없는 생성자를 가져옴.
                AnniversaryList.Add((Anniversary)emptyConstructor.Invoke(new object[] { }));
            }

            return AnniversaryList;
        }
    }
}
