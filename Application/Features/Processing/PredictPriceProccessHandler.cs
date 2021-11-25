using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Processing
{
    public class PredictPriceProccessHandler : IRequestHandler<PredictPriceProccess, decimal>
    {
        public async Task<decimal> Handle(PredictPriceProccess request, CancellationToken cancellationToken)
        {
//            var x = new Task<decimal>(100);
            return 23241.230m;
        }
    }
}
