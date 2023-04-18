using Bigio.Services.Abstraction;
using BigioContract.Models;
using BigioDomain.Base;
using BigioDomain.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BigioWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiswaController : ControllerBase
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _logger;

        public SiswaController(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _repositoryManager = repositoryManager;
            _logger = logger;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var siswa = _repositoryManager.SiswaRepository.FindAllSiswa().ToList();
            var siswaDto = siswa.Select(r => new SiswaDto
            {
                id_siswa = r.id_siswa,
                nama = r.nama,
                password = r.password,
                username = r.username



            });

            return Ok(siswa);

        }

        [HttpPost]
        public IActionResult CreateSiswa([FromBody] SiswaDto siswaDto)
        {
            if (siswaDto == null)
            {
                _logger.LogError("Regiondto object sent from client is null");
                return BadRequest("RegionDto object is null");
            }

            var siswa = new Siswa()
            {
                nama = siswaDto.nama,
                id_siswa = siswaDto.id_siswa,
                password = siswaDto.password,
                username = siswaDto.username


            };

            _repositoryManager.SiswaRepository.Insert(siswa);

            //forward 

            var res = _repositoryManager.SiswaRepository.FindLastSiswaId().ToList();
            return Ok(res);

        }

    }
}
