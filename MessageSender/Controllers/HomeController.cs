using MessageSender.Data;
using MessageSender.Models;
using MessageSender.Models.Repositories;
using MessageSender.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MessageSender.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        private readonly IUserRepository _userRepository;

        public HomeController(ILogger<HomeController> logger, AppDbContext context, IUserRepository userRepository)
        {
            _logger = logger;
            _context = context;
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendMessageForm(HomeSendMessageViewModel viewModel)
        {
            var user = _userRepository.GetByName(viewModel.Name);
            if (user == null)
            {

                user = _userRepository.Create(new Models.User { Name = viewModel.Name });
            }
            var newViewModel = new HomeSendMessageFormViewModel
            {
                User = user,
                Users = _userRepository.GetAll(),
                Messages = _context.Messages
            };
            //.Select(m => m.UserId == Convert.ToInt32(user.Id))
            return View(newViewModel);
        }

        [HttpPost]
        public IActionResult SendMessageForm(HomeSendMessageFormViewModel viewModel)
        {
            _context.Messages.Add(new Message
            {
                UserId = viewModel.UserId,
                MessageBody = viewModel.MessageBody,
                Title = viewModel.MessageTitle,
                Recipient = viewModel.MessageRecepientName
            });
            _context.SaveChanges();
            var newViewModel = new HomeSendMessageFormViewModel
            {
                User = _userRepository.Get(viewModel.UserId),
                Users = _userRepository.GetAll(),
                Messages = _context.Messages,
            };
            return View(newViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
