using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka
{
    public class Building
    {	
			private int index;
			private double high;
			private int storeys;
			private int aparts;
			private int entrances;

			static int i = 0;
			static List<int> indexes = new List<int>(); //вводим лист индексов
			public Building() //увеличение индексов по умолчанию
			{
				index = i++;
			}
			public Building(double High, int Storeys, int Aparts, int Entrances)
			{
				index = i++;
				this.High = High;
				this.Storeys = Storeys;
				this.Aparts = Aparts;
				this.Entrances = Entrances;
			}
			public int Index //свойство для индексов
			//оно читает и возвразает значение индекса
			// потом записывает
			//если в индексе содержится значение,то в список индексов добавляется новый элемент
			{
				get
				{
					return index;
				}
				set
				{
					if (!indexes.Contains(value))
					{
						if (value > 0)
						{
							index = value;
							indexes.Add(Index);
						}
						else
						{
							throw new ArgumentOutOfRangeException("Значение может быть только неотрицательным числом.");
						}
					}
					else
					{
						throw new Exception("Экземляр с таким номером уже существует.");
					}
				}
			}
			public double High
			{
				get
				{
					return high;
				}
				set
				{
					if (value > 0)
					{
						high = value;
					}
					else
					{
						throw new ArgumentOutOfRangeException("Значение может быть только положительным числом.");
					}
				}

			}
			public int Storeys
			{
				get
				{
					return storeys;
				}
				set
				{
					if (value > 0)
					{
						storeys = value;
					}
					else
					{
						throw new ArgumentOutOfRangeException("Значение может быть только натуральным числом.");
					}
				}

			}
			public int Aparts
			{
				get
				{
					return aparts;
				}
				set
				{
					if (value > 0)
					{
						aparts = value;
					}
					else
					{
						throw new ArgumentOutOfRangeException("Значение может быть только натуральным числом.");
					}
				}
			}
			public int Entrances
			{
				get
				{
					return entrances;
				}
				set
				{
					if (value > 0)
					{
						entrances = value;
					}
					else
					{
						throw new ArgumentOutOfRangeException("Значение может быть только натуральным числом.");
					}
				}
			}
			public double GetHighOfStorey(int NumberOfStorey)
			{
				if (NumberOfStorey <= storeys && NumberOfStorey > 0)
				{
					return high / storeys * NumberOfStorey;
				}
				else
				{
					throw new ArgumentOutOfRangeException("Такого номера этажа не существует.");
				}
			}
			public int GetApartNumberOfEntrance()
			{
				return aparts / entrances;
			}
			public int GetApartNumberOfStorey()
			{
				return GetApartNumberOfEntrance() / storeys;
			}
			public override string ToString()
			{
				return ($"ID: {Index} Высота {High} Этажность {Storeys} Подъездов {Entrances} Квартир {Aparts}");
			}
		}
	}

