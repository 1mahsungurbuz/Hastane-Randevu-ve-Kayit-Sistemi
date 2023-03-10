using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Abstract
{
	public interface IEntityServiceBase<T> 
	{
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		List<T> GetAll();
		T Get(int id);
	}
}
