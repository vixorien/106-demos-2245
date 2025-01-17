// Chris Cascioli
// 1/17/25
// Example of binary file writing and reading

namespace BinaryFileDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Set up the file name
			string filename = "test.data";

			// Write then read the data
			WriteBinaryFile(filename);
			ReadBinaryFile(filename);
		}

		static void WriteBinaryFile(string filename)
		{
			// Ideally, use a try/catch

			// Open the file for writing and pass to our writer
			FileStream outputStream = File.OpenWrite(filename);
			BinaryWriter output = new BinaryWriter(outputStream);

			// Write some data
			output.Write(12345);	// 32 bits (4)
			output.Write(3.14159);  // 64 bits (8)
			output.Write("Hello there!");
			output.Write(false);	// 8 bits (1)
			output.Write('Z');		// 16 bits (2)
			output.Write((byte)3);	// 8 bits (1)

			// Close the writer (and underlying stream)
			output.Close();
		}

		static void ReadBinaryFile(string filename)
		{
			// Open the file and feed to a binary reader
			FileStream inputStream = File.OpenRead(filename);
			BinaryReader input = new BinaryReader(inputStream);

			// Read the data
			int i = input.ReadInt32();
			double d = input.ReadDouble();
			string s = input.ReadString();
			bool b = input.ReadBoolean();
			char c = input.ReadChar();
			byte otherB = input.ReadByte();

			Console.WriteLine(i);
			Console.WriteLine(d);
            Console.WriteLine(s);
			Console.WriteLine(b);
			Console.WriteLine(c);
			Console.WriteLine(otherB);

			// Close at the end
			input.Close();
		}
	}
}
