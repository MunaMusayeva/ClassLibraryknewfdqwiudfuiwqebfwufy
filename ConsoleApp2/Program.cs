using ClassLibrary2.Concrate;
using Microsoft.EntityFrameworkCore;
using SosialMedia.Context;
using SosialMedia.DAL.Repositories.Abstract;
using SosialMedia.DAL.Repositories.Concrate;

public class Program
{
    static void Main(string[] args)
    {
        //UserDetailsRepository userDetailsRepository = new UserDetailsRepository();
        //UserRepository userRepository = new UserRepository();
        //PostRepository postRepository = new PostRepository();
        //CommentRepository commentRepository = new CommentRepository();

        //UserDetails user_INFO_1 = new UserDetails()
        //{
        //    Name = "",
        //    Surname = "",
        //    Birthday = DateTime.Now,
        //    Role=Roles.Admin
        //};

        //User user1 = new User()
        //{
        //    UserDetailsId = 1
        //};
        //Comment commentClass1 = new Comment()
        //{
        //    Text = "hello",
        //    Comments = new List<Comment>() { new Comment() { Text="hello"} },

        //};
        //Post post1 = new Post()
        //{
        //    Text = "Step It Academy",
        //    Comment= commentClass1,
        //    UserId = 1,
        //};

       

        //userDetailsRepository.Add(user_INFO_1);
        //userRepository.Add(user1);
        //postRepository.Add(post1);
        //commentRepository.Add(commentClass1);

        //userDetailsRepository.SaveChanges();
        //userRepository.SaveChanges();
        //postRepository.SaveChanges();
        //commentRepository.SaveChanges();


        using (var unitOfWork = new UnitOfWork(new SosialMediaDb()))
        {
            var userDetails = new UserDetails
            {
                Name = "Nazim",
                Surname = "Nazimli",
                Birthday = DateTime.Now,
                Role = Roles.Admin
            };
            unitOfWork.UserDetails.Add(userDetails);
            unitOfWork.Complete();
        }
    }
}

