﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkComponents
{
	/// <summary>
	/// Сохраняет все пакеты
	/// </summary>
	public static class PackageManager
	{
		static List<Package> packages = new List<Package>();

		public static void Clear()
		{
			packages.Clear();
		}

		public static void AddPackage(Package package)
		{
			if (!packages.Contains(package))
				packages.Add(package);
		}
	}
}