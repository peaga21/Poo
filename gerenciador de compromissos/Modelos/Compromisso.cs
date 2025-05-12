using System;
using System.Collections.Generic;

public class Compromisso
{
    public DateTime DataHora { get; private set; }
    public string Descricao { get; private set; }
    public Usuario Responsavel { get; private set; }
    public Local Local { get; private set; }
    private List<Participante> _participantes = new List<Participante>();
    private List<Anotacao> _anotacoes = new List<Anotacao>();

    public Compromisso(DateTime dataHora, string descricao, Usuario responsavel, Local local)
    {
        if (dataHora <= DateTime.Now)
            throw new ArgumentException("Data deve ser no futuro.");
        if (string.IsNullOrEmpty(descricao))
            throw new ArgumentException("Descrição é obrigatória.");
        if (responsavel == null)
            throw new ArgumentNullException(nameof(responsavel));
        if (local == null)
            throw new ArgumentNullException(nameof(local));

        DataHora = dataHora;
        Descricao = descricao;
        Responsavel = responsavel;
        Local = local;
    }

    public IReadOnlyCollection<Participante> Participantes => _participantes.AsReadOnly();
    public IReadOnlyCollection<Anotacao> Anotacoes => _anotacoes.AsReadOnly();

    public void AdicionarParticipante(Participante participante)
    {
        if (participante == null)
            throw new ArgumentNullException(nameof(participante));
        if (!Local.ValidarCapacidade(_participantes.Count + 1))
            throw new InvalidOperationException("Capacidade do local excedida.");

        _participantes.Add(participante);
        participante.AdicionarCompromisso(this);
    }

    public void AdicionarAnotacao(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            throw new ArgumentException("Texto da anotação não pode ser vazio.");

        _anotacoes.Add(new Anotacao(texto));
    }

    public override string ToString()
    {
        return $"{Descricao} em {Local.Nome} ({DataHora:dd/MM/yyyy HH:mm}) com {_participantes.Count} participantes";
    }
}