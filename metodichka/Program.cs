using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commercial;

namespace metodichka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test 1");
            Bank bank = new Bank();
            bank.CreateAccount(4364, Commercial.Type.Сберегательный, 1000);
            bank.CreateAccount();
            bank.CreateAccount();
            bank.DeleteAccount(4364);
            foreach (var item in bank.GetListAccount())
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Test 2");
            Creator.CreateBuild(432, 3, 4, 15);
            Creator.CreateBuild(234, 2, 5, 14);
            Creator.CreateBuild(123, 1, 6, 12);
            Creator.DeleteBuilding(1);
            foreach (var item in Creator.GetCreatedBuildingsList())
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
