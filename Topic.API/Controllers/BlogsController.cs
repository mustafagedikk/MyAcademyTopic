using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Topic.BusinessLayer.Abstract;
using Topic.DTOLayer.DTOs.BlogDtos;
using Topic.DTOLayer.DTOs.CategoryDtos;
using Topic.EntityLayer.Entities;

namespace Topic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        public BlogsController(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllBlogs()
        {
            var values = _blogService.TGetBlogsWithCategories();
            var blogs = _mapper.Map<List<ResultBlogDto>>(values);
            return Ok(blogs);
        }

        [HttpGet("{id}")]
        public IActionResult GetBlogsById(int id)
        {
            var values = _blogService.TGetById(id);
            var blog = _mapper.Map<ResultBlogDto>(values);
            return Ok(blog);


        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBlog(int id)
        {
            _blogService.TDelete(id);
            return Ok("Kategori Başarıyla Silindi");
        }

        [HttpPost]

        public IActionResult CreateBlog(CreateBlogDto createBlogDto)
        {
            var blog = _mapper.Map<Blog>(createBlogDto);
            _blogService.TCreate(blog);
            return Ok("Kategori başarıyla oluşturuldu");
        }
        [HttpPut]

        public IActionResult UpdateCategory(UpdateBlogDto updateBlogDto)
        {
            var blog = _mapper.Map<Blog>(updateBlogDto);
            _blogService.TUpdate(blog);
            return Ok("Kategori başarıyla güncellendi");
        }
    }
}
