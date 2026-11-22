
public class Video
{
    public string _titulo;
    public string _autor;

    public int _duracao;

    public List<Comentario> _comentarios = new List<Comentario>();

    public int QuantidadeDeComentarios()
  {
    return _comentarios.Count;
  }
}

    public class Comentario

{
        public string _nomedapessoa;

        public string _textodecomentarios;
}





