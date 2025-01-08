class Program
{
    static void Main()
    {
        string filePath = "counter.txt";

        // Initialize or update the counter
        int currentCount = 1;

        if (File.Exists(filePath))
        {
            string fileContent = File.ReadAllText(filePath);
            if (int.TryParse(fileContent, out currentCount))
            {
                currentCount++;
            }
        }

        // Write the updated count back to the file
        File.WriteAllText(filePath, currentCount.ToString());
        Console.WriteLine($"Counter updated to: {currentCount}");
    }
}