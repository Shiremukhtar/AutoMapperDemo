using AutoMapper;
using AutoMapperDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperDemo.ModelView;

namespace AutoMapperDemo.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;

        }
        public IActionResult Index()
        {
            var user = Get();
            var userViewModel = _mapper.Map<UserModelView>(user);
            return View(userViewModel);
        }

        private static User Get()
        {
            return new User
            {
                FirstName = "Lisa",
                LastName = "Kalle",
                Email = "lisa@gmail.com"
            };
        }
    }
}
