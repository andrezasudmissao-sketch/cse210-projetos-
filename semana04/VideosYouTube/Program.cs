using System;

class Program
{
    static void Main(string[] args)
    {
       Video video1 = new Video();
       video1._titulo = "Video 1";
       video1._autor = "NomeDoAutorDocanal";
       video1._duracao = 300;

       Comentario comentario1 = new Comentario();
       comentario1._textodecomentarios = "Estava perfeito.";
       comentario1._nomedapessoa = "Jullia Beatriz";

       Comentario comentario2 = new Comentario();
       comentario2._textodecomentarios = "Ficou muito bom.";
       comentario2._nomedapessoa = "João Fernandes";

       Comentario comentario3 = new Comentario();
       comentario3._textodecomentarios = "Poderia ter ficado melhor.";
       comentario3._nomedapessoa = "Emanuelle Silva";

       video1._comentarios.Add(comentario1);
       video1._comentarios.Add(comentario2);
       video1._comentarios.Add(comentario3);

       Video video2 = new Video();

       video2._titulo = "Video 2";
       video2._autor = "NomeDoAutorDocanal";
       video2._duracao = 200;

       Comentario comentario4 = new Comentario();
       comentario4._textodecomentarios = "Esse merece o Oscar.";
       comentario4._nomedapessoa = "Fernanda Lima";

       Comentario comentario5 = new Comentario();
       comentario5._textodecomentarios = "Não vi tão feio";
       comentario5._nomedapessoa = "Jesse Ramos";

       Comentario comentario6 = new Comentario();
       comentario6._textodecomentarios = "Tentarei fazer igual";
       comentario6._nomedapessoa = "Emanuel Lima";

       video2._comentarios.Add(comentario4);
       video2._comentarios.Add(comentario5);
       video2._comentarios.Add(comentario6);

        Video video3 = new Video();

       video3._titulo = "Video 3";
       video3._autor = "NomeDoAutorDocanal";
       video3._duracao = 320;

       Comentario comentario7 = new Comentario();
       comentario7._textodecomentarios = "Eu teria feito melhor.";
       comentario7._nomedapessoa = "André Souza";

       Comentario comentario8 = new Comentario();
       comentario8._textodecomentarios = "Farmou aura hoje.";
       comentario8._nomedapessoa = "Sheila Braga";

       Comentario comentario9 = new Comentario();
       comentario9._textodecomentarios = "Super Legal.";
       comentario9._nomedapessoa = "Emanuelly Alcantará";

       video3._comentarios.Add(comentario7);
       video3._comentarios.Add(comentario8);
       video3._comentarios.Add(comentario9);

       List<Video> _video = new List<Video> { video1, video2, video3 };

       foreach (Video video in _video)
       {
        Console.WriteLine($"Título: {video._titulo}");
        Console.WriteLine($"Autor: {video._autor}");
        Console.WriteLine($"Duração: {video._duracao} segundos");
        Console.WriteLine($"Quantidade de comentários: {video.QuantidadeDeComentarios()}");
        Console.WriteLine("Comentários:");
        foreach (Comentario comentario in video._comentarios)
        {
            Console.WriteLine($"- {comentario._nomedapessoa}: {comentario._textodecomentarios}");
        }
        Console.WriteLine();
       }


    }
}