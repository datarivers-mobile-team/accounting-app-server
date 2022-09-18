using Accounting.DAL.DataContext;

namespace Accounting.BLL.Framework;
public class BaseApplicationService
{
    protected readonly AccountingDbContext _accountingDbContext;

	public BaseApplicationService(AccountingDbContext accountingDbContext)
	{
		_accountingDbContext = accountingDbContext;
	}
}
