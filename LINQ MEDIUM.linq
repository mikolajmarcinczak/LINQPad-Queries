<Query Kind="Program" />

void Main()
{
	ZAD1();
	ZAD2();
	ZAD3();
	ZAD4();
	ZAD5();
	ZAD6();
	ZAD7();
}

void ZAD1() 
{
	int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15 };
	
	var rand = new Random();
	
	var query =
		from n in numbers
		orderby rand.Next()
		select n;
		
	query.Dump("ZAD1");
	
	int[] numbers2 = { 42, 24, 12, 4, 2, -2, -4, -12, -24, -42 };
	var query2 = numbers2
		.OrderBy(n => rand.Next())
		.Select(n => n);
		
	query2.Dump("ZAD1 ALT");
}

void ZAD2() 
{
	char[] special = { ')', '!', '@', '#', '$', '%', '^', '&', '*', '(' };

	string strCheck = "#$&$(@%)!";
	
	var result = string.Join("", strCheck.Select(n => Array.IndexOf(special, n)));
	
	result.Dump("ZAD2");
}

void ZAD3() 
{
	string input = Console.ReadLine();
	
	var query = input
		.GroupBy(c => c)
		.OrderByDescending(c => c.Count())
		.First()
		.Key;
		
	query.Dump("ZAD3");
}

void ZAD4() 
{
	string robo = "robo";
	List<string> list = new List<string> {"abc", "def", "xyz", "def", robo, "opr", "jkl", "abc", "jkl"};
	
	var query = list
		.GroupBy(n => n)
		.Where(n => n.Count() == 1)		
		.Select(n => n.Key)
		.ToList();
		
	query.Dump("ZAD4");
}

void ZAD5() 
{
	string mixed = "this sentence IS really NOT USING only lowercase CHARACTERS would you believe IT";
	
	var query = mixed
		.Split(" ")
		.Where(n => string.Equals(n, n.ToUpper()))
		.Select(n => n);
		
	query.Dump("ZAD5");
}

void ZAD6() 
{
	int[] arr1 = { 5, 3, 2};
	int[] arr2 = { 4, 5, 1 };
	
	var query = arr1
		.Zip(arr2, (var1, var2) => var1 * var2).Sum();
		
	query.Dump("ZAD6");		
}

void ZAD7() 
{
	string str = Console.ReadLine();
	
	var query = str
		.GroupBy(c => c)
		.Select(c => new { @char = c.Key, temp = c.Count() })
		.Select(c => $"{c.@char} appears {c.temp} times.");
		
	query.Dump("ZAD7");
	
	var query2 = str.GroupBy(c => c).Select(c => $"{c.Key} appears {c.Count()} times.");
	
	query2.Dump("ZAD7 ALT");
}