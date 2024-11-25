using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleUserScreen
{
    public class SetRoleToUserScreen
    {
        public static void Load()
        {
            System.Console.WriteLine("Enter UserId: ");
            var userId = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Role Id: ");
            var roleId = int.Parse(Console.ReadLine());

            Create(new UserRole
            {
                UserId = userId,
                RoleId = roleId,
            });

            System.Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadKey();
            //MenuUserScreen.Load();
        }

        private static void Create(UserRole userRole)
        {
            try
            {
                //validating if this role and user already exists.
                var userRepository = new Repository<User>();
                var userId = userRepository.GetById(userRole.UserId);
                var roleRepository = new Repository<Role>();
                var roleId = roleRepository.GetById(userRole.RoleId);


                if (userId != null && roleId != null)
                {
                    //Setting a Role to a USER
                    var repository = new Repository<UserRole>();
                    repository.Create(userRole);
                    System.Console.WriteLine();
                    System.Console.WriteLine("Successfully created! ");
                }
                else
                {
                    System.Console.WriteLine("Failed create.");
                    System.Console.WriteLine("You must enter a Role ID and User ID that already exists.");
                    System.Console.WriteLine();
                }


            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine("Ocurred an error to try setting a Role to a User.");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}