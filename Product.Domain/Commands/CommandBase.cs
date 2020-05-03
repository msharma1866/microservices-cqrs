using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace Product.Domain.Commands
{
    public class CommandBase<T> : IRequest<T> where T : class
    {
    }
}
