using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController:ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Models.Tickets>> GetTickets(){
            return new Models.Tickets[] {
                new Models.Tickets(){IdTicket = 0, Cliente = "Fernando Crozetta", Titulo = "Titulo do chamado 0", Descricao = "Descrição do chamado 0"},
                new Models.Tickets(){IdTicket = 1, Cliente = "Fernando Crozetta", Titulo = "Titulo do chamado 1", Descricao = "Descrição do chamado 1"},
                new Models.Tickets(){IdTicket = 2, Cliente = "Fernando Crozetta", Titulo = "Titulo do chamado 2", Descricao = "Descrição do chamado 2"},
                new Models.Tickets(){IdTicket = 3, Cliente = "Fernando Crozetta", Titulo = "Titulo do chamado 3", Descricao = "Descrição do chamado 3"},
                new Models.Tickets(){IdTicket = 4, Cliente = "Fernando Crozetta", Titulo = "Titulo do chamado 4", Descricao = "Descrição do chamado 4"},
                new Models.Tickets(){IdTicket = 5, Cliente = "Fernando Crozetta", Titulo = "Titulo do chamado 5", Descricao = "Descrição do chamado 5"},
                new Models.Tickets(){IdTicket = 6, Cliente = "Fernando Crozetta", Titulo = "Titulo do chamado 6", Descricao = "Descrição do chamado 6"},
                new Models.Tickets(){IdTicket = 7, Cliente = "Fernando Crozetta", Titulo = "Titulo do chamado 7", Descricao = "Descrição do chamado 7"},
                new Models.Tickets(){IdTicket = 8, Cliente = "Fernando Crozetta", Titulo = "Titulo do chamado 8", Descricao = "Descrição do chamado 8"},
                new Models.Tickets(){IdTicket = 9, Cliente = "Fernando Crozetta", Titulo = "Titulo do chamado 9", Descricao = "Descrição do chamado 9"},
            };
        }
    }
}