using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class CreditCard
    {
        private long _idCard;
        private string _name;
        private int _CVC;
        private DateTime _dateCard;

        public CreditCard(long idCard, string name,
            int cVC, DateTime dateCard)
        {
            _idCard = idCard;
            _name = name;
            _CVC = cVC;
            _dateCard = dateCard;
        }

        public void Print()
        {
            Console.WriteLine($"Номер карты: {_idCard}\n CVC: {_CVC}" +
            $"\nГоден до: { _dateCard.ToShortDateString()}" +
            $"\n ФИО: { _name}");
        }
    }
}
