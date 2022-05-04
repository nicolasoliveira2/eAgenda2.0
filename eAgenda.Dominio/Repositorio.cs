using System;
using System.Collections.Generic;

namespace eAgenda.Dominio
{
    public class Repositorio<T> where T : EntidadeBase
    {
        protected readonly List<T> registros;
        protected int contID;

        public Repositorio()
        {
            registros = new List<T>();
        }

        public string Inserir(T registro)
        {
            string resultado = registro.Validar();
            if (resultado.Trim() != "REGISTRO_VALIDO")
                return resultado;

            registro.id = ++contID;
            registros.Add(registro);
            return "REGISTRO_VALIDO";
        }

        public string Editar(T novoRegistro, T antigoRegistro)
        {
            string resultado = novoRegistro.Validar();
            if (resultado != "REGISTRO_VALIDO") 
            return resultado;

            int posicaoEditada = registros.FindIndex(posicaoSelecionada => posicaoSelecionada.id == antigoRegistro.id);
            registros[posicaoEditada] = novoRegistro;
            return "REGISTRO_VALIDO";
        }

        public bool Excluir(T registro)
        {
            return registros.Remove(registro);
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }
        
        public List<T> FiltrarCompromissos(Predicate<T> condicao)
        {
            List<T> registrosFiltrados = new ();

            foreach(T registro in registros)
                if(condicao(registro))
                    registrosFiltrados.Add(registro);

            return registrosFiltrados;
        }
        public List<T> FiltrarCompromissos(Predicate<T> condicao, Predicate<T> condicao2)
        {
            List<T> registrosFiltrados = new ();

            foreach (T registro in registros)
                if (condicao(registro) && condicao2(registro))
                    registrosFiltrados.Add(registro);

            return registrosFiltrados;
        }
        public bool RegistroExistente()
        {
            int quantidade = registros.Count;
            if (quantidade == 0)
                return false;

            else
                return true;
        }

    }
}
