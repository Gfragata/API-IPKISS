using API_IPKISS.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API_IPKISS.Service
{
    public class BalanceService : IBalanceService
    {
        public bool GetBalance(int account_id)
        {
            if (account_id == 1234)
            {
                var retorno = 0;
                throw new Exception(retorno.ToString());
            }
            else
            {
                return true;
            }

        }
    }
}
