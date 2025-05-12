using System.Collections.ObjectModel;

public class Usuario
{
    public string Nome { get; private set; }
    private List<Compromisso> _compromissos = new List<Compromisso>();
    public IReadOnlyCollection<Compromisso> Compromissos => _compromissos.AsReadOnly();

    public Usuario(string nome)
    {
        Nome = nome;
    }

    public void AdicionarCompromisso(Compromisso compromisso)
    {
        if (compromisso == null)
            throw new ArgumentNullException("Compromisso não pode ser nulo.");
        
        _compromissos.Add(compromisso);
    }
}