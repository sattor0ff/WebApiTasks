using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class ForAllController : ControllerBase
    {
        private ForAllService _forAllService;
        public ForAllController()
        {
            _forAllService = new ForAllService();
        }
        [HttpGet("Task1")]
        public List<Task1Dto> Task1()
        {
            return _forAllService.GetTask1();
        }
        [HttpGet("Task2")]
        public List<Task2Dto> Task2()
        {
            return _forAllService.GetTask2();
        }
        [HttpGet("Task3")]
        public List<Task3Dto> Task3()
        {
            return _forAllService.GetTask3();
        }
        [HttpGet("Task4")]
        public List<Task4Dto> Task4()
        {
            return _forAllService.GetTask4();
        }
        [HttpGet("Task5")]
        public List<Task5Dto> Task5()
        {
            return _forAllService.GetTask5();
        }
        [HttpGet("Task6")]
        public List<Task6Dto> Task6()
        {
            return _forAllService.GetTask6();
        }
        [HttpGet("Task7")]
        public List<Task7Dto> Task7()
        {
            return _forAllService.GetTask7();
        }
        [HttpGet("Task8")]
        public List<Task8Dto> Task8()
        {
            return _forAllService.GetTask8();
        }
        [HttpGet("Task9")]
        public List<Task9Dto> Task9()
        {
            return _forAllService.GetTask9();
        }
        [HttpGet("Task10")]
        public List<Task10Dto> Task10()
        {
            return _forAllService.GetTask10();
        }
    }