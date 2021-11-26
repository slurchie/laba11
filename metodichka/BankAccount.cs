using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commercial
{
	public enum Type
    {
		Сберегательный,
		Текущий
	 
    }
	public class BankAccount
		{
			private int index;
			private Type accountType;
			private decimal balance;

			static int i = 0; // прибавляет + 1 к индексу нового экземпляра
			static List<int> indexes = new List<int>();
			public BankAccount()
			{
				index = i++;
			}
			public BankAccount(int Index, Type accountType, decimal balance)//создаёт конструктор аккаунта
			{
				this.Index = Index;
				AccountType = accountType;
				Balance = balance;
				i++;
			}
			public BankAccount(Type accountType, decimal balance)
			{
				index = i++;
				AccountType = accountType;
				Balance = balance;
			}
			public int Index
			{
				get
				{
					return index;
				}
				set
				{
					if (!indexes.Contains(Index))
					{
						index = value;
						indexes.Add(Index);
					}
					else
					{
						throw new Exception("Экземляр с таким номером уже существует");
					}
				}
			}
			public Type AccountType
			{
				get
				{
					return accountType;
				}
				set
				{
					accountType = value;
				}
			}
			public decimal Balance
			{
				get
				{
					return balance;
				}
				set
				{
					balance = value;
				}
			}

			public void Withdraw(int sum)
			{
				if (sum <= balance)
				{
					balance -= sum;
				}
			}
			public void PutInBalance(int sum)
			{
				if (sum > 0)
				{
					balance += sum;
				}
			}
			public override string ToString()
			{
				return ($"Номер счета: {Index} || Тип: {AccountType} || Баланс: {Balance}");
			}
		}
	}

