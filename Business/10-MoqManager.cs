using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class MoqManager
    {
        private IManagerDal _managerDal;
        public MoqManager(IManagerDal managerDal)
        {
            _managerDal = managerDal;
        }
        public void Add(int Id)
        {
            if (_managerDal.IsExist(x => Id == x))
                throw new ArgumentException("Bu zaten kayıtlı");
            _managerDal.Add(Id);
        }
    }

    public class YDal : IManagerDal
    {
        public void Add(int Id) { Console.WriteLine("Y added"); }

        public bool IsExist(Expression<Func<int, bool>> expression)
        {   //db logic
            return true;
        }
    }
    public class XDal : IManagerDal
    {
        public void Add(int Id) { Console.WriteLine("X added"); }

        public bool IsExist(Expression<Func<int, bool>> expression)
        {//db logic
            return true;
        }
    }
    public interface IManagerDal { void Add(int Id); bool IsExist(Expression<Func<int, bool>> expression); }
}
