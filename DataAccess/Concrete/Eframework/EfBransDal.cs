using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Eframework
{
	public class EfBransDal : EfEntityRepositoryBase<Brans, MyProjectContext>, IBransDal 
	{

	}
}
