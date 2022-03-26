using AutoMapper;
using Financial.Application.Protos;
using Financial.Domain.Dtos.FinanceAccounts;
using Financial_Client.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Financial_Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialController : ControllerBase
    {
        private readonly IFinanceAccountsService _service;
        private readonly IMapper _mapper;

        public FinancialController(IFinanceAccountsService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateFinancial(FinanceAccountsCreateDto requestDto) 
        {
            var request = _mapper.Map<FinanceAccountsCreateRequest>(requestDto);
            return Ok(await _service.CreateAsync(request));
        }

        [HttpPost("single")]
        public async Task<IActionResult> GetAsync([FromBody] FinanceAccountsSingleRequest request) 
        {
            if (string.IsNullOrWhiteSpace(request.Id))
            {
                return Ok(await _service.GetAllAsync());
            }
            return Ok(await _service.GetAsync(request));
        }
    }
}
