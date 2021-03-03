using System;
using ProjectManager.Models;
using ProjectManager.Data.Core;

namespace ProjectManager.Data.Core
{
    public class CoreUserRepository: CoreRepository<User,ApiDbContext>
    {
        public CoreUserRepository(ApiDbContext context) : base(context)
        {

        }
    }
}
