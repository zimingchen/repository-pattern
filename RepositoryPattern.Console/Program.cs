using RepositoryPattern.Data.Models;
using RepositoryPattern.Repositories;
using RepositoryPattern.Repository1;
using System;

namespace RepositoryPattern.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {           
            while(true)
            {
                System.Console.WriteLine("Test For: repo | repo1 | exit");
                System.Console.WriteLine($"--------------------------------------------------");
                var result = System.Console.ReadLine().ToLower().Trim();         
                
                if (result == "repo") TestRepository();
                else if (result == "repo1") TestRepository1();
                else break;
            }            
        }

        private static void TestRepository()
        {
            var random = new Random();

            using (var unitOfWork = new UnitOfWork())
            {
                var project = new Project();
                project.ProjectName = $"Test Repo - {DateTime.Now.ToLongDateString()}";
                project.ProjectTypeId = 100;
                unitOfWork.Projects.Add(project);
                unitOfWork.Save();

                project = unitOfWork.Projects.GetLastAdded();
                System.Console.WriteLine($"After TestRepository Insert:");
                System.Console.WriteLine($"Project Name: {project.ProjectName}, Project Type Id: {project.ProjectTypeId}");
                System.Console.WriteLine($"--------------------------------------------------");
            }
        }

        private static void TestRepository1()
        {
            var random = new Random();
            var repo = new ProjectRepository1();
            repo.ProjectId = 1;
            RepositoryEngine.Get(repo);

            System.Console.WriteLine("Before TestRepository1 Update:");
            System.Console.WriteLine($"Project Name: {repo.ProjectName}, Project Type Id: {repo.ProjectTypeId}");
            System.Console.WriteLine($"--------------------------------------------------");

            repo.ProjectName = $"Test Repo1 - {DateTime.Now.ToLongDateString()}";
            repo.ProjectTypeId = random.Next(10);
            RepositoryEngine.Update(repo);

            System.Console.WriteLine("After TestRepository1 Update:");
            System.Console.WriteLine($"Project Name: {repo.ProjectName}, Project Type Id: {repo.ProjectTypeId}");
            System.Console.WriteLine($"--------------------------------------------------");
        }
    }
}
