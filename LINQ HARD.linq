<Query Kind="Program" />

void Main()
{
	ZAD1();
	ZAD2();
	ZAD3();
}

void ZAD1() 
{
	var daysList = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();
	var query =
		from day in daysList
		select day;
		
	query.Dump("ZAD1");
}

void ZAD2()
{
	var query = Enumerable.Range((char)65,26)
		.SelectMany(n => Enumerable.Range((char)65,26), (n, k) => $"{(char)n}{(char)k}");

	query.Dump("ZAD2");
}

void ZAD3()
{
	int[][] nums = new int[][] {
					new int[] { 1, 1, 1, 1 },
					new int[] { 2, 2, 2, 2 },
					new int[] { 3, 3, 3, 3 },
					new int[] { 4, 4, 4, 4 }
				};

	var query = Enumerable
				.Range(0, nums.Length)
				.Select(n => nums.Select(k => k[n]));

	nums.Dump("ZAD3nums");
	query.Dump("ZAD3");
}

// You can define other methods, fields, classes and namespaces here