using RepositoryPattern.Data;
using System;

namespace RepositoryPattern.Repository1
{
    public class RepositoryEngine
    {
        public static void Get(IGetable repository) =>
            ExecuteAction((context) =>
            {
                repository.Get(context);
            });

        public static void Update(IUpdatable repository) =>
            ExecuteAction((context) =>
            {
                repository.Update(context);
            }, true);

        private static void ExecuteAction(Action<RepositoryPatternContext> action, bool saveChanges = false)
        {
            try
            {
                using (var context = new RepositoryPatternContext())
                {
                    action(context);
                    if (saveChanges) context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //Log Error.
            }
        }
    }
}
