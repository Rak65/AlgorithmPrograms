using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter the number of tasks: ");
            int n = int.Parse(Console.ReadLine());

            List<Task> tasks = new List<Task>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the deadline and minutes required for task {0} (separated by space):", i + 1);
                string[] input = Console.ReadLine().Split(' ');
                int deadline = int.Parse(input[0]);
                int minutes = int.Parse(input[1]);
                tasks.Add(new Task(deadline, minutes));
            }

            // Sort the tasks based on their deadlines in ascending order
            tasks.Sort((x, y) => x.Deadline.CompareTo(y.Deadline));

            int maxOvershoot = 0;
            int completionTime = 0;

            foreach (Task task in tasks)
            {
                // Calculate the completion time for the task
                completionTime += task.Minutes;
                int overshoot = Math.Max(completionTime - task.Deadline, 0);
                maxOvershoot = Math.Max(maxOvershoot, overshoot);
            }

            Console.WriteLine("Maximum amount by which a task's completion time overshoots its deadline: " + maxOvershoot);
            Console.ReadKey();
        }
    }
}
