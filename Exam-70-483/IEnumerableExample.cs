using System;
using System.Collections;
using System.Text;

namespace Exam_70_483
{
    public class IEnumerableExample : IEnumerable
    {
        string[] filmes = new string[3];
        public string this[int posicao]
        {
            get { return filmes[posicao]; }
            set { filmes[posicao] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            foreach(string filme in filmes)
            {
                yield return filme;
            }
        }
    }

    public class Use_EnumerableExample
    {
        public void Test()
        {
            var enumerable = new IEnumerableExample();
            enumerable[0] = "Senhor dos manés";
            enumerable[1] = "Tranças de um careca";
            enumerable[2] = "Poeira em alto mar";
        }
    }
}
