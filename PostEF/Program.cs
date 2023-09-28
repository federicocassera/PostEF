using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ctx = new PostContext();
            var post = new Post() {Title = "Primo Post", Body = "Prova", PubDate = DateTime.Now };
            ctx.Posts.Add(post);
            var mario = new User() { Login = "User1", Password = "secret", Name = "Mario" , Surname = "Rossi"};
            ctx.Users.Add(mario);
            Console.WriteLine(post.Code);
            ctx.SaveChanges();
            Console.WriteLine(post.Code);
            Console.WriteLine(ctx);
            Console.ReadLine();
        }
    }
}
