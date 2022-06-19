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
	List<int> numbers = new List<int> {67, 92, 153, 15, 33, 109, 4, 62, 50, 127, 21, 37, 420 };
	
	var query =
		from n in numbers
		where n > 30 && n < 100
		orderby n
		select n;
		
	query.Dump("ZAD1");
	
	var query2 = numbers
		.Where(n => n > 30 && n < 100)
		.OrderBy(n => n)
		.Select(n => n);
	
	query.Dump("ZAD1 ALT");
}

void ZAD2()
{
	string [] words = { "computer", "usb", "drive", "sata", "ssd", "cable", "motherboard", "processor", "gpu", "monitor", "ram"};
	
	var query =
		from w in words
		where w.Length >=5
		orderby w.Length
		select w.ToUpper();
		
	query.Dump("ZAD2");
	
	var query2 = words
		.Where(w => w.Length >= 5)
		.OrderBy(w => w.Length)
		.Select(w => w.ToUpper());
		
	query.Dump("ZAD2 ALT");
}

void ZAD3()
{
	ArrayList cities = new ArrayList { "amsterdam", "paris", "rotterdam", "nottingham", "arnhem", "birmingham", "anaheim", "trondheim" };
	
	var query = 
		from string c in cities
		where (c.StartsWith("a") || c.StartsWith("A")) && (c.EndsWith("m") || c.EndsWith("M"))
		select c;
		
	query.Dump("ZAD3");
	"ArrayList cannot be queried using cascading LINQ syntax.".Dump();
}

void ZAD4()
{
	int[] numbers = { -9, -18, 63, 14, 7, 9, 15, 23, 42, -6, -24, 18 };
	
	var query =
		(from n in numbers
		orderby n descending
		select n).Take(5);
	
	query.Dump("ZAD4");
	
	var query2 = numbers
		.OrderByDescending(n => n)
		.Select(n => n)
		.Take(5);
		
	query2.Dump("ZAD4 ALT");
}

void ZAD5()
{
	List<int> numbers = new List<int>() { 4, 3, 16, 21, -4, 6, 40, 7, 2, -8 };
	
	var query =
		from n in numbers
		where n*n > 20
		orderby n
		select $"{n} - {n*n}\n";
		
	query.Dump("ZAD5");
	
	var query2 = numbers
		.Where(n => n*n > 20)
		.OrderBy(n => n)
		.Select(n => $"{n} - {n*n}\n");
		
	query2.Dump("ZAD5 ALT");
}

void ZAD6()
{
	List<string> words = new List<string>() { "learn", "replace", "read", "readjust", "deal", "make", "bake", "take", "need", "lead" };
	
	var query = 
		from w in words
		//where w.Contains("ea")
		select w.Contains("ea") ? w.Replace("ea", "*"): w;
	
	var query2 = words
		.Where(w => w.Contains("ea"))
		.Select(w => w.Replace("ea", "*"));
		
	query.Dump("ZAD6");
	query2.Dump("ZAD6 ALT(only containing ea)");
}

void ZAD7()
{
	string[] words = { "mental", "challenge", "car", "band", "dark", "cramp", "gentle" };
	
	var query =
		(from w in words
		where w.Contains("e")
		orderby w
		select w).LastOrDefault();
		
	var query2 = words
		.Where(w => w.Contains("e"))
		.OrderBy(w => w)
		.Select(w => w)
		/*.LastOrDefault()*/;
		
	query.Dump("ZAD7");
	query2.Dump("ZAD7 ALT");
}

// You can define other methods, fields, classes and namespaces here