namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
            // Here Both Static and instance
            // constructors are invoked for
            // first instance
            //G1 obj = new G1(1);

            //Console.WriteLine(obj.g1_detail("Sunil", "CSE"));
            Console.WriteLine(G1.i);

			// Here only instance constructor
			// will be invoked
			G1 ob = new G1(2);

			Console.WriteLine(ob.g1_detail("Sweta", "ECE"));
		}
	}
	// C# Program to illustrate calling
	// a Static constructor

	class G1
	{
		static public int i = 10;
		// It is invoked before the first
		// instance constructor is run.
		static G1()
		{

			// The following statement produces
			// the first line of output,
			// and the line occurs only once.
			Console.WriteLine("Example of Static Constructor");
		}

		// Instance constructor.
		public G1(int j)
		{
			Console.WriteLine("Instance Constructor " + j);
		}

		// Instance method.
		public string g1_detail(string name, string branch)
		{
			return "Name: " + name + " Branch: " + branch;
		}


	}
}