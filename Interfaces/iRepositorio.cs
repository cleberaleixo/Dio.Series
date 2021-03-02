using System.Collections.Generic;


namespace Dio.Series.Interfaces
{
    public interface iRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorID(int id);
        void Insere(T entidade);
        void Excluir(int id);
        void Atualizar(int id,T entidade);
        int ProximoId();

    }
}