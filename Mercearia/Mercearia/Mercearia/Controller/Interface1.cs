using Mercearia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia.Controller
{
    internal interface ICrud<T>
    {
        T Cadastrar(T obj);
        T Editar(T obj);
        T Excluir(T obj);
        T Consultar(T obj);
        T ConsultarId(T obj);
    }
}
