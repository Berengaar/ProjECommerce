using Application.Common.Interfaces;
using Application.DTO_s.CategoryDtos;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoriesController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync(CategoryAddDto entity)
        {
            if (entity != null)
            {
                var model = _mapper.Map<Category>(entity);
                var result = await _unitOfWork.CategoryWriteRepository.AddAsync(model);
                if (result)
                {
                    return StatusCode(201);
                }
                return Unauthorized();
            }
            return BadRequest();
        }
    }
}
