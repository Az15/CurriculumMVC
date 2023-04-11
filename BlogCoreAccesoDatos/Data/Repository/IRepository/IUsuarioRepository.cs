﻿using BlogCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlogCore.AccesoDatos.Data.Repository.IRepository
{
    public interface IusuarioRepository : IRepository<ApplicationUser>
    {
       void BloquearUsuario(string Id);
        void DesbloquearUsuario(string ID);
    }
}
