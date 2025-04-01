using AutoMapper;
using DojoSystem.Services.Interfaces;

namespace DojoSystem.Services.Entities;

    public class AcademiaService<T> : IAcademia<T> where T : class
    {
      
      private IMapper mapper;
      private readonly IMapper _mapper;

    }

