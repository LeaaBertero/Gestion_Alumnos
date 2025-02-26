using AutoMapper;
using Gestion_Alumnos.BD.Data;
using Gestion_Alumnos.Server.Repositorio;
using Gestion_Alumnos.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Alumnos.BD.Data.Entidades;

namespace Gestion_Alumnos.Server.Controllers
{
    [ApiController]
    [Route("api/Alumnos")]
    public class AlumnosControllers : ControllerBase
    {
        private readonly IAlumnoRepositorio repositorio;
        private readonly IMapper mapper;
        private readonly IPersonaRepositorio personaRepositorio;
        private readonly IUsuarioRepositorio usuarioRepositorio;
        private readonly Context context;

        //constructor
        #region constructor
        public AlumnosControllers(IAlumnoRepositorio repositorio, IMapper mapper, IPersonaRepositorio personaRepositorio, IUsuarioRepositorio usuarioRepositorio, Context context)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
            this.personaRepositorio = personaRepositorio;
            this.usuarioRepositorio = usuarioRepositorio;
            this.context = context;
        }
        #endregion

        //Método Get
        #region Get
        [HttpGet]
        public async Task<ActionResult<List<Alumno>>> Get() 
        {
            return await repositorio.Select();
        }
        #endregion

        //Método Post
        #region Post
        [HttpPost]
        public async Task<ActionResult<int>> Post(CrearAlumnoDTO entidadDTO)
        {
            using (var transaction = await context.Database.BeginTransactionAsync())
            {
                try
                {
                    PrepararDatosAntesDeGuardar(entidadDTO);

                    // Crear la persona
                    var persona = new Persona
                    {
                        Nombre = entidadDTO.Nombre,
                        Apellido = entidadDTO.Apellido,
                        Documento = entidadDTO.Documento,
                        TipoDocumentoId = entidadDTO.TipoDocumentoId,
                        Domicilio = entidadDTO.Domicilio,
                        Telefono = entidadDTO.Telefono
                    };

                    await personaRepositorio.Insert(persona);

                    // Crear el usuario
                    var crearUsuarioDto = new CrearUsuarioDTO
                    {
                        Email = entidadDTO.Email,
                        Contrasena = entidadDTO.Contrasena
                    };

                    var usuario = new Usuario
                    {
                        Email = crearUsuarioDto.Email,
                        Contrasena = crearUsuarioDto.Contrasena,
                        PersonaId = persona.Id
                    };

                    await usuarioRepositorio.Insert(usuario);

                    // Crear el alumno
                    var alumno = mapper.Map<Alumno>(entidadDTO);

                    alumno.UsuarioId = usuario.Id;
                    alumno.Nombre = entidadDTO.Nombre;
                    alumno.Pais = entidadDTO.Pais;
                    alumno.Provincia = entidadDTO.Provincia;
                    alumno.Departamento = entidadDTO.Departamento;
                    alumno.CarreraId = entidadDTO.CarreraId;
                    alumno.FechaNacimiento = entidadDTO.FechaNacimiento;
                    alumno.Sexo = entidadDTO.Sexo;
                    alumno.Edad = entidadDTO.Edad;
                    alumno.CUIL = entidadDTO.CUIL;

                    await repositorio.Insert(alumno);

                    // Hacer commit de la transacción si todo fue exitoso
                    await transaction.CommitAsync();

                    return Ok(new { mensaje = "Alumno creado con éxito", alumno });
                }
                catch (DbUpdateException ex)
                {
                    return BadRequest($"Error al guardar: {ex.InnerException?.Message ?? ex.Message}");
                }
            }
        }
        #endregion


        //Método GetByDoc
        #region GET POR DOCUMENTO
        [HttpGet("Documento/{documento}")]
        public async Task<ActionResult<Alumno>> GetAlumnoPorDocumento(string documento)
        {
            var PersonaAl = await repositorio.GetAlumnoPorDocumento(documento);

            if (PersonaAl == null)
            {
                return NotFound($"No existe un alumno con el documento {documento}");
            }

            var pepe = mapper.Map<Alumno>(PersonaAl);
            return Ok(pepe);
        }
        #endregion

        private void PrepararDatosAntesDeGuardar(CrearAlumnoDTO alumnoDTO)
        {

            alumnoDTO.FotocopiaDNI = alumnoDTO.FotocopiaDNI == null ? "No" : alumnoDTO.FotocopiaDNI;
            alumnoDTO.ConstanciaCUIL = alumnoDTO.ConstanciaCUIL == null ? "No" : alumnoDTO.ConstanciaCUIL;
            alumnoDTO.PartidaNacimiento = alumnoDTO.PartidaNacimiento == null ? "No" : alumnoDTO.PartidaNacimiento;
            alumnoDTO.Analitico = alumnoDTO.Analitico == null ? "No" : alumnoDTO.Analitico;
            alumnoDTO.FotoCarnet = alumnoDTO.FotoCarnet == null ? "No" : alumnoDTO.FotoCarnet;
            alumnoDTO.CUS = alumnoDTO.CUS == null ? "No" : alumnoDTO.CUS;
        }

    }
}
        
