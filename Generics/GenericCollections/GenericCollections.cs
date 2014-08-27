using System;
using System.Collections;
using System.Collections.Generic;
using Generics.Model;

namespace Generics.GenericCollections
{
    public class GenericCollections
    {
        public void WriteCollections()
        {
            ColecaoNaoGenerica();
            //ColecaoGenerica();
            Console.ReadLine();
        }

        public void ColecaoNaoGenerica()
        {
            ArrayList perguntas = new ArrayList();

            perguntas.Add(new Pergunta() {Id = 1, Texto = "Pergunta 1"});
            perguntas.Add(new Pergunta() { Id = 2, Texto = "Pergunta 2" });
            perguntas.Add(new Pergunta() { Id = 3, Texto = "Pergunta 3" });
            //perguntas.Add("");
            foreach (var pergunta in perguntas)
            {
                Console.WriteLine(pergunta);
                //Console.WriteLine(pergunta.Texto);
            }
        }
        
        public void ColecaoGenerica()
        {
            List<Pergunta> perguntas = new List<Pergunta>();

            perguntas.Add(new Pergunta() { Id = 1, Texto = "Pergunta 1" });
            perguntas.Add(new Pergunta() { Id = 2, Texto = "Pergunta 2" });
            perguntas.Add(new Pergunta() { Id = 3, Texto = "Pergunta 3" });
            //perguntas.Add("");
            foreach (var pergunta in perguntas)
            {
                Console.WriteLine(pergunta);
                //Console.WriteLine(pergunta.Texto);
            }
        }

    }
}
