﻿

namespace Ossmmasoft.Controllers.Local.PreTitulos
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreatePreTitulosController
    {
        readonly ICreatePreTituloInputPort _inputPort;
        readonly ICreatePreTituloOutputPort _outputPort;
        public CreatePreTitulosController(ICreatePreTituloInputPort inputPort,
                ICreatePreTituloOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<PreTitulosDTO> CreatePreTitulo(CreatePreTituloDTO preTitulo)
        {
            await _inputPort.Handle(preTitulo);

            return ((IPresenter<PreTitulosDTO>)_outputPort).Content;
        }


    }
}
