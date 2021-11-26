using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka
{
    public static class Creator
    {
			private static Hashtable buildings = new Hashtable();
			public static void CreateBuild()
			{
				Building building = new Building();
				buildings[building.Index] = building;
			}
			public static void CreateBuild(float height, byte numberStoreys, byte numberEntrance, short numberFlats)
			{
				Building building = new Building(height, numberStoreys, numberEntrance, numberFlats);
				buildings[building.Index] = building;
			}
			public static void DeleteBuilding(int id)
			{
				buildings.Remove(id);
			}
			public static List<Building> GetCreatedBuildingsList()
			{
				//Возращаем список значений хеш таблицы Buildeing
				List<Building> buildingsList = new List<Building>();
				foreach (var item in buildings.Values)
				{
					if (item is Building)
					{
						buildingsList.Add((Building)item);
					}
				}
				return buildingsList;
			}

		}
	}

