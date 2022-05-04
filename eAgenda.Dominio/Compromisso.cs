using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace eAgenda.Dominio
{
    public class Compromisso : EntidadeBase, IEnumerable<Compromisso>
    {
        public Contato _contato = new();
        public string Assunto { get; set; }
        public string Local { get; set; }
        public DateTime? DataCompromisso { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public Contato Contato { get { return _contato; } set { _contato = value; } }

        public override string ToString()
        {
            if (Contato != null)
            {
                return $"ID: {id} Assunto: {Assunto} Local: {Local} Data: {DataCompromisso} Hora início: {HoraInicio} Hora fim: {HoraFim} Contato: {Contato}";
            }
           
                return $"ID: {id} Assunto: {Assunto} Local: {Local} Data: {DataCompromisso} Hora início: {HoraInicio} Hora fim: {HoraFim}";
                
        }

        public override string Validar()
        {
            StringBuilder sb = new();

            if (string.IsNullOrEmpty(Assunto))
                sb.AppendLine("O assunto é obrigatório!");
            if (string.IsNullOrEmpty(Local))
                sb.AppendLine("O local do compromisso é obrigatório!");
            if (!DataCompromisso.HasValue)
                sb.AppendLine("A data é obrigatória!");
            if (DataCompromisso < DateTime.Now)
                sb.AppendLine("A data do compromisso não pode ser antes que Hoje!!");
            if (HoraInicio > HoraFim)
                sb.AppendLine("A data inicial do compromisso não pode ser menor que a final");

            if (sb.Length == 0)
                sb.AppendLine("REGISTRO_VALIDO");

            return sb.ToString();
        }
        //para não dar erro do IEnumerable - NAO MEXE
        public IEnumerator<Compromisso> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        //para não dar erro do IEnumerable - NAO MEXE
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}