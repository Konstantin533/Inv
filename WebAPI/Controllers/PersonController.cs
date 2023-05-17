using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        public PersonController()
        {
        }
        /// <summary> Создает новых юзеров </summary>
        /// <remarks> Пример запроса:
        /// POST /createPerson
        /// {
        /// "count" : 12,
        /// }
        /// </remarks>
        /// <response code = "200">
        /// Успешное выполнение
        /// </response>
        /// <response code = "500">
        /// Ошибка API
        /// </response>
        /// <param name="count">Количество юзеров</param>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost(Name ="CreatePerson")]
        public IEnumerable<Person> CreatePerson(int count)
        {
            List<Person> users = HelperFunctions.GenerateRandomUsers(count);
            return users;
        }
    }
}
