using AutoMapper;
using Gestion_Alumnos.Shared.DTO;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Util
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //DTO Alumno
            #region DTO Alumno
            CreateMap<CrearAlumnoDTO, Alumno>();
            CreateMap<Alumno,CrearAlumnoDTO>();
            #endregion

            //DTO Materia
            #region DTO Materia
            CreateMap<CrearMateriaDTO, Materia>();
            CreateMap<Materia,CrearMateriaDTO>();
            #endregion
        }
    }
}
