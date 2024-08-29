using System;
namespace ATMAPPCONSOLE
{
    public interface IAtmOperationInterf
    {
        void ViewBalance();
        void WithdrawAmount(double withdrawAmount);
        void DepositAmount(double depositAmount);
        void ViewMiniStatement();
    }
}

