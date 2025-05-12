public class Participante
{
    public string Nome { get; private set; }
    private List<Compromisso> _compromissos = new List<Compromisso>();

    public Participante(string nome)
    {
        Nome = nome;
    }

    public void AdicionarCompromisso(Compromisso compromisso)
    {
        _compromissos.Add(compromisso);
    }
}