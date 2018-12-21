using rm=System.Console;
class student
{
	public static void Main(string[] a)
	{
		int roll;
		string nm;
		int m1,m2;
		double per;
		rm.WriteLine("Enter your roll number: ");
		roll = int.Parse(rm.ReadLine());
		rm.WriteLine("Enter your name: ");
		nm=rm.ReadLine();
		rm.WriteLine("Enter your two subjects marks: ");
		m1=int.Parse(rm.ReadLine());
		m2=int.Parse(rm.ReadLine());

		per=((m1+m2)/2.0);
		rm.WriteLine("your percentage is: "+per);
	}
}