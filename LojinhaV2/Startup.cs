using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using LojinhaV2.Models;
using Owin;

namespace LojinhaV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            iniciaAplicacao();
        }
        private void iniciaAplicacao()
        {

            ApplicationDbContext db = new ApplicationDbContext();

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

            //// criar a Role 'Agentes'
            //if (!roleManager.RoleExists("Agentes"))
            //{
            //    // não existe a 'role'
            //    // então, criar essa role
            //    var role = new IdentityRole();
            //    role.Name = "Agentes";
            //    roleManager.Create(role);
            //}

            //// criar a Role 'Condutores'
            //if (!roleManager.RoleExists("Condutores"))
            //{
            //    // não existe a 'role'
            //    // então, criar essa role
            //    var role = new IdentityRole();
            //    role.Name = "Condutores";
            //    roleManager.Create(role);
            //}



            //// criar um utilizador 'Agente'
            //var user = new ApplicationUser();
            //user.UserName = "tania@mail.pt";
            //user.Email = "tania@mail.pt";
            ////  user.Nome = "Luís Freitas";
            //string userPWD = "123_Asd";
            //var chkUser = userManager.Create(user, userPWD);

            ////Adicionar o Utilizador à respetiva Role-Agente-
            //if (chkUser.Succeeded)
            //{
            //    var result1 = userManager.AddToRole(user.Id, "Agentes");
            //}
        }
    }
}
